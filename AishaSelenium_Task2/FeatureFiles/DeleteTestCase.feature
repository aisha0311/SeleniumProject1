Feature: DeleteTestCase
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: To Delete the input Values present in the grid
	Given I have logged into Turn-up portal
	And I have navigated to Time&Material page
	When I click on the delete button on the grid
	Then the input values should be deleted
