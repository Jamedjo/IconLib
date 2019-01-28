:: Color 0C
@echo For a newer version change the Program ID and Version Infos in the wxs file.
@echo ---------------------------------------------------------------------------
:: Color 07
@echo off
:: @set INPUT=
:: @set /P INPUT=Type Version (e.g. V1.2): %=%
echo on
if not defined ProgramFiles(x86) goto x86
rem 64Bit Systems
  Set X86ProgramFiles=%ProgramFiles(x86)%
  goto x86End

:x86
rem 32Bit Systems
  Set X86ProgramFiles=%ProgramFiles%
:x86End

Set AppName=IconLib.Net4
Set Wix3xPath=%X86ProgramFiles%\WiX Toolset v3.11\bin
"%Wix3xPath%\candle.exe" -nologo %AppName%.wxs -out %AppName%.wixobj
"%Wix3xPath%\light.exe" -nologo %AppName%.wixobj -out %AppName%.msi -ext WixUtilExtension -ext WixUIExtension  -ext WixNetFxExtension
pause
