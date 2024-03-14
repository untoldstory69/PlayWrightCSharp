using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace PlayWrightDemo;

// inherit pagetest from micorsoft, so we don't neet to create playwrigh, browser and page instance
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
     

        await Page.ClickAsync("text = Book Store Application");       

        await Page.ClickAsync("id=login");

        await Page.FillAsync("#userName", "untoldstory");
        await Page.FillAsync("#password", "Pikachu@123");
        await Page.ClickAsync("id=login");

        await Expect(Page.Locator("#userName-value")).ToHaveTextAsync("untoldstory");
        await Page.ScreenshotAsync(new PageScreenshotOptions
        {
            Path = "demoqa.jpg"
        });

    }
}