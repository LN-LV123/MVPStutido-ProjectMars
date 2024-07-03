Feature: Language

As a Tester I would like to add, edit and delete Languages successfully so users can have their languages 
showing successfull in the portal.

@Positive
Scenario: Add Language and set level
	Given I logged into the portal successfull
	When I navigate to Profile page
	When I add the Language in the Language section
	Then The languange shoould be added successfully	
	

@Extended-Positive
Scenario: Edit Languages and change levels
	Given I logged into the portal successfull
	When I navigate to Profile page
	When I edit Language and levles in the Language section
	Then The languanges shoould be edited successfully

@Negative
Scenario: Add Language more than four
	Given I logged into the portal successfull
	When I navigate to Profile page	
	When I add more than four Languages in the Language section
	Then Languanges shoould be added successfully but not more than four


@Positive
Scenario: Delete Languages
	Given I logged into the portal successfull
	When I navigate to Profile page
	When I delete the Language in the Language section
	Then The languange shoould be deleted successfully


	
