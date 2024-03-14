using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using PlayWrightDemo.Pages;

namespace PlayWrightDemo;

// inherit pagetest from micorsoft, so we don't neet to create playwrigh, browser and page instance
public class LoginFunction : PageTest
{
    [SetUp]
    public async Task Setup()
    {
        await Page.GotoAsync("https://demoqa.com/");
    }

    [Test]
    public async Task LoginFunc()
    {
        MainPage mainPage = new MainPage(Page);
        await mainPage.ClickBookStoreApplication();
        await mainPage.ClickLogin();

        LoginPage loginPage = new LoginPage(Page);
        await loginPage.Login("untoldstory", "Pikachu@123");

        HomePage homePage = new HomePage(Page);

        await homePage.VerifyUserLoggedIn("untoldstory");



    }
}