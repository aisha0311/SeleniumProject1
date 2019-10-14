Feature: EditTimeAndMaterial
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers


@Demo
Scenario: To Edit the values with New inputs
	Given I have logged into turn-up portal
	And I have navigated to TimeandMaterial page
	When I clicked on edit then it should edit the data
	Then i should be able to save the Edited data
