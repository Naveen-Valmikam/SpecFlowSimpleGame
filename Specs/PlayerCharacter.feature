Feature: PlayerCharacter
	In order to play the game
	As a human player
	I want my character attributes to be correctly represented


	Background: 
		Given I'm a new player

	Scenario Outline: Health Reduction	
	When I take <damage> damage
	Then My health should now be <expectedHealth>

	Examples: 
	| damage | expectedHealth |
	| 0      | 100            |
	| 30     | 70             |
	| 60     | 40             |

	

Scenario: Taking too much damageresults in player death
When I take 100 damage
Then I am dead

Scenario: Elf race characters get additional 20 damage resistance
And I have a damage resistance of 10
And I'm an Elf
When I take 30 damage
Then My health should now be 100

Scenario: Elf race characters get additional 20 damage resistance using data table
And I have the following attributes
| attribute  | value |
| Race       | Elf   |
| Resistance | 10    |
When I take 30 damage
Then My health should now be 100

Scenario: Healers restore all health
Given My character class is set to healer
When I take 30 damage
And Cast a healing spell
Then My health should now be 100


Scenario: Total magical power
Given I have the following magical items
| Item   | Value | Power |
| Ring   | 200   | 100   |
| Amulet | 400   | 200   |
| Ring   | 100   | 400   |
Then My total magical power should be 700
