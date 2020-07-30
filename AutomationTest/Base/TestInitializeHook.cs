using System;
using System.Drawing;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Tracing;


namespace AutomationTest.Base
{
    [Binding]
    public class TestInitializeHook : Base
    {
        public static void OpenBrowser(string browser)
        {
            foreach (BrowserType browserType in Enum.GetValues(typeof(BrowserType)))
            {
                if (browser.ToLower().ToString() == browserType.ToString().ToLower())
                {
                    Browser(browserType);
;
                    break;

                }
            }

        }

        public static void Browser (BrowserType browser)
        {
            switch (browser)

            {
                case BrowserType.Chrome:
                    ChromeOptions options = new ChromeOptions();
                    options.AddAdditionalCapability("userAutomationextension", false);
                    options.AddArgument("--start-maximized");
                    options.AddArgument("no-sandbox");
                    DriverContext.Driver = new ChromeDriver(options);
                    DriverContext.Driver.Manage().Cookies.DeleteAllCookies();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
            }

        }
    }
}
