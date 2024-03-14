using Microsoft.Playwright;

namespace PlayWrightDemo.Pages
{
    public class MainPage
    {
        // another way of using constructor and locator using lambda function
        private IPage _page;

        public MainPage(IPage page) => _page = page;
        private  ILocator LinkBookStoreApplication => _page.Locator("text = Book Store Application");

        private  ILocator BtnLogin => _page.Locator("id=login");

     
        public async Task ClickBookStoreApplication() => await LinkBookStoreApplication.ClickAsync();
        public async Task ClickLogin () => await BtnLogin.ClickAsync();
    }
}
