using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Allure.Core;
using PlayWrightDemo.Helper;


namespace PlayWrightDemo;

// inherit pagetest from micorsoft, so we don't neet to create playwrigh, browser and page instance
[AllureNUnit]
public class NunitPlayWright : PageTest
{
    [SetUp]
    public async Task Setup()
    {
        await Page.GotoAsync("https://demoqa.com/");
    }

    [Test]
    public async Task Login()
    {
        // Explicit setting time out
        //Page.SetDefaultTimeout(10000);

        await Page.ClickAsync("text = Book Store Application");       

        await Page.ClickAsync("id=login");

        await Page.FillAsync("#userName", "untoldstory");
        await Page.FillAsync("#password", "Pikachu@123");
        await Page.ClickAsync("id=login");

        // lets make this test fails intentionally to capture the screenshot
        await Expect(Page.Locator("#userName-value")).ToHaveTextAsync("untoldstory1");
    }
    [TearDown]
    public async Task TearDown()
    {
        // take screenshot when test failed
        string className = this.GetType().Name; 
        ScreenShot screenShot = new ScreenShot(Page);
        await screenShot.ScreenShotOnFailure(className);

    }
}