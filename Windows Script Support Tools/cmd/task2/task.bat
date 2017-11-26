:: ############################################
:: # Name: task.bat
:: # Task: cmd 2
:: # Author: Batunin Maxim
:: # Group: 302
:: ############################################

@echo off

echo file name:%0%

echo file path:%~P0

set /a counter=0


:label

shift

if  -%0%==- goto label2

set /a counter=%counter% + 1

echo param %counter%: %0%

goto label

:label2

pause