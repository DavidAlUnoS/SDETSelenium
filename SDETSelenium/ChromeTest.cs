
using NUnit.Framework;
using OpenQA.Selenium;
using SDETSelenium.Init;

namespace SDETSelenium
{
    public class ChromeTests : BrowserOps
    {
        BrowserOps browser = new BrowserOps();
        string test_url = "https://www.facebook.com";
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            browser.Init_Browser();
        }

        [Test]
        public void Test1()
        { 
            browser.GoTo(test_url);
            driver = browser.getDriver;

            System.Threading.Thread.Sleep(10000);

            IWebElement logoFacebook = driver.FindElement(By.XPath("//*[@id=\"content\"]/div/div/div/div[1]/div/img"));

            Assert.IsTrue(logoFacebook.Displayed);
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}