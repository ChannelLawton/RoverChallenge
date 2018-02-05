using System;

namespace MarsRoverApp
{
    public class Rover
    {
        public int ZoneSizeX;

        public int ZoneSizeY;

        public int PositionX;

        public int PositionY;

        public string Commands;

        public CompassValue RoverPosition;

        public string Calculate()
        {
            char[] commands = Commands.ToCharArray();

            foreach (var command in commands)
            {
                switch (command)
                {
                    case ('L'):
                        TurnLeft();
                        break;
                    case ('R'):
                        TurnRight();
                        break;
                    case ('M'):
                        Move();
                        break;
                    default:
                        throw new ArgumentException($"Invalid value: {command}");
                }
            }

            if (IsPositionValid())
                return $"{PositionX} {PositionY} {RoverPosition.ToString()}";
            else
                return "Result postion not valid.";
        }

        private bool IsPositionValid()
        {
            if (PositionX > ZoneSizeX || PositionY > ZoneSizeY)
                return false;
            else
                return true;
        }

        private void TurnLeft()
        {
            RoverPosition = (RoverPosition - 1) < CompassValue.N ? CompassValue.W : RoverPosition - 1;
        }

        private void TurnRight()
        {
            RoverPosition = (RoverPosition + 1) > CompassValue.W ? CompassValue.N : RoverPosition + 1;
        }

        private void Move()
        {
            if (RoverPosition == CompassValue.N)
            {
                PositionY++;
            }
            else if (RoverPosition == CompassValue.E)
            {
                PositionX++;
            }
            else if (RoverPosition == CompassValue.S)
            {
                PositionY--;
            }
            else if (RoverPosition == CompassValue.W)
            {
                PositionX--;
            }
        }

    }

}








