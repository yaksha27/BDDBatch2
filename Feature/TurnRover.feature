Feature: Turning the rover

Scenario Outline: Turn the rover in desired direction
	Given Rover is at 1, 2
	And rover is pointing towards <direction>
	When rover turns <90degreesTo>
	Then rover should be facing <newDirection>

	Examples: Left turn
		| direction | 90degreesTo | newDirection |
		| N         | L           | W            |
		| W         | L           | S            |
		| S         | L           | E            |
		| E         | L           | N            |

	Examples: Right turn
		| direction | 90degreesTo | newDirection |
		| N         | R           | E            |
		| E         | R           | S            |
		| S         | R           | W            |
		| W         | R           | N            |