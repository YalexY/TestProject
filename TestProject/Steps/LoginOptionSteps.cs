using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TestProject.PageObjects;
using TestProject.Steps;

namespace TestProject
{
    [Binding]
    public class LoginOptionSteps
    {
        [Given(@"main page is opened")]
        public void GivenMainPageIsOpened()
        {
            var homePage = MainPage.NavigateTo();

            homePage.GetTitle().Should().BeEquivalentTo("Интернет-магазин Скай — купить смартфон, мобильный телефон в Одессе, c доставкой по Украине");

            ScenarioContext.Current.Add("homePage", homePage);
        }
        
        [When(@"click at the login link")]
        public void WhenClickAtTheLoginLink()
        {
            var homePage = ScenarioContext.Current.Get<MainPage>("homePage");

            var loginPage = homePage.GoToLogin();

            ScenarioContext.Current.Add("loginPage", loginPage);
        }
        
        [When(@"type username and password")]
        public void WhenTypeUsernameAndPassword(Table table)
        {
            var loginPage = ScenarioContext.Current.Get<LoginPage>("loginPage");
            dynamic value = table.CreateDynamicInstance();
            var privateCabinetPage = loginPage.LoggingIn((string)value.username,  (string)value.password);
            ScenarioContext.Current.Add("privateCabinetPage", privateCabinetPage);
        }
        
        [Then(@"login has been successful")]
        public void ThenLoginHasBeenSuccessful()
        {
            var privateCabinetPage = ScenarioContext.Current.Get<PrivateCabinetPage>("privateCabinetPage");

            privateCabinetPage.GetTitle().Should().BeEquivalentTo("Мой аккаунт - Интернет-магазин Skay.ua");
        }
    }
}
