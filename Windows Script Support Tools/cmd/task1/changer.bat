:: ############################################
:: # Name: changer.bat
:: # Task: cmd 1
:: # Author: Batunin Maxim
:: # Group: 302
:: ############################################

@echo off
Setlocal Enabledelayedexpansion Enableextensions

set filename=%1%
set From=%2%
set Into=%3%

echo Change letter a to b in file %filename%. 
echo before:
echo.--------------------------

type %filename%
 
for /f %%A in (%filename%) do (
  set St=%%A
  set St=!ST:%From%=%Into%!
  echo !St!>>temp.txt
)

1>nul move temp.txt %filename%

echo.--------------------------
echo.after:
echo.--------------------------
type %filename%
echo.--------------------------

pause