Feature: Operate the rover
Scenario Outline: Move the rover to the target location
Given Rover is at <x>, <y>
And the rover is facing <direction>
When rover is given <commands>
Then rover should be at <newX> <newY>
And rover should be facing <newDirection>
Examples:
|x|y|direction|commands|newX|newY|newDirection|
