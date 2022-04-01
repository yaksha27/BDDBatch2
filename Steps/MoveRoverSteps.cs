using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MarsRovers.Steps
{
    class MoveRoverSteps
    {
        private readonly ScenarioContext _scenarioContext;

        public MoveRoverSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"Rover is at (.*), (.*)")]
        public void GivenRoverIsAt(int p0, int p1)
        {
            _scenarioContext.Pending();
        }

        [Given(@"rover is pointing towards E")]
        public void GivenRoverIsPointingTowardsE()
        {
            _scenarioContext.Pending();
        }

        [When(@"rover moves forward")]
        public void WhenRoverMovesForward()
        {
            _scenarioContext.Pending();
        }

        [Then(@"rover should be at (.*)")]
        public void ThenRoverShouldBeAt(string p0)
        {
            _scenarioContext.Pending();
        }

        [Then(@"rover should be facing E")]
        public void ThenRoverShouldBeFacingE()
        {
            _scenarioContext.Pending();
        }
    }
}
