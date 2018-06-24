using FluentAssertions;
using TechTalk.SpecFlow;
using TestProject.PageObjects;

namespace TestProject.Steps
{
    [Binding]
    public class MainPageAppearanceSteps
    {
        #region Given
        [Given(@"web browser is opened")]
        public void GivenWebBrowserIsOpened()
        {
            BasePage.driver.Should().NotBeNull("Driver is null");
        }
        #endregion

        #region When
        [When(@"type url: (.*) to the browser")]
        public void WhenTypeUrlToTheBrowser(string url)
        {
            var homePage = MainPage.NavigateTo();

            ScenarioContext.Current.Add("homePage", homePage);
        }
        #endregion

        #region Then
        [Then(@"user is on the main page")]
        public void ThenUserIsOnTheMainPage()
        {
            var homePage = ScenarioContext.Current.Get<MainPage>("homePage");

            homePage.GetTitle().Should().BeEquivalentTo("Интернет-магазин Скай — купить смартфон, мобильный телефон в Одессе, c доставкой по Украине");

        }
        #endregion
    }
}
