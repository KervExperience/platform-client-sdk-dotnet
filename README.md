# Kerv Genesys SDK Fork
This is a fork of the Genesys PureCloud Platform .NET SDK, maintained by Kerv. It was forked to improve the code quality, modernize the logging framework, and update the SDK to support .NET 8. The fork includes significant changes to enhance maintainability, usability, and performance.
These changes are not intended to be merged back into the original Genesys repository. They are specific to Kerv's use cases and requirements. The master branch of this fork remains aligned with the upstream Genesys SDK, while the logging-updates branch contains the custom improvements.
These branches will continue to diverge as Kerv implements further enhancements and customizations to meet their needs but the master branch will track upstream changes from Genesys and be used to merge those changes into the logging-updates branch as needed.
The following details the changes from the master branch to the logging-updates branch.

# Branch Comparison Summary: logging-updates vs master

**Repository:** platform-client-sdk-dotnet  
**Branch:** logging-updates  
**Comparison Base:** master  
**Date:** January 2026  

Documentation version PureCloudPlatform.Client.V2 268.0.0

## Executive Summary

The `logging-updates` branch contains significant improvements and modernization efforts for the PureCloud Platform .NET SDK. The changes include a major logging framework refactor, .NET 8 migration, WebSocket implementation updates, and various code quality improvements. This branch represents approximately **23 commits** diverging from the master branch, with changes spanning from May 2025 to January 2026.

---

## Major Changes Overview

### 1. **Logging Framework Modernization** ? Primary Focus

#### Microsoft.Extensions.Logging Integration
- **Commit:** `2ca612f` (September 30, 2025)
- **Impact:** Major architectural change

**What Changed:**
- Replaced custom logging sink architecture with Microsoft.Extensions.Logging framework
- Removed 5 custom sink classes (~427 lines of code):
  - `BatchingLogSink.cs` (126 lines)
  - `ConsoleLogSink.cs` (23 lines)
  - `DbLogSink.cs` (218 lines)
  - `FileLogSink.cs` (42 lines)
  - `ILogSink.cs` (18 lines)
- Refactored `Logger.cs` from 713 lines to simplified implementation
- Added `SetExternalLogger(ILogger logger)` method for pluggable logging
- Updated `LoggerTester` project to demonstrate integration

**Benefits:**
- Standard logging interface familiar to .NET developers
- Better integration with modern .NET applications
- Simplified maintenance and reduced custom code
- Flexibility to use any Microsoft.Extensions.Logging-compatible logger

**Package Dependencies Added:**
- `Microsoft.Extensions.Logging`
- `Microsoft.Extensions.Logging.Console`

---

### 2. **Logger Refactoring & Simplification**

#### Commit History:
- `134001a` (October 1, 2025): "Refactor Logger and Simplify Log Level Handling"
- `1855b5b` (September 19, 2025): "Refactor Logger with Pluggable Sink Architecture"
- `f68d7ad` (October 1, 2025): "Refactor logging and improve code formatting"

**Key Improvements:**
- Simplified log level enumeration:
  - `LogLevel.LTrace` - Full tracing (Method, URL, Request Body, Status, Headers)
  - `LogLevel.LDebug` - Debug info (Method, URL, Request Body, Status, Request Headers)
  - `LogLevel.LError` - Error tracking (includes Response Body)
  - `LogLevel.LNone` - Logging disabled (default)
- Enhanced log format options (JSON and Text)
- Improved security: Authorization headers automatically redacted
- Better control over PII logging (request/response bodies optional)

**Logger Configuration Example:**
```csharp
var logger = new Logger(
    logToConsole: true,
    logFormat: LogFormat.Text,
    logLevel: LogLevel.LTrace,
    logRequestBody: true,
    logResponseBody: true
);

// Bridge to Microsoft.Extensions.Logging
logger.SetExternalLogger(externalLogger);
```

---

### 3. **.NET 8 Migration**

#### Commits:
- `659e6c6` (January 8, 2026): "Replace WebSocketSharp with native WebSocketWrapper (.NET 8)"
- `a9b672c` (May 2, 2025): "Update project to .NET 8.0 and SDK-style format"

**Changes:**
- Migrated projects from legacy .csproj format to SDK-style
- Updated target framework to `net8.0`
- Replaced external WebSocketSharp dependency with native .NET implementation
- Created custom `WebSocketWrapper.cs` for WebSocket functionality
- Updated project structure for Visual Studio 2022 compatibility

**Files Updated:**
- All `.csproj` files migrated to SDK-style format
- Project GUIDs updated for Visual Studio 18+
- Solution file updated for modern tooling

---

### 4. **WebSocket Improvements**

#### Commit: `659e6c6` (January 8, 2026)

**What Changed:**
- Removed dependency on `WebSocketSharp` third-party library
- Implemented `WebSocketWrapper.cs` using native .NET `System.Net.WebSockets.ClientWebSocket`
- Updated `NotificationHandler.cs` to use new wrapper
- Better alignment with .NET platform capabilities

**Benefits:**
- Reduced external dependencies
- Better performance with native implementation
- Improved maintainability
- Enhanced compatibility with .NET 8+ features

---

### 5. **ApiClient Refactoring**

#### Commit: `dc10e04` (October 1, 2025)

**Changes:**
- Improved code readability and structure
- Added `ClientOptions` for better configuration management
- Enhanced error handling
- Better separation of concerns

---

### 6. **Testing & Demonstration**

#### LoggerTester Project
**New Files:**
- `LoggerTester/Program.cs` - Demonstrates logging integration
- `LoggerTester/GenesysApiManager.cs` - Example API wrapper class
- `LoggerTester/LoggerTester.csproj` - Test project configuration

**Purpose:**
- Provides working examples of the new logging framework
- Demonstrates synchronous and asynchronous API calls
- Shows integration with Microsoft.Extensions.Logging
- Serves as reference implementation for SDK users

**Features Demonstrated:**
- External logger configuration
- Console logging with custom formatting
- User secrets management for credentials
- Proper logger lifecycle management

---

### 7. **Build & CI/CD Updates**

#### Commits:
- `78fb49e` (September 11, 2025): "Update NuGet package workflow and project settings"

**Changes:**
- Updated `.github/workflows/publish-nuget-package.yml`
- Improved NuGet package generation process
- Updated assembly versioning
- Enhanced build automation

---

### 8. **Documentation Updates**

**Files Modified:**
- `README.md` - Updated logging documentation
- `build/docs/index.md` - API documentation updates

**New Documentation Sections:**
- Logging configuration examples
- Microsoft.Extensions.Logging integration guide
- Security considerations for logging PII data
- Log level descriptions and use cases

---

## Code Quality Improvements

### Removed:
- Unused using directives (Commit `367ccb2`)
- Legacy custom logging infrastructure
- Obsolete binary files
- Outdated project configurations

### Added:
- `.gitignore` enhancements for Visual Studio artifacts
- Better code organization
- Improved inline documentation
- Modern C# language features (primary constructors, collection expressions)

---

## Breaking Changes

?? **Important for SDK Users:**

1. **Logging Sink Architecture Removed:**
   - Custom sinks (`ConsoleLogSink`, `FileLogSink`, `DbLogSink`) no longer available
   - Migration required to Microsoft.Extensions.Logging

2. **Logger Configuration Changes:**
   - `LogFilePath` property may be deprecated (file logging now through external logger)
   - Sink registration methods removed

3. **WebSocketSharp Dependency Removed:**
   - Users relying on WebSocketSharp behavior may need adjustments

4. **.NET 8 Requirement:**
   - Minimum framework version is now .NET 8.0
   - Legacy framework support dropped

---

## File Changes Statistics

### Total Modified Files: ~22 core files

**Major File Changes:**
1. `build/src/PureCloudPlatform.Client.V2/Client/Logger.cs` - Complete refactor (~329 lines reduced)
2. `build/src/PureCloudPlatform.Client.V2/Client/ApiClient.cs` - Improvements
3. `build/src/PureCloudPlatform.Client.V2/Client/Configuration.cs` - Updates
4. `build/LoggerTester/Program.cs` - New demonstration code
5. `build/src/PureCloudPlatform.Client.V2/Extensions/Notifications/WebSocketWrapper.cs` - New implementation

**Deleted Files:**
- `BatchingLogSink.cs`
- `ConsoleLogSink.cs`
- `DbLogSink.cs`
- `FileLogSink.cs`
- `ILogSink.cs`

**New Files:**
- `LoggerTester/GenesysApiManager.cs`
- `WebSocketWrapper.cs`
- Various Copilot snapshot files

---

## Commit Timeline

```
Jan 19, 2026 - Updated from upstream fork
Jan 08, 2026 - Replace WebSocketSharp with native WebSocketWrapper (.NET 8)
Jan 08, 2026 - Updated from upstream fork
Jan 08, 2026 - Update solution for Visual Studio 18 and fix project GUID
Dec 10, 2025 - Merged latest changes from upstream
Oct 01, 2025 - Refactor logging and improve code formatting
Oct 01, 2025 - Refactor ApiClient for readability and add ClientOptions
Oct 01, 2025 - Refactor Logger and Simplify Log Level Handling
Sep 30, 2025 - Switch to Microsoft.Extensions.Logging framework ?
Sep 30, 2025 - Add /build/.vs to .gitignore
Sep 29, 2025 - Remove unused using directives in Logger.cs
Sep 19, 2025 - Refactor Logger with Pluggable Sink Architecture
Sep 11, 2025 - Update NuGet package workflow and project settings
Sep 11, 2025 - Add new files and classes for API enhancements
Sep 11, 2025 - Update API to version 241.0.0 with new features
Jul 04, 2025 - Remove binary files and update project configurations
Jul 04, 2025 - Updated to latest from upstream
May 05, 2025 - Merge branch 'master' into configuration-changes
May 05, 2025 - Enhance SDK with new models and project updates
May 02, 2025 - Update project to .NET 8.0 and SDK-style format
May 02, 2025 - Update .gitignore for Visual Studio build files
```

---

## Migration Guide for SDK Users

### For Applications Using Custom Sinks:

**Before (Old Approach):**
```csharp
Configuration.Default.Logger.Level = LogLevel.LTrace;
Configuration.Default.Logger.LogFilePath = "/var/log/dotnetsdk.log";
```

**After (New Approach):**
```csharp
// 1. Create Microsoft.Extensions.Logging logger
using var loggerFactory = LoggerFactory.Create(builder =>
{
    builder.AddConsole();
    builder.AddFile("/var/log/dotnetsdk.log"); // Using Serilog or other provider
    builder.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace);
});

var externalLogger = loggerFactory.CreateLogger("GenesysSdk");

// 2. Configure SDK logger
Configuration.Default.Logger.Level = LogLevel.LTrace;
Configuration.Default.Logger.SetExternalLogger(externalLogger);
Configuration.Default.Logger.LogRequestBody = true;
Configuration.Default.Logger.LogResponseBody = true;
```

### For Applications Using WebSocketSharp:

- No code changes required if using SDK-provided notification handlers
- Direct WebSocketSharp usage needs migration to native .NET WebSocket APIs

---

## Testing Recommendations

Before merging to master:

1. ? **Unit Tests:** Verify Logger functionality with external loggers
2. ? **Integration Tests:** Test WebSocket notifications with new wrapper
3. ? **Performance Tests:** Validate logging overhead is acceptable
4. ? **Backward Compatibility:** Document breaking changes clearly
5. ? **Documentation:** Update all examples and guides
6. ? **NuGet Package:** Test package generation and installation

---

## Security Considerations

### Improvements:
- Authorization headers automatically redacted in logs
- PII logging is opt-in (disabled by default for request/response bodies)
- Better control over sensitive data exposure

### Best Practices for Users:
```csharp
// Only enable body logging in development/debugging
logger.LogRequestBody = false;  // Default - no PII in logs
logger.LogResponseBody = false; // Default - no PII in logs
```

---

## Performance Impact

### Positive:
- Reduced code complexity (713 lines ? simplified implementation)
- Native WebSocket implementation should be faster
- Better async/await patterns

### Neutral:
- Microsoft.Extensions.Logging overhead is minimal
- External logger configuration adds slight initialization cost

---

## Dependencies Added

**LoggerTester Project:**
- Microsoft.Extensions.Configuration (9.0.9)
- Microsoft.Extensions.Configuration.UserSecrets (9.0.9)
- Microsoft.Extensions.Logging (9.0.9)
- Microsoft.Extensions.Logging.Console (9.0.9)

**SDK Project:**
- Microsoft.Extensions.Logging (version to be specified)

---

## Recommendations

### For Merging:
1. ? **Thoroughly test** the new logging implementation
2. ? **Update release notes** with breaking changes
3. ? **Increment major version** (breaking changes present)
4. ? **Provide migration guide** for existing users
5. ? **Update all documentation** and samples

### For SDK Users:
1. Review and plan migration from custom sinks
2. Test thoroughly in development environment
3. Update to .NET 8 if not already done
4. Review logging configuration for PII concerns
5. Update CI/CD pipelines for new package dependencies

---

## Conclusion

The `logging-updates` branch represents a significant modernization effort for the PureCloud Platform .NET SDK. The primary focus on integrating Microsoft.Extensions.Logging provides a more maintainable, standard, and flexible logging solution while reducing custom code by ~427 lines. Combined with .NET 8 migration and WebSocket improvements, this branch positions the SDK for better long-term support and developer experience.

**Overall Impact:** ????? High Value
- Major architectural improvements
- Better alignment with .NET ecosystem
- Enhanced developer experience
- Reduced maintenance burden

**Risk Level:** ?? Medium
- Breaking changes require user migration
- Thorough testing recommended before production release
- Clear communication and documentation essential

---

*Document generated: January 2026*  
*Branch: logging-updates*  
*Base: master*  
*Total Commits: 23*
