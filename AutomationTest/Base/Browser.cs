using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AutomationTest.Base
{
    public class Browser
    {
        private readonly IWebDriver _driver;
            public Browser(IWebDriver driver)
        {
            _driver = driver;
        }
        public void Maximize(string url)
        {
            _driver.Manage().Window.Maximize();
        }


        public void GoToUrl(string url)
        {
            _driver.Url = url;
        }

        public void Close()
        {
            _driver.Close();
        }

        public void Quit()
        {
            _driver.Quit();

        }
        public enum BrowserType
        {
            Chrome,

        }
    }
}
