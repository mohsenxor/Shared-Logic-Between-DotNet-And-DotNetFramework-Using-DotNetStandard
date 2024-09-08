# Shared-Logic-Between-DotNet-And-DotNetFramework-Using-DotNetStandard
This project demonstrates how to use .NET Standard to share logic between .NET and .NET Framework.
It implements an application error logger that can log information, warnings, and errors to multiple targets, such as files and the console.

### Prerequisites
•  .NET Standard 2.0
•  .NET Framework 4.8.1
•  .NET 8


### Using .NET Standard in .NET Framework and .NET Projects
#### .NET Framework
To use .NET Standard libraries in a .NET Framework project, ensure your project targets .NET Framework 4.6.1 or higher. This is because .NET Framework 4.6.1 and later versions provide compatibility with .NET Standard 2.0.

#### .NET Core and .NET 5+
.NET Core and .NET 5+ are designed to be compatible with .NET Standard. You can reference .NET Standard libraries directly in these projects. For new projects, it's recommended to use .NET 5 or later, as .NET 5 unifies the .NET platform and replaces .NET Standard for most scenarios.
