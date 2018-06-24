using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.PageObjects
{
    public class BasePage
    {
        public static IWebDriver driver;
        private static readonly double timeOut = 2;

        public string GetTitle()
        {
            return driver.Title;
        }

        public void Click<T>(T obj, string propertyName)
        {
            var field = obj.GetType().GetField(propertyName, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
            if (field == null)
                throw new Exception(String.Format("Class {0} doesn't contains property {1}", obj.GetType(), propertyName));
            var prop = (IWebElement)field.GetValue(obj);
            prop.Click();
        }

        public static void WaitUntill(By criteria)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOut));
            wait.Until(driv => driv.FindElement(criteria));
        }
    }
}
