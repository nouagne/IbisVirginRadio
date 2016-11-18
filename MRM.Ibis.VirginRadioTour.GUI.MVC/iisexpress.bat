@echo off
:: iisexpress /?
"%ProgramFiles%\IIS Express\iisexpress" ^
/path:"%CD%" ^
/port:61051 ^
/clr:v4.0
pause
