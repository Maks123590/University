:: ############################################
:: # Name: make_zero.bat
:: # Task: cmd 5
:: # Author: Batunin Maxim
:: # Group: 302
:: ############################################

@echo off

set path=%1


if not -%path%==- (
	mkdir %path%
	cd %path%
)

set /a day=%date:~0,2%

for /L %%i in (1,1,%day%) do (

	@echo off > empty%%i.txt
)

if not -%path%==- cd ../

pause