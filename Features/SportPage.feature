Feature: SportPage
	User verifys that 2 specific teams played with a specific score

@mytag
Scenario: User checks a score tow teams of Scottish Premiership
	Given That User on the BBC com web page
	And That User proceed on the BBC Sport page
	When User goes on More 
	When User proceed to Scottish Prem 
	When User goes on “View all Scottish Premiership“
	When User proceed to a Month Result 
	Then User sees a <team1> and <team2> 
	And User sees score '<firstTeamscore>,<secondTeamscore>'

Examples: 
| team1        | team2     | firstTeamscore | secondTeamscore |
| St Johnstone | Hibernian | 1              | 4               |