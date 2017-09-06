Day3_Namespaces

@if "%ERRORLEVEL%" == "0" goto success

:fail
  echo THIS APPLICATION HAS FAILED
  echo return value =%ERRORLEVEL%
  goto end

:success
  echo This application has succeeded
  echo return value =%ERRORLEVEL%
  goto end

:end
  echo All Done.