using Microsoft.Playwright;
using Microsoft.TeamFoundation.WorkItemTracking.Process.WebApi.Models;
using NUnit.Allure.Core;
using PlayWrightDemo.Helper;

namespace PlayWrightDemo;
[AllureNUnit]
public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public async Task Test1()
    {
        //Playwright >>> it will start downaloding things for us for automation.
        using var playwright = await Playwright.CreateAsync();

        //create browser instance
        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
        {
            Headless = false
            
        }) ;


        //create page instance
        var page = await browser.NewPageAsync();

        await page.GotoAsync("https://demoqa.com/");
       
        await page.ClickAsync("text = Book Store Application");
       

        await page.ClickAsync("id=login");

        await page.FillAsync("#userName", "untoldstory");
        await page.FillAsync("#password", "Pikachu@123");
        await page.ClickAsync("id=login");

    }
  
}