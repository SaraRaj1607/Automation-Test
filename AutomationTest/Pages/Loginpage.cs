using AutomationTest.Base;
using AutomationTest.Pages;
using NUnit.Framework;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.PageObjects;
using AutomationTest.Extenstions;

namespace AutomationTest.Pages
{
    public class LoginPage : BasePage
    {
        [FindsBy(How = How.Id, Using = "username")]
        public IWebElement fldUsername { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement fldpwd { get; set; }
        [FindsBy(How = How.ClassName, Using = "btn btn-primary")]
        public IWebElement btnLogin { get; set; }
        public void NavigateToSite()
        {

            DriverContext.Browser.GoToUrl("https://stirling.she-development.net/automation");
        }
        public void ProvideCredential(string UserName, string Password)
        {
            fldUsername.SendKeys(UserName);
            DriverContext.Driver.WaitForElementToLoad(By.Id("password"), 60);
            fldUsername.SendKeys(Password);

        }

        public void ClickOnLogin()
        {
            DriverContext.Driver.WaitForElementToClickable(By.ClassName("btn btn-primary"), 60);
            btnLogin.Click();

        }
    }
}
