Feature:Sara_TestAutomationPage
As a user I want to create a new record,delete and validate
		
Background:
	Given login to TestSite


@SmokeTest
Scenario Outline: Login to TestWebsite
When I provide login credentials <UserName> and <Password>
And I click on Login
And Navigate to Construction Phase Plan page


   Examples:
  | UserName | Password    |
  | SaralH   | SaralH1234! |

