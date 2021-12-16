Feature: Login
	Check if login functionality works

@mytag
Scenario: Login user as administrator
	Given I navigate to application
	And I click the login link
	And I enter username and password
	| UserName | Password |
	| admin    | password    |
	And I click login
	Then I should see user logged in to the application