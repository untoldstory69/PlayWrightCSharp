using Microsoft.Playwright.NUnit;
using PlayWrightDemo.Pages;
using NUnit.Allure.Core;


namespace PlayWrightDemo;

[AllureNUnit]
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