@echo off

color a
title PRO LICENSE

color a

cls

set /p tmp= [Please wait] .< NUL
timeout 2 > nul
set /p tmp= .< NUL
timeout 2 > nul
set /p tmp= .< NUL
timeout 2 > nul
set /p tmp= .< NUL
timeout 1 > nul
set /p tmp= .< NUL
timeout 2 > nul
set /p tmp= .< NUL
timeout 1 > nul
set /p tmp= .< NUL
timeout 1 > nul
set /p tmp= .< NUL
timeout 1 > nul
set /p tmp= .< NUL
timeout 2 > nul

echo 127.0.0.1 localhost >> %WINDIR%\System32\Drivers\Etc\Hosts
echo 127.0.0.1 reg.wisecleaner.com >> %WINDIR%\System32\Drivers\Etc\Hosts

cls

color f
echo PRESS ANY KEY TO EXIT PROGRAM OR WAIT 5 SECONDES
timeout 5 > nul