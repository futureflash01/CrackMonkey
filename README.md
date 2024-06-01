# CrackMonkey (Remastered)

CrackMonkey Remastered (CMR) is a program that cracks and extracts the encrypted password for the 'data.jet' file in BTD Battles.

This program is only intended for modding purposes only, however I do not condone modding in any way! Use at your own risk!
If you result in your BTD Battles account getting banned, I do not take responsibility!


P.S: It's called remastered because I tried making this program a few years ago and I gave up and eventually forgot about it. I finally rekindled my motivation to program again and cooked up this beautiful piece of software (not really).
Also, this program is a successor to 'BTDPassExtractor' which was a program I made that was used by a lot of Redditors in the BTD Modding community!

Source: https://www.reddit.com/r/BloonsTDBattles/comments/ejur02/release_btd_battles_password_extractor_for_modding/

-----------------------------------------------------------------------------------------------------------------------------
## How to Use:
1. Open CrackMonkey Remastered
2. Open BTD Battles (Steam or Windows Store version, it doesn't matter)
3. Wait until the "Ninja Kiwi®" logo appears and click 'Start'
4. Around 5-7 seconds later (on average), your password will be shown on screen and copied to your clipboard

By the way, doesn't matter which app you launch first. The program will detect if BTD Battles is already running or not!

-----------------------------------------------------------------------------------------------------------------------------
## Credits
This program was made possible using the following programs:
* OpenWall's 'John the Ripper': https://www.openwall.com/john/
* glmcdona's 'strings2': https://github.com/glmcdona/strings2/
* Taiizor's 'ReaLTaiizor' WinForms UI Kit: https://github.com/Taiizor/ReaLTaiizor/

-----------------------------------------------------------------------------------------------------------------------------
## READ BEFORE COMPILING:
For some reason, opening this project in Visual Studio and clicking the 'Start' button breaks the program!
It makes it not able to extract the password for whatever reason. I suspect it's the threading/debugging attachment, which might slow the program down enough to where it doesn't have time to correctly read the output from previous commands.

## To Fix the Issue:
Depending on how you set up your Visual Studio keyboard shortcuts, the default one is 'CTRL + SHIFT + B'. This just compiles 
the executable, but doesn't run it. You need to open your project folder and run the executable in the 'bin/Debug' or 'bin/Release' folder. It's annoying having to do that everytime, but that's the only solution
that I can think of at the moment.

-----------------------------------------------------------------------------------------------------------------------------
## Bug Reports:
To report any bugs/features you would like to be added, just email me at: btdbugreports@gmail.com
I will respond to your emails and do my best to implement your suggestions. Maybe I'll even add an easter egg that has your name on it. Who knows? Just ask anyway!
