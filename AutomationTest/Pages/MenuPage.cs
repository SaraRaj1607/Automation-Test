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
    public class MenuPage : BasePage
    {
        [FindsBy(How = How.PartialLinkText, Using = "Modules")]
        public IWebElement lblModule { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='main-content']/div[2]/div[2]/div[2]/div/ul/li[1]/ul/li[8]/a[1]")]
        public IWebElement ddlmoduleList { get; set; }
     
    }
    public void ClickonModule()
    {
        lblModule.Click();
    }
    public void SelectContractor()
    {
        ddlmoduleList.Click();
        SelectElement moduleList = new SelectElement(ddlmoduleList);
        moduleList.SelectByIndex(8);

    }
}


