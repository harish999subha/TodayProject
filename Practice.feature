Feature: SpecFlowFeature1

@mytag
Scenario: AutomationPractice
	Given I go to the default Automation Practice URL
	  And I search the product for <Product>
	  And I Scrolldown and Add to cart
	 And I Enter EmailAddress and Password
	Then I Validate the Error Msg
Examples: 
| Product |
| Shirts  |