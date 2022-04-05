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

        internal void Turn(string turndirection)
        {
            switch(_direction)
            {
                case "N":
                    if(turndirection == "L")
                    {
                        _direction = "W";
                        break;
                    }

                    else {
                        _direction = "E";
                        break;
                    }
                case "S":
                    if (turndirection == "L")
                    {
                        _direction = "E";
                        break;
                    }

                    else
                    {
                        _direction = "W";
                        break;
                    }
                case "E":
                    if (turndirection == "L")
                    {
                        _direction = "N";
                        break;
                    }

                    else
                    {
                        _direction = "S";
                        break;
                    }
                case "W":
                    if (turndirection == "L")
                    {
                        _direction = "S";
                        break;
                    }

                    else
                    {
                        _direction = "N";
                        break;
                    }
            }
        }
        internal void Move()
        {
            switch (_direction)
            {
                case "N":
                    _position = new Point(_position.X, _position.Y + 1);
                    break;
                case "S":
                    _position = new Point(_position.X, _position.Y - 1);
                    break;
                case "E":
                    _position = new Point(_position.X + 1, _position.Y);
                    break;
                case "W":
                    _position = new Point(_position.X - 1, _position.Y);
                    break;


            }
        }
    }
}