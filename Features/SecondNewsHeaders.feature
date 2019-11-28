Feature: SecondNewsHeaders
I Check secondary article titles against a hard-coded


Scenario: Check BBC News second articles 
	Given That User on the BBC News web page
	When User check if all second articles are present
	Then User sees all BBC News second headers 
	| headers                                            |
	| Escalating Iraq protests leave 13 dead             |
	| US envoy to EU accused of sexual misconduct        |
	| Thanksgiving travellers delayed by US storms       |
	| Violence during consensual sex 'normalised'        |
	| The Antarctic plane crash that changed New Zealand |


   