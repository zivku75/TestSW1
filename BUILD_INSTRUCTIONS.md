# Build Instructions - System Information WPF Application

## 📋 Prerequisites

Before building, ensure you have:
- **Windows 10 or above**
- **Visual Studio 2019 or later** (Community, Professional, or Enterprise)
- **.NET Framework 4.8 Developer Pack**
- **Administrator access** (may be needed for some configurations)

### Installing .NET Framework 4.8

If not present:
1. Visit: https://dotnet.microsoft.com/download/dotnet-framework/net48
2. Download the **Developer Pack**
3. Install it
4. Restart Visual Studio

## 🏗️ Building the Application

### Method 1: Visual Studio IDE (Recommended)

#### Step 1: Open the Project
1. Launch **Visual Studio**
2. **File → Open → Project/Solution**
3. Navigate to repository folder
4. Select **SystemInfoApp.csproj**
5. Click **Open**

#### Step 2: Build Release Version
1. Select **"Release"** from configuration dropdown (top toolbar)
2. Press **Ctrl + Shift + B** or go to **Build → Build Solution**
3. Check **Output Window** for "Build succeeded" message
4. Executable: `bin\Release\SystemInfoApp.exe`

#### Step 3: Run the Application
- **F5** → Run with debugging
- **Ctrl + F5** → Run without debugging
- Or double-click `bin\Release\SystemInfoApp.exe`

### Method 2: Command Line (MSBuild)

```bash
# Navigate to project directory
cd path\to\TestSW1

# Build Release version
msbuild SystemInfoApp.csproj /p:Configuration=Release /p:Platform=AnyCPU

# Run the executable
.\bin\Release\SystemInfoApp.exe
```

## 📁 Output Locations

### Release Build
```
TestSW1/bin/Release/
├── SystemInfoApp.exe          ← Executable (Production)
└── SystemInfoApp.exe.config   ← Configuration
```

### Debug Build
```
TestSW1/bin/Debug/
├── SystemInfoApp.exe          ← Executable (Debug)
├── SystemInfoApp.pdb          ← Debug symbols
└── SystemInfoApp.exe.config   ← Configuration
```

## 🚀 Running the Executable

### From Visual Studio
- **F5** during debug or release session

### From File Explorer
1. Navigate to `bin\Release\` folder
2. Double-click **SystemInfoApp.exe**

### From Command Prompt
```bash
cd bin\Release
SystemInfoApp.exe
```

## 🔄 Clean Build

### In Visual Studio
1. **Build → Clean Solution**
2. **Build → Build Solution**

### Command Line
```bash
# Clean
msbuild SystemInfoApp.csproj /t:Clean

# Rebuild
msbuild SystemInfoApp.csproj /p:Configuration=Release /p:Platform=AnyCPU /t:Build
```

## 📦 Creating Distribution Package

1. Build in Release mode
2. Copy files from `bin\Release\`:
   - `SystemInfoApp.exe`
   - `SystemInfoApp.exe.config`
3. Distribute to target machines
4. Ensure .NET Framework 4.8 is installed on target

## 🔍 Build Verification

### Check Success
- Verify "Build succeeded" in Output Window
- Check: `bin\Release\SystemInfoApp.exe` exists
- File size should be ~40-50 KB (Release) or ~200-300 KB (Debug)

### Test the Executable
Run and verify:
- ✅ Window size: 400×300
- ✅ Time updates every second
- ✅ Day shows correct day
- ✅ Year shows correct year
- ✅ IP Address displays
- ✅ Color dropdown has 6 items
- ✅ Close button works

## ⚠️ Troubleshooting

| Issue | Solution |
|-------|----------|
| ".NET Framework 4.8 not found" | Install Developer Pack from microsoft.com |
| "Build failed" | Delete `bin` and `obj` folders; rebuild |
| "Cannot find msbuild" | Use Visual Studio Developer Command Prompt |
| "XAML parsing error" | Check XML syntax in `.xaml` files |

## 📊 Build Configuration Comparison

| Configuration | Size | Performance | Use Case |
|---------------|------|-------------|----------|
| **Debug** | ~200-300 KB | Slower | Development |
| **Release** | ~40-50 KB | Faster | Distribution |

## ✅ Pre-Deployment Checklist

- [ ] Built in Release mode
- [ ] Tested on Windows 10+
- [ ] All displays work correctly
- [ ] .NET Framework 4.8 available on target systems
- [ ] Executable copied to correct location

## 🔗 Quick Links

- **Visual Studio**: https://visualstudio.microsoft.com/downloads/
- **.NET Framework 4.8**: https://dotnet.microsoft.com/download/dotnet-framework/net48
- **WPF Docs**: https://docs.microsoft.com/en-us/dotnet/desktop/wpf/

---

**Version:** 1.0.0 | **Last Updated:** 2026-06-10 | **Target:** .NET Framework 4.8