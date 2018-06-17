using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.PageObjects
{
    public class BasePage
    {
        public static IWebDriver driver;

        public string GetTitle()
        {
            return driver.Title;
        }
    }
}
