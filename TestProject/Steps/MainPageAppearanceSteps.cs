using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using TestProject.PageObjects;

namespace TestProject.Steps
{
    [Binding]
    public class MainPageAppearanceSteps
    {
        private IWebDriver driver = new ChromeDriver(); 

        [Given(@"web browser is opened")]
        public void GivenWebBrowserIsOpened()
        {
            driver.Manage().Window.Maximize();
        }
        
        [When(@"type url: (.*) to the browser")]
        public void WhenTypeUrlToTheBrowser(string url)
        {
            var homePage = MainPage.NavigateTo(driver);

            ScenarioContext.Current.Add("homePage", homePage);
        }
        
        [Then(@"user is on the main page")]
        public void ThenUserIsOnTheMainPage()
        {
            var homePage = ScenarioContext.Current.Get<MainPage>("homePage");

            homePage.GetTitle().Should().BeEquivalentTo("Интернет-магазин Скай — купить смартфон, мобильный телефон в Одессе, c доставкой по Украине");

        }
    }
}
