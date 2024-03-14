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

### By default NunitPlayWright will run in headless mode. In order to run in headed mode run it from VS package manager console
		$env:HEADED="1"
		dotnet test

### Recording code
		As we have already installed playwright.ps1, now go to the netX folder and run the following command
			 .\playwright.ps1 codegen https://demoqa.com/
				>>> It will open the browser and navigate to the url specificed and record the activities.

### Run specific test from PCM
		 dotnet test --filter "NunitPlayWright.Login"

### Implementatin of Page Object Model
