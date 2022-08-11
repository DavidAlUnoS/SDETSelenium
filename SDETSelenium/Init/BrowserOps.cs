using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SDETSelenium.Init
{
    public class BrowserOps
    {
        IWebDriver driver;
        public void Init_Browser()
        {
            driver = new ChromeDriver("C:\\Users\\Fecker\\source\\repos\\SDETSelenium\\SDETSelenium\\Drivers");
            driver.Manage().Window.Maximize();
        }

        public string Title { get { return driver.Title; }
        }

        public void GoTo(string url)
        {
            driver.Url = url;
        }

        public void Close()
        {
            driver.Quit();
        }

        public IWebDriver getDriver { get { return driver; }}

    }
}
