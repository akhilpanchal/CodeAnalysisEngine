:run.bat
:
:runs parser code

"./Executive/bin/debug/Executive.exe" "./TestFiles"
"./Executive/bin/debug/Executive.exe" "./TestFiles" /s
"./Executive/bin/debug/Executive.exe" "./TestFiles" /r
"./Executive/bin/debug/Executive.exe" "./TestFiles" /x
"./Executive/bin/debug/Executive.exe" "./TestFiles" /s /r /x
"./Executive/bin/debug/Executive.exe" "./TestFiles" /s /r
"./Executive/bin/debug/Executive.exe" "./TestFiles" /s /x