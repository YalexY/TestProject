using System;
using TechTalk.SpecFlow;

namespace TestProject.Steps
{
    [Binding]
    public class MainPageAppearanceSteps
    {
        [Given(@"web browser is opened")]
        public void GivenWebBrowserIsOpened()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"type url: (.*) to the browser")]
        public void WhenTypeUrlToTheBrowser(string url)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"user is on the main page")]
        public void ThenUserIsOnTheMainPage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
