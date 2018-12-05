cls
@echo off
xcopy  "%CD%\update\*.*" "%CD%"  /C /E /Q /Y
"Bongah Portable.exe"