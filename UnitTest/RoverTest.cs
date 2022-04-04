using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers.UnitTest
{
    class RoverTest
    {
        [Test]
        public void RoverShouldBeAtPosition()
        {
            Rover rover = new Rover();
            rover.SetPosition(new Point(2, 3));
            Assert.AreEqual(new Point(2, 3), rover.GetPosition());
        }
        [Test]
        public void RoverShouldBeAtDirection()
        {
            Rover rover = new Rover();
            rover.SetDirection("E");
            Assert.AreEqual("E", rover.GetDirection());
        }
        
        [Test]
        public void RoverShouldMoveForwarded()
        {
            Rover rover = new Rover();
            rover.SetDirection("N");
            rover.SetPosition(new Point(3, 6));
            rover.Move();
            Assert.AreEqual("N", rover.GetDirection());
            Assert.AreEqual(new Point(3, 7), rover.GetPosition());
        }
    }
}
