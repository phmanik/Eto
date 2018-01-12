@echo off

WHERE msbuild > nul
IF %ERRORLEVEL% NEQ 0 ECHO msbuild not found.  Run in the Developer Command Prompt for VS 2017

set BUILD_DIR=%~dp0\build
msbuild -t:Package -p:BuildVersion=%1 "%BUILD_DIR%\Build.proj"

pause