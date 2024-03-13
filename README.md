This repo contains demo project for playwright with C#

go to the command 

### create a directory for the project using
		mkdir directoryName

### create new donet project in nunit framework using following command
		dotnet new nunit -n PlayWrightDemo

### initialize git by using
		git init

### install playwright package
		dotnet add package Microsoft.Playwright.NUnit

### Build the project so the playwright.ps1 is available inside the bin directory:
		dotnet build

### Install required browsers by replacing netX with the actual output folder name, e.g. net8.0:
		pwsh bin/Debug/netX/playwright.ps1 install