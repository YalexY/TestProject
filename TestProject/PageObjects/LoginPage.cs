using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestProject.PageObjects
{
    public class LoginPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = ".//*[@id='email']")]
        private IWebElement emailField;

        [FindsBy(How = How.XPath, Using = ".//*[@id='passwd']")]
        private IWebElement passwordField;

        [FindsBy(How = How.XPath, Using = ".//*[@id='SubmitLogin']")]
        private IWebElement submitButton;


        private LoginPage()
        {
#pragma warning disable CS0618 // Type or member is obsolete
            PageFactory.InitElements(driver, this);
#pragma warning restore CS0618 // Type or member is obsolete

        }

        public static LoginPage instance = null;
        public static LoginPage GetInstance()
        {
            if (instance == null)
                return new LoginPage();
            return instance;
        }

        public PrivateCabinetPage LoggingIn(string email, string password)
        {
            emailField.Clear();
            emailField.SendKeys(email);
            passwordField.Clear();
            passwordField.SendKeys(password);
            submitButton.Click();

            return PrivateCabinetPage.Initialize();
        }
    }
}
