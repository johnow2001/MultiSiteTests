Feature:  Buy stuff on popular page

@mytag
Scenario: Buy faded short sleeve t-shirt on popular tab
	Given I navigate to the page "http://automationpractice.com/index.php"
	When I slect the "POPULAR" option
	And I select "Faded Short Sleeve T-shirts" product
	And I select Add to cart
	And I select Proceed to checkout
	Then I can see the items in the shopping cart summary
		| Description                 | Available | Unit Price |
		| Faded Short Sleeve T-shirts | In stock  | $16.51     |

Scenario: Buy printed shiffon dress on best sellers tab
	Given I navigate to the page "http://automationpractice.com/index.php"
	When I slect the "BEST SELLERS" option
	And I select "Blouse" product
	And I select Add to cart
	And I select Proceed to checkout
	Then I can see the items in the shopping cart summary
		| Description           | Available | Unit Price |
		| Printed Chiffon Dress | In stock  | $16.40     |

Scenario: Buy womens t-shirt
	Given I navigate to the page "http://automationpractice.com/index.php"
	When I slect the "WOMEN" and "T-shirts" tab option
	And I select "Faded Short Sleeve T-shirts" product
	And I select Add to cart
	And I select Proceed to checkout
	Then I can see the items in the shopping cart summary
		| Description                 | Available | Unit Price |
		| Faded Short Sleeve T-shirts | In stock  | $16.51     |