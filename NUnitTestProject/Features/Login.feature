Feature: Login
	Check if Login functionality works

@login
Scenario: Login user as administrator
	Given I navigate to application
	And I enter username admin and password admin
	And I click login
	Then I should see user logged in to the application

@login
Scenario: Inconclusive test
	Then The test is marked as inconclusive
