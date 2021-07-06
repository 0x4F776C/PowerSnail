# PowerSnail
PowerShell alternative/restriction bypass

## What's the purpose?
Allow the usage of PowerShell scripts/commands/cmdlets even if it's in the application blacklist

### How to use?
1. Download PowerSnail.exe
2. Run PowerSnail.exe
3. Type in the commands/cmdlets you want to run

### What if I want to run a script? How should I do that?
1. Follow step 1-2 in "How to use?"
2. Dot source the script (*.ps1)
3. Do the magic

*Example...*

Scenario: I want to run Invoke-AllChecks (PowerUp.ps1 kit) in the target system. Unfortunately, the system does not allow PowerShell and Command Prompt. After digging through my tools *pouch*, I found PowerSnail! It should be able to help me bypass the restrictions >:D

*Command: . C:\Users\owl\Desktop\Exploit_Testing\PowerUp.ps1; Invoke-AllChecks*

*Output should look like this...*

![Example Image](https://github.com/0x4F776C/PowerSnail/blob/main/example.PNG)

*Feel free to use it for any engagement or exercises*
