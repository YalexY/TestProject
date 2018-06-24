using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.PageObjects
{
    public class PrivateCabinetPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//*[@title = 'Log me out']")]
        private IWebElement exitButton;

        [FindsBy(How = How.XPath, Using = "//*[@title = 'Заказы']")]
        private IWebElement ordersButton;

        [FindsBy(How = How.XPath, Using = "//*[@title = 'Адреса']")]
        private IWebElement adressesButton;

        [FindsBy(How = How.XPath, Using = "//*[@title = 'Информация']")]
        private IWebElement informationButton;

        [FindsBy(How = How.XPath, Using = "//*[@title='Купоны']")]
        private IWebElement cuponButton;

        [FindsBy(How = How.XPath, Using = "//*[@title='Мои уведомления']")]
        private IWebElement myMailButton;

        [FindsBy(How = How.XPath, Using = "//*[@title='Мой список ожидания']")]
        private IWebElement wishListButton;

        private PrivateCabinetPage()
        {
            WaitUntill(By.XPath("//*[@title = 'Информация']"));
#pragma warning disable CS0618 // Type or member is obsolete
            PageFactory.InitElements(driver, this);
#pragma warning restore CS0618 // Type or member is obsolete
        }

        public static PrivateCabinetPage Initialize()
        {
            return new PrivateCabinetPage();
        }
    }
}
