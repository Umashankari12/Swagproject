:: Open Chrome in debugging mode using full path
start "" "C:\Program Files\Google\Chrome\Application\chrome.exe" --remote-debugging-port=9222 --user-data-dir="C:\ChromeDebug"

:: Wait for Chrome to start
timeout /t 10 >nul

:: Run all tests sequentially
call :RunTest "Login"
call :RunTest "AddToCart"
call :RunTest "Checkout"
call :RunTest "Overview"


:: Wait before closing Chrome
timeout /t 10 >nul

:: Close Chrome Debugging instance (Port 9222)
echo Closing Chrome...
taskkill /F /IM chrome.exe >nul 2>&1
taskkill /F /IM chromedriver.exe >nul 2>&1

exit /b

:: Function Definition
:RunTest
echo Running TestCategory=%~1...
start cmd /c "dotnet test --filter \"(TestCategory=%~1)\" && timeout /t 10 >nul && exit"
timeout /t 10 >nul
exit /b

