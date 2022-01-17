# UpgradeWebAPI
Upgraded Web API from .NET Core 3.1 to .NET 6 

1) We must have Visual Studio 2022 to upgrade our project into .NET 6
2) Go to .csproj file of core 3.1 or 5 and just have to change target framework into net6.0 for e.g. <TargetFramework>net6.0</TargetFramework> 
3) Go to manage NuGet packages click on Updates and we can see packages which needs to update according to .NET 6 compatibility.
4) Clean and rebuild the solution this should be error free.
5) We must insure E2E testing after upgrade our project into .NET 6

