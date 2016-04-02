:START
@echo off
color 0b
:checkPrivileges
NET FILE 1>NUL 2>NUL
if '%errorlevel%' == '0' ( goto gotPrivileges ) else ( goto getPrivileges )
:getPrivileges
if '%1'=='ELEV' (echo ELEV & shift /1 & goto gotPrivileges)
setlocal DisableDelayedExpansion
set "batchPath=%~0"
setlocal EnableDelayedExpansion
ECHO Set UAC = CreateObject^("Shell.Application"^) > "%temp%\OEgetPrivileges.vbs"
ECHO args = "ELEV " >> "%temp%\OEgetPrivileges.vbs"
ECHO For Each strArg in WScript.Arguments >> "%temp%\OEgetPrivileges.vbs"
ECHO args = args ^& strArg ^& " "  >> "%temp%\OEgetPrivileges.vbs"
ECHO Next >> "%temp%\OEgetPrivileges.vbs"
ECHO UAC.ShellExecute "!batchPath!", args, "", "runas", 1 >> "%temp%\OEgetPrivileges.vbs"
"%SystemRoot%\System32\WScript.exe" "%temp%\OEgetPrivileges.vbs" %*
exit /B
:gotPrivileges
if '%1'=='ELEV' shift /1
setlocal & pushd .
cd /d %~dp0
:SET_VARIABLES
title CS:GO - Item Tool by Bluscream - %date% , %time%
goto CHECK_FILE
:CHECK_ENV
IF NOT DEFINED CSGOPATH (
	echo Please enter your full CS:GO Path
	echo Example: C:\Program Files (x86)\Steam\steamapps\common\Counter-Strike Global Offensive
	SET /P CSGOPATH=Path
	SETX CSGOPATH "%CSGOPATH%"
)
:CHECK_FILE
IF EXIST "path.txt" (
    set /p CSGOPATH=<path
) ELSE (
	echo Please enter your full CS:GO Path
	echo Example: C:\Program Files (x86)\Steam\steamapps\common\Counter-Strike Global Offensive
	set /p CSGOPATH=Path:
	@echo %CSGOPATH%> path.txt
)
:MENU_MAIN
cls
ECHO %CSGOPATH%
ECHO < path.txt
ECHO.
ECHO ---------------------
ECHO   CS:GO - Item Tool
ECHO ---------------------
ECHO.
ECHO 1 - Change Knifes
ECHO 2 - Rename Bomb
ECHO 3 - Reset all items
ECHO 4 - EXIT
ECHO.
SET /P M=Type 1, 2, 3, or 4 then press ENTER:
IF %M%==1 GOTO MENU_KNIFE
IF %M%==2 GOTO RENAME_BOMB
IF %M%==3 GOTO ITEMS_RESET
IF %M%==4 GOTO EXIT
:MENU_KNIFE
cls
ECHO.
ECHO -----------------------------
ECHO   CS:GO - Item Tool - Knifes
ECHO -----------------------------
ECHO.
ECHO 1 - Change Default CT Knife
ECHO 2 - Change Default T Knife
ECHO 3 - Reset Default CT Knife
ECHO 4 - Reset Default T Knife
ECHO 5 - EXIT
ECHO.
SET /P M=Type 1, 2, 3, or 4 then press ENTER:
IF %M%==1 GOTO CHANGE_KNIFE_CT
IF %M%==2 GOTO CHANGE_KNIFE_T
IF %M%==3 GOTO RESET_KNIFE_CT
IF %M%==4 GOTO RESET_KNIFE_T
IF %M%==5 GOTO EXIT
:CHANGE_KNIFE_CT
:CHANGE_KNIFE_T
:RESET_KNIFE_CT
:RESET_KNIFE_T
:RENAME_BOMB
:ITEMS_RESET
:PAUSE
pause
:EXIT
exit
:REBOOT
shutdown /r /t 0