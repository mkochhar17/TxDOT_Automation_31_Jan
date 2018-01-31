Feature: LoginFeature
	Check if the Login functionality is working
	as expected with different permutations and 
	combinations of data

@positive @smoke
Scenario: Check  Login with correct username and password
	Given I have navigated to the application
	And I see the application opened
	Then I enter the Username and Password
	| UserName      | Password |
	| administrator | aurigo   |
	And  I click Login button