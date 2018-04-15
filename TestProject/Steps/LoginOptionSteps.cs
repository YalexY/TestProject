using System;
using TechTalk.SpecFlow;

namespace TestProject
{
    [Binding]
    public class LoginOptionSteps
    {
        [Given(@"main page is opened")]
        public void GivenMainPageIsOpened()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"click at the login link")]
        public void WhenClickAtTheLoginLink()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"type username and password")]
        public void WhenTypeUsernameAndPassword(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"press submit button")]
        public void WhenPressSubmitButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"login has been successful")]
        public void ThenLoginHasBeenSuccessful()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
