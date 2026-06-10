# System Information WPF Application

## 📋 Overview
A lightweight WPF application that displays system information including real-time clock, day, year, local IP address, and a color selector. Built with .NET Framework 4.8 for Windows 10 and above.

## ✨ Features

✅ **Real-time Clock** - Displays current time in HH:mm:ss format (updates every second)
✅ **Day & Year Display** - Shows current day of the week and year
✅ **Local IP Address** - Retrieves and displays the computer's IP address on the network
✅ **Color Selector** - Dropdown list with 6 suggested random colors
✅ **Modern UI** - Clean, professional Windows 10+ compatible interface
✅ **Close Button** - Gracefully exit the application
✅ **Single Window** - Shows single window when executing from desktop

## 🔧 Technical Specifications

| Requirement | Value |
|-------------|-------|
| **Framework** | .NET Framework 4.8 |
| **Technology** | Windows Presentation Foundation (WPF) |
| **Window Height** | 300 pixels |
| **Window Width** | 400 pixels |
| **OS Compatibility** | Windows 10 and above |
| **Build Type** | WinExe (Standalone Executable) |
| **Platform** | AnyCPU (32-bit & 64-bit compatible) |

## 📦 Project Structure

```
TestSW1/
├── SystemInfoApp.csproj              # WPF Project file
├── App.xaml                          # Application definition (UI)
├── App.xaml.cs                       # Application code-behind
├── MainWindow.xaml                   # Main window UI design
├── MainWindow.xaml.cs                # Main window logic & event handlers
├── SystemInfoHelper.cs               # System information utility class
├── App.config                        # Application configuration (.NET 4.8)
├── Properties/
│   ├── AssemblyInfo.cs               # Assembly metadata & version info
│   ├── Resources.resx                # Resource file
│   └── Settings.settings             # Application settings
├── README.md                         # Project documentation
└── BUILD_INSTRUCTIONS.md             # Detailed build & deployment guide
```

## 🚀 Quick Start

### Prerequisites
- Windows 10 or above
- Visual Studio 2019 or later
- .NET Framework 4.8 (usually pre-installed on Windows 10+)

### Build Instructions

1. **Clone or Download the Repository**
   ```bash
   git clone https://github.com/zivku75/TestSW1.git
   cd TestSW1
   ```

2. **Open in Visual Studio**
   - Open Visual Studio
   - File → Open → Project/Solution
   - Select `SystemInfoApp.csproj`

3. **Build the Project**
   - Press `Ctrl + Shift + B` or Build → Build Solution

4. **Run the Application**
   - Press `F5` (with debugging) or `Ctrl + F5` (without debugging)
   - Or navigate to `bin\Release\SystemInfoApp.exe`

### Output Locations

**Debug Build:** `bin\Debug\SystemInfoApp.exe`
**Release Build:** `bin\Release\SystemInfoApp.exe`

## 📋 Code Architecture

### Main Components

#### 1. **App.xaml / App.xaml.cs**
- Application entry point
- Initializes the main window
- Handles application-wide events

#### 2. **MainWindow.xaml**
- UI Design (XAML markup)
- 5 display sections: Time, Day, Year, IP Address, Color Selector
- Close button for application termination
- Professional styling with blue (#0078D4) accent color

#### 3. **MainWindow.xaml.cs**
- **Timer Management**: Updates time every second using `DispatcherTimer`
- **System Info Display**: Populates Time, Day, Year, and IP address
- **Color Dropdown**: Initializes and shuffles 6 colors randomly
- **Event Handlers**: Manages Close button click events

#### 4. **SystemInfoHelper.cs**
- **GetLocalIPAddress()** method:
  - Primary method: Uses Socket to connect to external address
  - Fallback method: Uses DNS hostname resolution
  - Error handling: Returns meaningful error messages

### Key Technologies Used

- **WPF (Windows Presentation Foundation)** - Modern UI framework
- **XAML** - UI markup language
- **C#** - Business logic and event handling
- **System.Net.Sockets** - Network communication for IP retrieval
- **System.Windows.Threading** - Timer for real-time updates

## 🎨 User Interface

The application features:
- **Responsive Layout**: StackPanel-based vertical arrangement
- **Modern Colors**: Professional Windows 10 blue theme
- **Clear Labels**: Easy-to-read information sections
- **Dropdown Control**: Color selector with 6 options
- **Call-to-Action Button**: Large, visible Close button
- **Fixed Window Size**: Non-resizable (400×300) for consistent layout

## 📝 Data Displayed

| Data | Format | Update Frequency |
|------|--------|-----------------|
| **Time** | HH:mm:ss | Every 1 second |
| **Day** | Full day name (e.g., "Monday") | Once on startup |
| **Year** | 4-digit year (e.g., "2026") | Once on startup |
| **IP Address** | IPv4 format (e.g., "192.168.1.100") | Once on startup |
| **Colors** | 6 random colors | Random order on each run |

## 🔄 Application Flow

1. **Application Startup** → Window loads with 400×300 size
2. **Initialization** → System info retrieved, timer started
3. **Timer Tick** → Time display updates every second
4. **Color Selection** → User can select any color from dropdown
5. **Close Action** → User clicks Close button → Timer stops → Application exits

## 🛠️ Build & Deployment

### Building from Command Line
```bash
# Debug build
msbuild SystemInfoApp.csproj /p:Configuration=Debug /p:Platform=AnyCPU

# Release build
msbuild SystemInfoApp.csproj /p:Configuration=Release /p:Platform=AnyCPU
```

### Distribution
1. Build in Release mode
2. Copy `bin\Release\SystemInfoApp.exe` to target machine
3. Ensure .NET Framework 4.8 is installed
4. Run the executable

## ⚙️ System Requirements

**Minimum:**
- Windows 10 (Build 1909+)
- .NET Framework 4.8
- 20 MB disk space

**Recommended:**
- Windows 10/11 (latest)
- Network connection for IP retrieval

## 🐛 Troubleshooting

| Issue | Solution |
|-------|----------|
| **IP Address shows "Error"** | Check network connectivity |
| **.NET Framework not found** | Install from microsoft.com/download/dotnet-framework/net48 |
| **Project won't load** | Delete `bin` and `obj` folders; rebuild |
| **Build fails** | Ensure Visual Studio 2019+ is installed |

## 📚 Additional Resources

- [Microsoft WPF Documentation](https://docs.microsoft.com/en-us/dotnet/desktop/wpf)
- [.NET Framework 4.8](https://dotnet.microsoft.com/download/dotnet-framework/net48)
- [Visual Studio Download](https://visualstudio.microsoft.com/downloads/)

## 📄 License
No specific license. Free to use and modify.

## 👤 Repository
**Created:** 2026-06-10
**URL:** https://github.com/zivku75/TestSW1

---

**Version:** 1.0.0 | **Status:** Production Ready | **Target OS:** Windows 10+