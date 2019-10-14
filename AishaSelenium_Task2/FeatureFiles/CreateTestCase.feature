Feature: CreateTimeAndMaterial
	In order to open timeand material portal
	Asto login the portal
	I want to be able to login the portal


@Demo
Scenario:Create a T&M Record with valid inputs
	Given I have logged into Turn Up portal
	And I have navigated to Time and Material page
	Then I should be able to create a material record successfully
