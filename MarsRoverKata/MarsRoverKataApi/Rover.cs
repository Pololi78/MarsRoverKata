using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverKataApi
{
    public class Rover
    {

        private MarsGrid _marsGrid;
        public Point CurrentRoverPosition { get; internal set; }
        public String CurrentRoverDirection { get; internal set; }
        
        public Rover(MarsGrid marsGrid,
                     Point roverStartingPoint, 
                     String roverDirection)
        {

            _marsGrid = marsGrid;
            CurrentRoverDirection = roverDirection;
            CurrentRoverPosition = roverStartingPoint;
            
            
        }

    #region "Commands"

        public void MoveAndTurn(String roverCommands)
        {

            var roverCommandList = roverCommands.ToCharArray();

            foreach (var roverCommand in roverCommandList)
            {
                switch (roverCommand)
                {

                    case RoverCommand.MoveForward:
                        CurrentRoverPosition = _marsGrid.MoveRover(roverCommand, CurrentRoverDirection, CurrentRoverPosition);
                        break;

                    case RoverCommand.MoveBackward:
                        CurrentRoverPosition = _marsGrid.MoveRover(roverCommand, CurrentRoverDirection, CurrentRoverPosition);
                        break;

                    case RoverCommand.TurnRight:
                        CurrentRoverDirection = _marsGrid.TurnRoverRight(CurrentRoverDirection);
                        break;

                    case RoverCommand.TurnLeft:
                        CurrentRoverDirection = _marsGrid.TurnRoverLeft(CurrentRoverDirection);
                        break;

                    default:
                        throw new Exception(String.Format("[{0}] is not a valid command", roverCommand));


                }

            }

        }


        #endregion

        



    }
}
