using FluentAssertions;
using System.Reflection;
using TechTalk.SpecFlow;
using TestProject.Extensions;
using TestProject.PageObjects;

namespace TestProject.Steps
{
    [Binding]
    public class PrivateCabinetOptionsSteps
    {
        #region Given
        [Given(@"user is logged in")]
        public void GivenUserIsLoggedIn()
        {
            //Needs to be refactored
            var homePage = ScenarioContext.Current.Get<MainPage>("homePage");
            var loginPage = homePage.GoToLogin();
            var privateCabinetPage = loginPage.LoggingIn("a.yuzhniy86@gmail.com", "gJ4Lr+SX");

            ScenarioContext.Current.Add("privateCabinetPage", privateCabinetPage);
        }
        #endregion

        #region When
        [When(@"click the (.*)")]
        public void WhenClickThe(string propertyName)
        {
            var privateCabinetPage = ScenarioContext.Current.Get<PrivateCabinetPage>("privateCabinetPage");
            privateCabinetPage.Click(privateCabinetPage, propertyName);
        }
        #endregion

        #region Then
        [Then(@"private cabinet options is available")]
        public void ThenPrivateCabinetOptionsIsAvailable()
        {
            var privateCabinet = ScenarioContext.Current.Get<PrivateCabinetPage>("privateCabinetPage");
            Helper.IsAllPropertiesInitialized(privateCabinet);
        }

        [Then(@"corresponded (.*) appears")]
        public void ThenCorrespondedAppears(string pageHeader)
        {
            var privateCabinetPage = ScenarioContext.Current.Get<PrivateCabinetPage>("privateCabinetPage");
            privateCabinetPage.GetTitle().Should().Be(pageHeader);
        }

        #endregion
    }
}
