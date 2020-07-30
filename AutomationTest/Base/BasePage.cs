using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationTest.Base;
using OpenQA.Selenium.Support.PageObjects;

namespace AutomationTest.Base
{
    public class BasePage : Base
    {
        public BasePage()
        {
            SeleniumExtras.PageObjects.PageFactory.InitElements(DriverContext.Driver, this);
        }
    }
}
