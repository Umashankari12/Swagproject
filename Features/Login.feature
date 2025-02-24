Feature:aLogin

A short summary of the feature


Scenario: login with valid credentials
	Given User is on swag login page
	When User enters the Username "<username>" and Password "<password>"
    And User clicks on login button
	Then User is navigated to home page
	
Examples:
 
| username       | password      |
 
| standard_user | secret_sauce |

