using SDETSelenium.Init;
using SDETSelenium.Validaciones;

namespace SDETSelenium.Actions
{
    public class LoginActions : BrowserOps
    {
        BrowserOps browser;

        private IWebElement FaceLogo => browser.getDriver.FindElement(By.XPath("//*[@id='content']/div/div/div/div[1]/div/img"));
        private IWebElement ASD => browser.getDriver.FindElement(By.XPath("//*[@id='content']/div/div/div/div[1]/div/img"));
        private IWebElement sad => browser.getDriver.FindElement(By.XPath("//*[@id='content']/div/div/div/div[1]/div/img"));
        private IWebElement dasda => browser.getDriver.FindElement(By.XPath("//*[@id='content']/div/div/div/div[1]/div/img"));
        private IWebElement FaceLogasdao => browser.getDriver.FindElement(By.XPath("//*[@id='content']/div/div/div/div[1]/div/img"));
        private IWebElement adsad => browser.getDriver.FindElement(By.XPath("//*[@id='content']/div/div/div/div[1]/div/img"));
        private IWebElement asddas => browser.getDriver.FindElement(By.XPath("//*[@id='content']/div/div/div/div[1]/div/img"));
        public LoginActions()
        {
            browser = new BrowserOps();
        }
        internal void InitBrowser()
        {
            browser.Init_Browser();
        }

        internal void CloseBrowser()
        {
            browser.Close();
        }
        
        internal void GoToFacebookLogin(string url)
        {
            browser.GoTo(url);
            System.Threading.Thread.Sleep(10000);
        }

        internal void ValidateFacebookLogo()
        {
            GoToFacebookLogin("https://www.facebook.com");

            for (int i = 0; i>4; i++)
            {
                try
                {
                    if (FaceLogo.Displayed) Console.WriteLine("Is Displayed");
                }
                catch(ElementNotVisibleException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Assert.IsTrue(FaceLogo.Displayed);

        }
    }
}
