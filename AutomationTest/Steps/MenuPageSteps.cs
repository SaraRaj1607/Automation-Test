using AutomationTest.Pages;
using AutomationTest.Base;
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
        public class MenuPageSteps :BasePage

     {
        [When(@"Navigate to Construction Phase Plan page")]
        public void WhenNavigateToConstructionPhasePlanPage()
        {

            CurrentPage = GetInstance<MenuPage>();
            CurrentPage.As<MenuPage>().ClickonModule();
            CurrentPage.As<MenuPage>().SelectContractor();
            CurrentPage.As<MenuPage>().ClickonCPHNewrecord();
        }

        }

    }

