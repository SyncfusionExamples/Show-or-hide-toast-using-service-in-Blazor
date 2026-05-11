# Blazor Toast Service Sample

A sample Blazor application demonstrating how to show and hide toast notifications using a centralized service pattern. This project showcases best practices for managing toast notifications across a Blazor application using the [Syncfusion<sup style="font-size:70%">&reg;</sup> Blazor Toast](https://www.syncfusion.com/blazor-components/blazor-toast) component.

## Overview

This repository demonstrates how to decouple toast notification logic from individual components by using a dedicated `ToastService`. Rather than scattering notification code throughout your application, this pattern provides a clean, reusable approach to displaying notifications from any component or service in your Blazor application.

**Key Benefits:**

- Centralized notification management
- Service-based architecture for scalability
- Single responsibility principle
- Easy to test and maintain
- Consistent notification behavior across the app

## Features

- Animated notification pop-up that is small and nonblocking.
- Fully customizable notification with timing and a progress bar.

## Prerequisites

- [.NET SDK 9.0](https://dotnet.microsoft.com/download/dotnet/9.0) or later
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or later
- [Visual Studio Code](https://code.visualstudio.com/)

## Getting Started

### Clone the repository

```bash
git clone https://github.com/SyncfusionExamples/Show-or-hide-toast-using-service-in-Blazor.git
cd Show-or-hide-toast-using-service-in-Blazor
```

### Run with Visual Studio

1. Open the solution file using Visual Studio 2022 or later.
2. Restore the NuGet packages by rebuilding the solution.
3. Build the project to ensure there are no compilation errors.
4. Run the project.

### Run with .NET CLI

```bash
# Restore dependencies
dotnet restore

# Run the project
dotnet run
```

## References

- [UG Documentation](https://blazor.syncfusion.com/documentation/toast/config#show-or-hide-toast-using-service)
