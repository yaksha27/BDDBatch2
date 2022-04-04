using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers.UnitTest
{
    class PointTest
    {
        [Test]
        public void PointsShouldBeSame ()
        {
            Point p1 = new Point(2 ,3);
            Point p2 = new Point(2, 3);

            Assert.AreEqual(p1, p2);

        }

        [Test]
        public void PointsShouldBeDifferent()
        {
            Point p1 = new Point(2, 3);
            Point p2 = new Point(1, 3);

            Assert.AreNotEqual(p1, p2);

        }
    }
}
