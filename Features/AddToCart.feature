Feature: bAddToCart

A short summary of the feature


Scenario: Item is added to cart
	Given User is on login page
	When User clicks the products
	And User clicks add to cart button
	And User clicks Cart Icon
	Then Item added to cart should display
