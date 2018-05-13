using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.PageObjects
{
    public class LoginPage
    {
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = ".//*[@id='email']")]
        private IWebElement emailField;

        [FindsBy(How = How.XPath, Using = ".//*[@id='passwd']")]
        private IWebElement passwordField;

        [FindsBy(How = How.XPath, Using = ".//*[@id='SubmitLogin']")]
        private IWebElement submitButton;


        private LoginPage(IWebDriver driver)
        {

            this.driver = driver;
#pragma warning disable CS0618 // Type or member is obsolete
            PageFactory.InitElements(driver, this);
#pragma warning restore CS0618 // Type or member is obsolete

        }
        public static LoginPage InitializeLoginPage(IWebDriver driver)
        {
            return new LoginPage(driver);
        }

        public PrivateCabinetPage LoggingIn(string email, string password)
        {
            emailField.Clear();
            emailField.SendKeys(email);
            passwordField.Clear();
            passwordField.SendKeys(password);
            submitButton.Submit();

            return PrivateCabinetPage.Initialize(driver);
        }

        public string GetTitle()
        {
            return driver.Title;
        }

    }
}
