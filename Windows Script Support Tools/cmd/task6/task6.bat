:: ############################################
:: # Name: task.bat
:: # Task: cmd 6
:: # Author: Batunin Maxim
:: # Group: 302
:: ############################################

@echo off

Setlocal Enabledelayedexpansion

set str=%1

set /a charCount=0

:begin

set str=%str:~1%

set /a charCount= %charCount% + 1

if -%str%==- goto end 

goto begin

:end

echo %charCount%