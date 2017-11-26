:: ############################################
:: # Name: task.bat
:: # Task: cmd 4
:: # Author: Batunin Maxim
:: # Group: 302
:: ############################################

@echo off

set inputStr=%1

set /a zeroCount = 0

for /F "tokens=* delims=0" %%v in ("%inputStr%") do (
	echo %%v > "del_zero.log"
)

echo %date% %time% >> "del_zero.log"