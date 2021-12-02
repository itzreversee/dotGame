# dotGame | C# GUI ( dotManager )
dotGame is a Quick and Easy, Game Manager, Downloader and Installer. Written in Python (CLI) and C# (GUI)  

##### NOTE: THIS ISN'T MEANT FOR CRACKING AND OTHER ILLEGAL STUFF!!!!  

In releases folder, you can find sample [game meta](https://rayriver.itch.io/ld42) 

## Quick Launch
 * Get newest Release
 * Launch it (not as administrator), first launch may take some time, because it needs to download arc.exe
 * Drag and Drop it on app window
 * Click download to retrive game archive **(saved in %appdata%\dotGame\game.arc)**
 * Click Install, and select installation folder ( accessible without elevation )
 * Installer will create shortcut on your desktop, enjoy!
 
## Build
_Note: This was built on **Windows 11**, using **Visual Studio 2022** and **.NET Framework 4.8**
 * Clone repo
 * Open with Visual Studio
 * Install ```Newtonsoft.Json``` from NuGet if needed
 * Build!

## How to create your own installer
 * Archive your game files using FreeArc so that all game files are in the root of archive
 * Upload it somewhere and get direct link.
 * Download template game meta file and fill it out.
 * Create Issue with meta file included 
 
