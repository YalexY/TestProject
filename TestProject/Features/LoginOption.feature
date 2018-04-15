Feature: LoginOption
	User should have possibility to log into the application using valid credentials

Scenario: Add two numbers
	Given main page is opened
	When click at the login link
		And type username and password
		| username           | password |
		| alextest@gmail.com | Qwer!234 |
		And press submit button
	Then login has been successful
