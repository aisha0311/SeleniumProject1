Feature: TimeAndMaterial
	In order to manage time and material 
	As an admin
	I would like to create,edit and delete time and material records

@mytag
Scenario:Create a Material Record with valid inputs
	Given I have logged into Turn Up portal
	And I have navigated to Time and Material page
	Then I should be able to create a material record successfully
