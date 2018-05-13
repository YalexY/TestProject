Feature: LoginOption
	User should have possibility to log into the application using valid credentials

Scenario: Login option
	Given main page is opened
	When click at the login link
		And type username and password
		| username           | password |
		| zuk48494@soioa.com | Qwer!234 |
		And press submit button
	Then login has been successful
