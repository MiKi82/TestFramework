Feature: BBCPage
	User invoks a BBC News page, checks headline 
	  article name.

Scenario: Check BBC News Headline page
	Given That User on the BBC.com web site
	When User proceed to BBC News page
	Then User can see a BBC News page and '<headline>' news article on page
Examples: 
| headline                                          |
| China rebukes US for backing Hong Kong protesters |
