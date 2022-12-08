:: Version 1.2.0
@echo off
if %1.==. goto: FEHLER
if %2.==. goto: FEHLER
if not exist %2 goto: FEHLER 

taskkill /f /im Sownloader.exe
timeout /t 2

:: Delete old Sownloader files, do not delete with loop because user could have other files in same directory
del /s /q /f %1runtimes\*.*
del /s /q /f %1DarkControls.dll
del /s /q /f %1DarkControls.pdb
del /s /q /f %1ffmpeg.exe
del /s /q /f %1Microsoft.Extensions.Configuration.Abstractions.dll
del /s /q /f %1Microsoft.Extensions.Configuration.Binder.dll
del /s /q /f %1Microsoft.Extensions.Configuration.CommandLine.dll
del /s /q /f %1Microsoft.Extensions.Configuration.dll
del /s /q /f %1Microsoft.Extensions.Configuration.EnvironmentVariables.dll
del /s /q /f %1Microsoft.Extensions.Configuration.FileExtensions.dll
del /s /q /f %1Microsoft.Extensions.Configuration.Json.dll
del /s /q /f %1Microsoft.Extensions.Configuration.UserSecrets.dll
del /s /q /f %1Microsoft.Extensions.DependencyInjection.Abstractions.dll
del /s /q /f %1Microsoft.Extensions.DependencyInjection.dll
del /s /q /f %1Microsoft.Extensions.DependencyModel.dll
del /s /q /f %1Microsoft.Extensions.FileProviders.Abstractions.dll
del /s /q /f %1Microsoft.Extensions.FileProviders.Physical.dll
del /s /q /f %1Microsoft.Extensions.FileSystemGlobbing.dll
del /s /q /f %1Microsoft.Extensions.Hosting.Abstractions.dll
del /s /q /f %1Microsoft.Extensions.Logging.Configuration.dll
del /s /q /f %1Microsoft.Extensions.Logging.Console.dll
del /s /q /f %1Microsoft.Extensions.Logging.Debug.dll
del /s /q /f %1Microsoft.Extensions.Logging.dll
del /s /q /f %1Microsoft.Extensions.Logging.EventLog.dll
del /s /q /f %1Microsoft.Extensions.Logging.EventSource.dll
del /s /q /f %1Microsoft.Extensions.Options.ConfigurationExtensions.dll
del /s /q /f %1Microsoft.Extensions.Options.dll
del /s /q /f %1Microsoft.Extensions.Primitives.dll
del /s /q /f %1Microsoft.Web.WebView2.Core.dll
del /s /q /f %1Microsoft.Web.WebView2.WinForms.dll
del /s /q /f %1Microsoft.Web.WebView2.Wpf.dll
del /s /q /f %1Microsoft.WindowsAPICodePack.dll
del /s /q /f %1Microsoft.WindowsAPICodePack.ExtendedLinguisticServices.dll
del /s /q /f %1Microsoft.WindowsAPICodePack.Sensors.dll
del /s /q /f %1Microsoft.WindowsAPICodePack.Shell.dll
del /s /q /f %1Microsoft.WindowsAPICodePack.ShellExtensions.dll
del /s /q /f %1Serilog.dll
del /s /q /f %1Serilog.Extensions.Hosting.dll
del /s /q /f %1Serilog.Extensions.Logging.dll
del /s /q /f %1Serilog.Settings.Configuration.dll
del /s /q /f %1Serilog.Sinks.Console.dll
del /s /q /f %1Serilog.Sinks.File.dll
del /s /q /f %1Sownloader.Core.dll
del /s /q /f %1Sownloader.Core.pdb
del /s /q /f %1Sownloader.deps.json
del /s /q /f %1Sownloader.dll
del /s /q /f %1Sownloader.exe
del /s /q /f %1Sownloader.pdb
del /s /q /f %1Sownloader.runtimeconfig.json
del /s /q /f %1System.Diagnostics.EventLog.Messages.dll
del /s /q /f %1taglib-sharp.dll
del /s /q /f %1WebView2Loader.dll

::for %%i in (*.*) do if not "%%i"=="Sownloader.zip" if not "%%i"=="sownloader.log" if not "%%i"=="update.bat" if not "%%i"=="config.ini" del /q "%%i"

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
pause

