# AvsPmod Bridge
Bridging non .NET application to IFME

AvsPmod is AviSynth IDE with full featured including live preview

# Install
Place `AvsPmodBridge.dll` at `extension` folder

Create `AvsPmod` folder

Extract `AvsPmod.exe` and other stuff into `AvsPmod`

Structure will be
```
|   AvsPmodBridge.dll
\---AvsPmod
    |   AvsPmod.exe
	|   ...
    +---help
    |   +---images
    |   |   \---logos
    |   \---stylesheets
    +---lib
    +---macros
    |   +---Example (Resize)
    |   \---Examples
    +---src
    +---tools
    \---translations
```

# API
`public frmMain(string file, string lang)`

`string file` A file

`string lang` ISO 639-2B language code (non usable)

sending `string file` to `AvsPmod.exe %1`

# Application

# Issue
AvsPmod.exe did not open *.avs file, unless program call cmd.exe

`AvsPmodBridge.dll` call `cmd.exe` to start `AvsPmod.exe` instead of

`AvsPmodBridge.dll` call `AvsPmod.exe`

# License
GNU GPL v2