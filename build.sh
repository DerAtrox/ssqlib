xbuild /p:Configuration=Release SSQLib.sln
mono packages/xunit.runner.console.2.0.0/tools/xunit.console.exe Artifacts/bin/Test.SSQLib/Test.SSQLib.dll
