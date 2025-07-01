# Money Co. Mobile Application

Welcome to the Money Co. Mobile Application repository! This project is an Android mobile app, designed to help users manage their finances efficiently. The app is built using Xamarin for cross-platform development, leveraging Android’s native APIs and resource management system.

---

## Table of Contents

- [Overview](#overview)
- [Features](#features)
- [Project Structure](#project-structure)
- [Getting Started](#getting-started)
- [Building & Running](#building--running)
- [Resources & Assets](#resources--assets)
- [Dependencies](#dependencies)
- [Contributing](#contributing)
- [License](#license)

---

## Overview

This repository contains the source code for the Money Co. Mobile Application, an Android app developed to manage various financial tasks. The app utilizes Xamarin.Android, making use of Android's resource and asset management features for UI layouts, images, and string dictionaries.

---

## Features

- User-friendly interface for managing finances
- Secure authentication (see `WebAuthenticatorIntermediateActivity`)
- Internationalization support via resource string tables
- Asset management for custom fonts, images, and raw files
- Modular structure for easy navigation and extension

---

## Project Structure

```
Cometa_Estremos_Machine_Problem/
├── Assets/                      # Raw assets for deployment (e.g., fonts, files)
├── Resources/                   # Android resources (drawables, layouts, strings)
│   ├── drawable/                # Images/icons
│   ├── layout/                  # UI layout XML files
│   └── values/                  # Strings and style definitions
├── Properties/                  # Assembly info and configuration
├── obj/                         # Build output (auto-generated)
├── ...                          # Source code, activities, etc.
```

---

## Getting Started

### Prerequisites

- [Visual Studio](https://visualstudio.microsoft.com/) with Xamarin support
- Android SDK
- .NET Framework

### Installation

1. Clone the repository:
    ```sh
    git clone https://github.com/Deokgo/Money_co._Mobile_Application.git
    ```
2. Open the solution in Visual Studio.

---

## Building & Running

1. Restore NuGet packages.
2. Select an Android device or emulator.
3. Build and run the project.

> **Note:** Ensure all required resources and assets are included and their build actions set correctly (see below).

---

## Resources & Assets

- **Resources/**: Contains drawable assets, layouts, and string tables. Use `Build Action: AndroidResource` for these files.
    - Example usage in code:
        ```csharp
        // Accessing a drawable
        var iconId = Resource.Drawable.icon;
        // Accessing a string
        var helloString = Resources.GetString(Resource.String.hello);
        ```
- **Assets/**: For raw files to be deployed with the package (e.g., custom fonts).
    - Access via:
        ```csharp
        var stream = Assets.Open("my_asset.txt");
        ```
    - Example for custom fonts:
        ```csharp
        Typeface tf = Typeface.CreateFromAsset(Context.Assets, "fonts/samplefont.ttf");
        ```

---

## Dependencies

- Xamarin.AndroidX Libraries
- Xamarin.Essentials
- Google Material Components

Dependencies are managed through NuGet and referenced in the `.csproj` and project files.

---

## License

This project is licensed under the terms described in the repository or source files.

---

## Credits

- Developed by Deokgo
- Built with Xamarin

---

*For any questions or issues, please open an issue on GitHub.*
