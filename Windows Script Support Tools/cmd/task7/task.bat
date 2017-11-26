:: ############################################
:: # Name: task.bat
:: # Task: cmd 7
:: # Author: Batunin Maxim
:: # Group: 302
:: ############################################

@echo off

SetLocal EnableDelayedExpansion

set in=%1

for /r %in% %%i in (*) do (
    set ras=%%~xi
    for /f "delims=" %%a in ('dir /a-d /b /s "%in%\*.*"') do (
        set nf=%%a

        if -!ras!==- (
            if not exist "sorted\noextension" md "sorted\noextension"
            if "%%~xi"=="%%~xa" copy "!nf!" "sorted\noextension"
        ) ELSE (
            if not exist "sorted\!ras!" md "sorted\!ras!"
            if "%%~xi"=="%%~xa" copy "!nf!" "sorted\!ras!"
        )
    )
)

pause