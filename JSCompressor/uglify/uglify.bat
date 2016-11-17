@echo off
SET JSFOLDER=%cd%
echo Finding js files...
chdir /d %JSFOLDER%
for /r . %%a in (*.js) do (
    @echo Compressing %%~a ...
    uglifyjs %%~fa  -m -o %%~fa
	if %ERRORLEVEL% NEQ 0 goto FAILURE
)
:SUCCESS
echo Successfully Finished!
goto END

:FAILURE
echo "This function requies nodejs and uglifyjs module. Please make sure you have installed them!"
echo "ERROR STOP: %cnt%"

:END
exit