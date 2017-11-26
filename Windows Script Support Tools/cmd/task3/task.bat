:: ############################################
:: # Name: task.bat
:: # Task: cmd 3
:: # Author: Batunin Maxim
:: # Group: 302
:: ############################################

@echo off
Setlocal Enabledelayedexpansion

echo comp name: %COMPUTERNAME%^<br/^> > resuslt.html

set /a varCount = 0

for /F "delims==" %%v in ('set') do (
	set /a varCount = !varCount! + 1
)

echo count variables: %varCount%^<br/^>  >>resuslt.html
echo ----------------------------------- >>resuslt.html

set /a varCount = 0

echo ^<ol^> >>resuslt.html

for /F "delims==" %%v in ('set') do (
	set /a varCount = !varCount! + 1
	
	echo ^<li^>%%v^</li^> >>resuslt.html
) 

echo ^</ol^> >>resuslt.html

pause
