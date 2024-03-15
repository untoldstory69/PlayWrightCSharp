using Allure.Net.Commons;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using System.Reflection;
using Microsoft.Playwright.Core;
using System.Configuration;
using Microsoft.TeamFoundation.WorkItemTracking.Process.WebApi.Models;

namespace PlayWrightDemo.Helper
{

    internal class ScreenShot : PageTest
    {
        private readonly IPage _page;
        public ScreenShot(IPage page)
        {
            _page = page;
            
        }
        public async Task ScreenShotOnFailure(string fileName)
        {
            
            var path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            var screenShotName = fileName + ".png";
            if (TestContext.CurrentContext.Result.Outcome.Status.ToString() == "Failed")
            {
                await _page.ScreenshotAsync(new PageScreenshotOptions
                {
                    Path = screenShotName
                });

                AllureApi.AddAttachment("TestScreenShot", "image/png", path + "\\" + screenShotName);
            }
        }
    }
}
