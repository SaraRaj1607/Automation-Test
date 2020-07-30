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

namespace AutomationPage.Steps
{
    [Binding]

    public class LoginPageSteps : BasePage
   {
        [Given(@"login to TestSite")]
        public void GivenLoginToTestSite()
        {
        CurrentPage.As<LoginPage>().NavigateToSite();
         }

        [When(@"I provide login credentials (.*) and (.*)")]
        public void WhenIProvideLoginCredentialsAnd(string UserName, string Password)
        {
            CurrentPage = GetInstance<LoginPage>();
            CurrentPage.As<LoginPage>().ProvideCredential(UserName,Password);
        }
        [When(@"I click on Login")]
        public void WhenIClickOnLogin()
        {
            CurrentPage = GetInstance<LoginPage>();
            CurrentPage.As<LoginPage>().ClickOnLogin();
        }



    }
}

