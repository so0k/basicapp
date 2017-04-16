# Getting Started with .NET Core

This is a version of basicapp with tests using dotnet core 1.1

## How this repository was generated

```
dotnet new sln
dotnet new mvc -n BasicApp
dotnet new xunit -n BasicAppTests
dotnet sln add BasicApp/BasicApp.csproj
dotnet sln add BasicAppTests/BasicAppTests.csproj
dotnet restore
cd BasicAppTests
dotnet add reference ../BasicApp/BasicApp.csproj
dotnet add package FluentAssertions

mkdir Controllers
touch Controllers/HomeControllerTest.cs
dotnet add package Microsoft.AspNetCore.Mvc
```
