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

### Generate HTML Report
		The report can be generated by using allure report. The details of the report can be found in https://allurereport.org/docs/ 

			Install Java Development Kit (JDK)

			Extract Allure ZIP File
				>>> Once the download is complete, extract the contents of the Allure ZIP file to a directory of your choice on your computer. For example, you can create a folder named
				allure in your C:\ drive and extract the contents there.

			Add Allure to System Path (Optional): To make Allure globally accessible from the command line, you can add the Allure bin directory to your system's PATH environment variable:
				Right-click on This PC or My Computer, and select Properties.
				Click on Advanced system settings.
				Click on Environment Variables.
				Under System variables, find the Path variable and select Edit.
				Click New and add the path to the bin directory inside the extracted Allure folder (e.g., C:\allure\bin).
				Click OK to save the changes.

			Verify Allure Installation: Open a new Command Prompt window and run the following command to verify that Allure is installed correctly:
				allure --version

			Add Allure.NUnit package using package manager console

			Add the [AllureNUnit] attribute to all test classes in the project

			Run test from the command:
				dotnet test
					>This will save necessary data into allure-results or other directory, according to the allure.directory setting. If the directory already exists, the new files will be added to the existing ones, so that a future report will be based on them all.
			
			Enter following command in the command prompt, go to the directory PlayWrightDemo\bin\Debug\net8.0
					allure generate --clean
						>>> allure generate processes the test results and saves an HTML report into the allure-report directory
						>>> NOTE: generate report from the bin/debug/netX folder otherwise it will generate report but with error
			
			Open the result by directly opening the html file from allure-report folder or using the command line
				allure open PlayWrightC#\PlayWrightDemo\bin\Debug\net8.0\allure-report
				

			allure serve
				>>> creates the same report as allure generate but puts it into a temporary directory and starts a local web server configured to show this directory's contents. The command then automatically opens the main page of the report in a web browser.
					Use this command if you need to view the report  and do not need to save it.

### Screenshot for failed test
	A helper class ScreenShot.cs is added which will capture the screenshot when test fails and add that screenshot to the allure report. Call that function in TearDown.
