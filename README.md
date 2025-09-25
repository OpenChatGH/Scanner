# Scanner
Scanner is a Universal VRChat MelonLoader mod that supports any 2021+ build of VRChat. It's primary goal is to allow modifications to the API for custom servers.
Tested to work with VRChat 2021+.

(PS: This is really bad code lol, it was built to be my scanner but I turned it into a patcher, hence why it's still called Scanner.)
(also... I SHOULD NOT BE ABLE TO PATCH OUT THE ENTIRETY OF NETWORKING HERE SMH)

## Usage
All you do is throw it into your `VRChat/Mods` folder and run it to connect to a VRCat localhost instance (`http://localhost:3000/api/1`).

### Using a custom API URL.
You can use a custom API URL by typing in the following command:
```
VRChat.exe --forceUrl=http://your-url.here/api/1
```

### Using a custom Photon Server.
You can use a custom Photon Server by typing in the following command:
```
VRChat.exe --forcePhotonId=your-long-photon-id-here
```

## Building
You can build the project, not like it'll be any good right now but if you wanna.

### Requirements to build
You must meet the following:
- Visual Studio
- MelonLoader's VSIX Plugin
- dotnet 6.0

### Steps to build
1. Open the project in Visual Studio
2. Select `Release` from the tab at the top instead of `Debug`, keep it to `Any CPU`.
3. Press `Ctrl + B` to build.
4. Grab the DLL from `Scanner/bin/Release` or it may end up in the game's Mods directory already