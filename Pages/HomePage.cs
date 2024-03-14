using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Playwright.NUnit;

namespace PlayWrightDemo.Pages
{
    internal class HomePage: PageTest
    {
        private readonly IPage _page;
        private readonly ILocator _username;

        public HomePage(IPage page)
        {
            _page = page;
            _username = _page.Locator("#userName-value");
        }
        public async Task VerifyUserLoggedIn(string username) => await Expect(_username).ToHaveTextAsync(username);
    }
}
