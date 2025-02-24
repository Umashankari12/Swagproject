Feature: Checkout

A short summary of the feature


Scenario: Verifying Checkout Page
	Given User is on the checkout page
	When User clicks checkout button
	And User enters "<firstname>", "<lastname>", and "<zipcode>"
	Then Then Clicks on Continue

Examples: 
| firstname | lastname | zipcode |
| uma    | shankari    | 123456 |
