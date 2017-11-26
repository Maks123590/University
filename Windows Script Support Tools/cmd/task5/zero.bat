:: ############################################
:: # Name: zero.bat
:: # Task: cmd 5
:: # Author: Batunin Maxim
:: # Group: 302
:: ############################################

@echo off

cd %1

for /f "tokens=*" %%a in ('Dir /b /s /a') do (

    if %%~za==0 (
        del %%~nxa
        echo %%~nxa removed
    )
)

if not -%1==- cd ../
pause