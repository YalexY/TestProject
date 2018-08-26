Feature: PrivateCabinetOptions

Scenario: Options presence
	Given main page is opened
	When click at the login link
		And type username and password
		| username              | password |
		| a.yuzhniy86@gmail.com | gJ4Lr+SX |
	Then private cabinet options is available

Scenario Outline: Select option applying
	Given main page is opened
		And user is logged in
	When click the <option>
	Then corresponded <page> appears
	Examples: 
	| option            | page                                       |
	| exitButton        | Авторизация - Интернет-магазин Skay.ua     |
	| ordersButton      | История заказов - Интернет-магазин Skay.ua |
	| adressesButton    | Адреса - Интернет-магазин Skay.ua          |
	| informationButton | Идентификация - Интернет-магазин Skay.ua   |
	| cuponButton       | Скидка - Интернет-магазин Skay.ua          |
	| myMailButton      | Интернет-магазин Skay.ua                   |
	| wishListButton    | Интернет-магазин Skay.ua                   |