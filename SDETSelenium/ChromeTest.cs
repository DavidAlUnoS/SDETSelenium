
using NUnit.Framework;
using OpenQA.Selenium;
using SDETSelenium.Actions;
using SDETSelenium.Init;

namespace SDETSelenium
{
    public class ChromeTests : LoginActions
    {

        [SetUp]
        public void Setup()
        {
           InitBrowser();
        }

        [Test]
        public void Test1()
        { 
        }


        [Test]
        public void Test2()
        {
            ValidateFacebookLogo();
        }

        [TearDown]
        public void closeBrowser()
        {
            CloseBrowser();
        }
    }
}