chdir "c:\sgs projects\progrid\download"

copy /y "C:\SGS Projects\ProGrid\Progrid Tester\bin\release\ProGridComponent.dll"
copy /y "C:\SGS Projects\ProGrid\Progrid Tester\bin\release\ProGridDemo.exe"
copy /y "C:\SGS Projects\ProGrid\Progrid Tester\bin\release\ProGridDemo.exe.config"

rmdir /s /q "ProGrid Demo Project"
mkdir "ProGrid Demo Project"
chdir "ProGrid Demo Project"
copy "C:\SGS Projects\ProGrid\Progrid Tester\frmMain.*"
copy "C:\SGS Projects\ProGrid\Progrid Tester\ProGrid Demo.vbproj"
copy "C:\SGS Projects\ProGrid\Progrid Tester\app.config"
copy "C:\SGS Projects\ProGrid\Progrid Tester\bin\release\ProGridComponent.dll"

mkdir "Resources"
copy "C:\SGS Projects\ProGrid\Progrid Tester\Resources\ProGridLogo.png" "Resources"

mkdir "My Project"
copy "C:\SGS Projects\ProGrid\Progrid Tester\My Project\*.*" "My Project"

chdir "c:\sgs projects\progrid\download"
del /q ProGrid.zip
zip -q -r ProGrid.zip ProGridDemo.exe "ProGrid Demo Project" ProGridDemo.exe ProGridDemo.exe.config ProGridComponent.dll ReadMe.txt

ftp -v -n -s:upload.txt
