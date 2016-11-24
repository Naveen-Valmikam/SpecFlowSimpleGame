Feature: PlayerCharacter
	In order to play the game
	As a human player
	I want my character attributes to be correctly represented


Scenario: Taking no damage when hit doesn't affect health
	Given I'm a new player
	When I take 0 damage
	Then My health should now be 100

Scenario: Starting health is reduced when player takes a hit
Given I'm a new player
When I take 30 damage
Then My health should now be 70

Scenario: Taking too much damageresults in player death
Given I'm a new player
When I take 100 damage
Then I am dead