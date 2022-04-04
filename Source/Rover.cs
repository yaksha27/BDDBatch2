using System;

namespace MarsRovers
{
    internal class Rover
    {
      private Point _position;
        private string _direction;

        internal void SetPosition(Point position)
        {
            _position = position;
        }

        internal Point GetPosition()
        {
            return _position;
        }

        internal void SetDirection(string direction)
        {
            _direction = direction;
        }

        internal string GetDirection()
        {
            return _direction;
        }

        internal void Move()
        {
            throw new NotImplementedException();
        }
    }
}