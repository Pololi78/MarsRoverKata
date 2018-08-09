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
        private Point _currentRoverPosition;
        private String _currentRoverDirection;
        
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
            _currentRoverDirection = roverDirection.ToUpper();
            _currentRoverPosition = roverStartingPosition;

            ValidateRoverStartingPosition();
            ValidateRoverStartingDirection();


        }

        #region "Validation"

        private void ValidateRoverStartingPosition()
        {
            _marsGrid.ValidateRoverStartingPosition(_currentRoverPosition);

        }

        private void ValidateRoverStartingDirection()
        {

            if (_currentRoverDirection != Direction.North &&
                _currentRoverDirection != Direction.South &&
                _currentRoverDirection != Direction.West &&
                _currentRoverDirection != Direction.East)

            {

                throw new Exceptions.RoverStartingDirectionInvalidException(String.Format("Rover starting direction [{0}] is not valid", _currentRoverDirection));
            }

        }

        #endregion

        #region "Commands"
        /// <summary>
        /// Move and turn the rover by sending a list of commands.
        /// </summary>
        /// <param name="roverCommands">A list of commands in the form of a string (for example "FFFBM"). Valid commands are M move forward, B move backward, L turn left, R turn right</param>
        /// <returns>Rover info as the position, the direction and if an obstacle was found</returns>
        /// <remarks>Unknown commands are ignored</remarks>
        public RoverInfo MoveAndTurn(String roverCommands)
        {

            Int32 cont = 0;
            Char roverCommand;
            Boolean obstacleFound = false;
            MarsGrid.MoveRoverResponse response;

            var roverCommandList = roverCommands.ToUpper().ToCharArray();
                      
            if (roverCommandList.Count() > 0)
                do
                {

                    roverCommand = roverCommandList[cont];

                    switch (roverCommand)
                    {

                        case RoverCommand.MoveForward:
                            response = _marsGrid.MoveRover(roverCommand, _currentRoverDirection, _currentRoverPosition);
                            _currentRoverPosition = response.RoverPosition;
                            obstacleFound = response.RoverHasBeenBlockedByObstacle;
                            break;

                        case RoverCommand.MoveBackward:
                            response = _marsGrid.MoveRover(roverCommand, _currentRoverDirection, _currentRoverPosition);
                            _currentRoverPosition = response.RoverPosition;
                            obstacleFound = response.RoverHasBeenBlockedByObstacle;
                            break;

                        case RoverCommand.TurnRight:
                            _currentRoverDirection = _marsGrid.TurnRoverRight(_currentRoverDirection);
                            break;

                        case RoverCommand.TurnLeft:
                            _currentRoverDirection = _marsGrid.TurnRoverLeft(_currentRoverDirection);
                            break;
                            
                    }

                    cont++;
                    
                } while (cont < roverCommandList.Count() && obstacleFound == false);

            var roverInfo = new RoverInfo() { RoverPosition = _currentRoverPosition, RoverDirection = _currentRoverDirection, RoverHasBeenBlockedByObstacle = obstacleFound };

            return roverInfo;
        }


        #endregion

        #region "Structured responses"

        public class RoverInfo
        {

            public Point RoverPosition { get; internal set; }
            public String RoverDirection { get; internal set; }
            public Boolean RoverHasBeenBlockedByObstacle { get; internal set; }

        }

        #endregion



    }
}
