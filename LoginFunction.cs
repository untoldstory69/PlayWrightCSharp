using Microsoft.Playwright.NUnit;
using PlayWrightDemo.Pages;
using NUnit.Allure.Core;
using PlayWrightDemo.Helper;
using NUnit.Allure.Attributes;


namespace PlayWrightDemo;

[AllureNUnit]
[AllureSuite("Login Function")]
public class LoginFunction : PageTest
{
    [SetUp]
    public async Task Setup()
    {
        
        await Page.GotoAsync(GlobalVariables.baseURL);
    }

    [Test]
    [AllureFeature("Valid and successful Login")]
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
    [Test]
    [AllureFeature("Invalid Login")]
    public async Task InvalidLoginFunc()
    {
        MainPage mainPage = new MainPage(Page);
        await mainPage.ClickBookStoreApplication();
        await mainPage.ClickLogin();

        LoginPage loginPage = new LoginPage(Page);
        await loginPage.Login("untoldstory1", "Pikachu@123");
        await loginPage.VerifyUserIsNotLoggedIn();

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