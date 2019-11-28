Feature: SearchResult
	User pasts a text of the link below the headline article

Scenario: User copy and paste text of the link of the headline article
   Given That User on the BBC News web page
   When User copys text of the link which located under the headline article
   When User inserts this text to the search bar
   Then User verified that '<result>' matching to the first search query result
Examples: 
| result |
| China  |