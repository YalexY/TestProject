using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace TestProject.PageObjects
{
    public class MainPage : BasePage
    {
        private const string uri = @"https://skay.ua/";
        [FindsBy(How = How.XPath, Using = "//a[@class='login']")]
        private IWebElement loginLink;

        private MainPage()
        {
            driver.Navigate().GoToUrl(uri);
            WaitUntill(By.XPath("//a[@class='login']"));
#pragma warning disable CS0618 // Type or member is obsolete
            PageFactory.InitElements(driver, this);
#pragma warning restore CS0618 // Type or member is obsolete
        }

        public static MainPage instance = null;
        public static MainPage GetInstance()
        {
            if (instance == null)
                return new MainPage();
            return instance;
        }

        public LoginPage GoToLogin()
        {
            loginLink.Click();

            return LoginPage.GetInstance();
        }
    }
}
