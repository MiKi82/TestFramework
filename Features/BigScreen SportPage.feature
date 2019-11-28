Feature: BigScreen SportPage
	Verifing that the score at the center 
	of the screen is the same as on the
	previous page.


Scenario Outline: User Verifing that the score at the center of the screen same as on previous page
	Given User on Scottish Premship score results page
	When User press on <team1> or <team2> name
	Then User sees the '<firstTeamscore>,<secondTeamscore>' same as on previous page
Examples: 
| team1       | team2               | firstTeamscore | secondTeamscore |
| Kilmarnock  | Hamilton Academical | 2              | 2               |
| Livingston  | Rangers             | 0              | 2               |
| Ross County | Aberdeen            | 1              | 3               |