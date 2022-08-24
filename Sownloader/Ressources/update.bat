@echo off
if %1.==. goto: FEHLER
if %2.==. goto: FEHLER
if not exist %2 goto: FEHLER 

for %%i in (*.*) do if not "%%i"=="Sownloader.zip" if not "%%i"=="sownloader.log" if not "%%i"=="update.bat" del /q "%%i"

setlocal
cd /d %~dp0
Call :UnZipFile %1 %2
exit /b

:UnZipFile <ExtractTo> <newzipfile>
set vbs="%temp%\_.vbs"
if exist %vbs% del /f /q %vbs%
>%vbs%  echo Set fso = CreateObject("Scripting.FileSystemObject")
>>%vbs% echo If NOT fso.FolderExists(%1) Then
>>%vbs% echo fso.CreateFolder(%1)
>>%vbs% echo End If
>>%vbs% echo set objShell = CreateObject("Shell.Application")
>>%vbs% echo set FilesInZip=objShell.NameSpace(%2).items
>>%vbs% echo objShell.NameSpace(%1).CopyHere(FilesInZip)
>>%vbs% echo Set fso = Nothing
>>%vbs% echo Set objShell = Nothing
cscript //nologo %vbs%
if exist %vbs% del /f /q %vbs%

del %2
start %1% Sownloader.exe -createbatch
exit
goto:eof
:FEHLER
echo invalid request
pause

