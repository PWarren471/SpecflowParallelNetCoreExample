Feature: UserForm
	Feature which holds all the user details entry

@user
Scenario: User Details form entry verification
	Given I navigate to application
	And I enter username admin and password admin
	And I click login
	And I start entering user form details with initial k first name Karthik and middle name k
	And I click submit button
