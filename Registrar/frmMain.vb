Imports System.Xml
Imports System.Security.Cryptography
Imports System.Security.Cryptography.Xml
Imports System.Text
Imports System.IO

Public Class frmMain

    Dim PrivateKey As String = ""
    Dim PublicKey As String = ""
    Private LicensePath As String = "C:\ProGrid\Licenses\"

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtDate.Value = Now
        txtName.Select()
    End Sub

    Private Sub btnPublic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPublic.Click
        Clipboard.SetText(GetPublicKey())
    End Sub

    ' Get the public validation key
    Private Function GetPublicKey() As String

        If PublicKey <> "" Then Return PublicKey

        Dim rsa As New RSACryptoServiceProvider()
        rsa.FromXmlString(GetPrivateKey())
        Return rsa.ToXmlString(False)

    End Function

    ' Get the private signing key
    Private Function GetPrivateKey() As String

        If PrivateKey <> "" Then Return PrivateKey

        Dim PrivateKeyFile As String = LicensePath + AppName.Text + ".pk"
        If IO.File.Exists(PrivateKeyFile) Then
            PrivateKey = IO.File.ReadAllText(PrivateKeyFile)
        Else
            PrivateKey = CreateKeyPair()
            IO.File.WriteAllText(PrivateKeyFile, PrivateKey)
        End If
        Return PrivateKey

    End Function

    ' Generate a user license
    Private Sub btnLicense_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLicense.Click

        ' Validate the parameters
        txtName.Text = txtName.Text.Trim
        txtEmail.Text = txtEmail.Text.Trim
        If txtName.Text = "" OrElse txtEmail.Text = "" Then Exit Sub

        ' Create the xml to sign
        Dim xmlDoc As New XmlDocument
        Dim xml As String = "<root><product>ProGrid</product><purchaser>" + txtName.Text + "</purchaser><email>" + txtEmail.Text + "</email><purchasedate>" + dtDate.Value.ToString + "</purchasedate></root>"
        xmlDoc.LoadXml(xml)

        ' Sign XML with private key
        SignWithPrivate(xmlDoc, GetPrivateKey())

        ' Get license to send to user
        Dim License As String = xmlDoc.OuterXml

        ' Write license to a file to send to user
        Dim UserFolder As String = LicensePath + txtName.Text + "\"
        Directory.CreateDirectory(UserFolder)
        File.WriteAllText(UserFolder + AppName.Text + ".lic", xmlDoc.OuterXml)

        ' Write an email text file including a random forum name and password
        My.Settings.LastAcctNum += 1
        My.Settings.Save()
        Dim ForumName As String = "Pro" + My.Settings.LastAcctNum.ToString
        Dim Password As String = "pwd" + GetRandom(1111, 9999).ToString
        Dim Email As String = File.ReadAllText(LicensePath + "Email Template.txt")
        Email = Replace(Email, "<PurchaserName>", txtName.Text)
        Email = Replace(Email, "<PurchaserEmail>", txtEmail.Text)
        Email = Replace(Email, "<UserName>", ForumName)
        Email = Replace(Email, "<Password>", Password)
        File.WriteAllText(UserFolder + "Email.txt", Email)

        ' Release the xml document
        xmlDoc = Nothing

        ' Open and clip the email
        Clipboard.SetText(Email)
        Process.Start(UserFolder + "Email.txt")

        ' Append info to the user csv
        Dim entry As String = txtName.Text + "," + txtEmail.Text + "," + dtDate.Value.ToString + "," + ForumName + "," + Password
        IO.File.AppendAllText(LicensePath + "Users.csv", entry)

    End Sub

    Private RanGen As New Random()
    Private Function GetRandom(Optional ByVal Min As Integer = 1, Optional ByVal Max As Integer = 100) As Integer
        Return RanGen.Next(Min, Max + 1)
    End Function

    ' Create a new random key pair
    Private Function CreateKeyPair() As String
        Dim rsa As New RSACryptoServiceProvider()
        CreateKeyPair = rsa.ToXmlString(True)
        rsa.Clear()
    End Function

    ' Extract the public key from the public/private key pair
    Private Function GetPublicKey(ByVal strPrivateKey As String) As String
        Dim rsa As New RSACryptoServiceProvider()
        rsa.FromXmlString(strPrivateKey)
        Return rsa.ToXmlString(False)
    End Function

    ' Encrypt a string using the private or public key
    Private Function Encrypt(ByVal strPlainText As String, ByVal strPublicKey As String) As String
        Dim rsa As New RSACryptoServiceProvider()
        Dim bytPlainText() As Byte
        Dim bytCipherText() As Byte
        Dim uEncode As New UnicodeEncoding()
        rsa.FromXmlString(strPublicKey)
        bytPlainText = uEncode.GetBytes(strPlainText)
        bytCipherText = rsa.Encrypt(bytPlainText, False)
        Encrypt = Convert.ToBase64String(bytCipherText)
        rsa.Clear()
    End Function

    ' Decrypt a string using the private key
    Private Function Decrypt(ByVal strCipherText As String, ByVal strPrivateKey As String) As String
        Dim rsa As New RSACryptoServiceProvider()
        Dim bytPlainText() As Byte
        Dim bytCipherText() As Byte
        Dim uEncode As New UnicodeEncoding()
        rsa.FromXmlString(strPrivateKey)
        bytCipherText = Convert.FromBase64String(strCipherText)
        bytPlainText = rsa.Decrypt(bytCipherText, False)
        Decrypt = uEncode.GetString(bytPlainText)
        rsa.Clear()
    End Function

    ' Sign an xml document with a private key
    Private Sub SignWithPrivate(ByVal Doc As XmlDocument, ByVal strPrivateKey As String)

        ' Create a SignedXml object.
        Dim signedXml As New SignedXml(Doc)

        ' Get key
        Dim key As New RSACryptoServiceProvider()
        key.FromXmlString(strPrivateKey)

        ' Add the key to the SignedXml document.
        signedXml.SigningKey = key

        ' Create a reference to be signed.
        Dim reference As New Reference()
        reference.Uri = ""

        ' Add an enveloped transformation to the reference
        Dim env As New XmlDsigEnvelopedSignatureTransform()
        reference.AddTransform(env)

        ' Add the reference to the SignedXml object
        signedXml.AddReference(reference)

        ' Compute the signature
        signedXml.ComputeSignature()

        ' Get the XML representation of the signature and save it to an XmlElement object
        Dim xmlDigitalSignature As XmlElement = signedXml.GetXml()

        ' Append the element to the XML document
        Doc.DocumentElement.AppendChild(Doc.ImportNode(xmlDigitalSignature, True))

    End Sub

    ' Verify an xml document with a public key
    Private Function VerifyWithPublic(ByVal Doc As XmlDocument, ByVal strPublicKey As String) As [Boolean]

        ' Get key
        Dim key As New RSACryptoServiceProvider()
        key.FromXmlString(strPublicKey)

        ' Create a new SignedXml object and pass it the XML document class
        Dim signedXml As New SignedXml(Doc)

        ' Find the Signature node and create a new XmlNodeList object
        Dim nodeList As XmlNodeList = Doc.GetElementsByTagName("Signature")

        ' Throw an exception if no signature was found
        If nodeList.Count <> 1 Then Return False

        ' Load the signature node
        signedXml.LoadXml(CType(nodeList(0), XmlElement))

        ' Check the signature and return the result
        Return signedXml.CheckSignature(key)

    End Function

End Class
