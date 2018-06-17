using System;
using System.Configuration;
using Allure.Commons;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using TestProject.PageObjects;

namespace TestProject.Steps
{
    [Binding]
    public sealed class Hooks
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            BasePage.driver = new ChromeDriver(ConfigurationManager.AppSettings["Chrome"]);
            BasePage.driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            BasePage.driver.Quit();
        }
    }
}
