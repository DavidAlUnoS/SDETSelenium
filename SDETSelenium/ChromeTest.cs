
using NUnit.Framework;
using OpenQA.Selenium;
using SDETSelenium.Init;

namespace SDETSelenium
{
    public class ChromeTests : BrowserOps
    {
        [SetUp]
        public void Setup()
        {
            browser.Init_Browser();
        }

        [Test]
        public void Test1()
        {
            ValidarLogoDeFacebook();
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}