using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MarsRovers.Steps
{
    [Binding]
    class MoveRoverSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private Rover rover;
        public MoveRoverSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"Rover is at (\d+), (\d+)")]
        public void GivenRoverIsAt(int x, int y)
        {
           Point position = new Point(x, y);
             rover = new Rover();
            rover.SetPosition(position);
        }

        [Given(@"rover is pointing towards ([NEWS]{1})")]
        public void GivenRoverIsPointingTowardsDirection(char direction)
        {
            rover.SetDirection(direction);
        }

        [When(@"rover moves forward")]
        public void WhenRoverMovesForward()
        {
            rover.Move();
        }

        [Then(@"rover should be at (\d+), (\d+)")]
        public void ThenRoverShouldBeAt(int x, int y)
        {
            rover.GetPosition().Should().Be(new Point(x, y));
        }

        [Then(@"rover should be facing ([NEWS]{1})")]
        public void ThenRoverShouldBeFacingE(char direction)
        {
            rover.GetDirection().Should().Be(direction);
        }
    }
}
