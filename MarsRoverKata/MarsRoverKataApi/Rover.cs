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
        
        /// <summary>
        /// Create a rover
        /// </summary>
        /// <param name="marsGrid">The grid of the planet Mars where the rover will move</param>
        /// <param name="roverStartingPosition">The starting position of the rover</param>
        /// <param name="roverDirection">The starting direction of the rover. N north, S south, E east, W west</param>
        /// <remarks>Provide a rover starting position inside the grid and a valid rover direction</remarks>
        public Rover(MarsGrid marsGrid,
                     Point roverStartingPosition, 
                     String roverDirection)
        {


            _marsGrid = marsGrid;
            CurrentRoverDirection = roverDirection.ToUpper();
            CurrentRoverPosition = roverStartingPosition;

            ValidateRoverStartingPosition();
            ValidateRoverStartingDirection();


        }

        #region "Validation"

        private void ValidateRoverStartingPosition()
        {
            _marsGrid.ValidateRoverStartingPosition(CurrentRoverPosition);

        }

        private void ValidateRoverStartingDirection()
        {

            if (CurrentRoverDirection != Direction.North && 
                CurrentRoverDirection != Direction.South &&
                CurrentRoverDirection != Direction.West &&
                CurrentRoverDirection != Direction.East)

            {

                throw new Exceptions.RoverStartingDirectionInvalidException(String.Format("Rover starting direction [{0}] is not valid", CurrentRoverDirection));
            }

        }

        #endregion

        #region "Commands"
        /// <summary>
        /// Move and turn the rover by sending a list of commands.
        /// </summary>
        /// <param name="roverCommands">A list of commands in the form of a string (for example "FFFBM"). Valid commands are M move forward, B move backward, L turn left, R turn right</param>
        /// <remarks>Unknown commands are ignored</remarks>
        public void MoveAndTurn(String roverCommands)
        {

            var roverCommandList = roverCommands.ToUpper().ToCharArray();

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
                                           
                        
                }

            }

        }


        #endregion

        



    }
}
