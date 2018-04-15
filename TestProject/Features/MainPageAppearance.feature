Feature: MainPageAppearance
	User should be able to access the main page of web app

Scenario: Main Page Appearance
	Given web browser is opened
	When type url: https://skay.ua/ to the browser
	Then user is on the main page
