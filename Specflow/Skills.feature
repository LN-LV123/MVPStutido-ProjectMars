Feature: Skills

As a Tester I would like to add, edit and delete skills successfully so users can have their Skills 
showing successfull in the portal.

@Postive
Scenario: Add Skills and set skill level
	Given I logged into the portal successfull	
	When  I navigate to Skills page 
	When  I add the Skill and Skill level
	Then  The skill and skills level should be added successfull


@Destructive
Scenario: Add Skills with Special Characters and long lengh and set skill level
	Given I logged into the portal successfull
	When  I navigate to Profile page
	When  I navigate to Skills page
	When  I add Special Characters and long leangh skills
	Then  Should not be added successfull

@Extended-Positive
Scenario: Edit Skills and set skill level
	Given I logged into the portal successfull	
	When  I navigate to Skills page 
	When  I edit the skills and skill level
	Then  The skill and skills level should be edited successfull




@Extended-Positive
Scenario: Delete Skills and set skill level
	Given I logged into the portal successfull	
	When  I navigate to Skills page 
	When  I delete the skills
	Then  The skill and skills level should be deleted successfull



@Extended-Positive
Scenario: Add same Skills but different skill level
	Given I logged into the portal successfull	
	When  I navigate to Skills page 
	When  I add same skills
	Then  Same skills should not be add sucessfull




