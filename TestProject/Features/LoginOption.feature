Feature: LoginOption
	User should have possibility to log into the application using valid credentials

Scenario: Login option
	Given main page is opened
	When click at the login link
		And type username and password
		| username              | password |
		| a.yuzhniy86@gmail.com | gJ4Lr+SX |
	Then login has been successful
