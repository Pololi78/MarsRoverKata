using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverKataApi
{
    public class MarsGrid
    {

        private Point _gridDimension;
        private List<Obstacle> _obstacleList;

        /// <summary>
        /// Create a mars grid
        /// </summary>
        /// <param name="gridDimension">Maximum x and y coordinates for the grid</param>
        /// <param name="obstacleList">A list of obstacles. Provide it empty is no obstacles</param>
        /// <remarks>
        /// A grid dimension is not valid if x or y are minus than zero.
        /// Obstacles must be inside the grid otherwise an exception will be thrown.
        /// </remarks>
        public MarsGrid(Point gridDimension, List<Obstacle> obstacleList)
        {


            _gridDimension = gridDimension;
            _obstacleList = obstacleList;

            ValidateGridDimensions();
            ValidateObstaclesPosition();
              

        }

        #region "Validation"

        private void ValidateGridDimensions()
        {

            if (_gridDimension.X < 1 || _gridDimension.Y < 1)
            {
                throw new Exceptions.GridDimensionInvalidException("Grid dimensions x and y must be greater than zero");
            }
        }

        private void ValidateObstaclesPosition()
        {


            foreach(var obstacle in _obstacleList)
            {

                if (obstacle.Position.X > _gridDimension.X || obstacle.Position.Y > _gridDimension.Y)
                {
                    throw new Exceptions.ObstaclePositionInvalidException(String.Format("Obstacle with coordinates [{0},{1}] is outside the grid [{2},{3}]",obstacle.Position.X, obstacle.Position.Y, _gridDimension.X, _gridDimension.Y));
                }

            }

        }

        internal void ValidateRoverStartingPosition(Point roverStartingPosition)
        {

            CheckRoverIsNotOutsideGrid(roverStartingPosition);
            CheckRoverIsNotOnObstacle(roverStartingPosition);


        }

        private void CheckRoverIsNotOutsideGrid(Point roverStartingPosition)
        {
            if (roverStartingPosition.X > _gridDimension.X || roverStartingPosition.Y > _gridDimension.Y)
            {
                throw new Exceptions.RoverStartingPositionInvalidException(String.Format("Rover starting position [{0},{1}] is outside the grid [{2},{3}]", roverStartingPosition.X, roverStartingPosition.Y, _gridDimension.X, _gridDimension.Y));
            }
        }

        private void CheckRoverIsNotOnObstacle(Point roverStartingPosition)
        {

            if (CheckObstacle(roverStartingPosition))
            {
                throw new Exceptions.RoverStartingPositionInvalidException(String.Format("Rover starting position [{0},{1}] corresponds to an obstacle position", roverStartingPosition.X, roverStartingPosition.Y));
            }
            
        }

        #endregion

        #region "Commands"

        internal Point MoveRover(Char whichWay, String roverDirection, Point roverPosition)
        {
            Int32 whichWayFactor = 1;

            if (whichWay == RoverCommand.MoveBackward) whichWayFactor = -1;

            switch (roverDirection)
            {
                case Direction.North:
                    roverPosition.Y += 1 * whichWayFactor;
                    break;

                case Direction.South:
                    roverPosition.Y -= 1 * whichWayFactor;
                    break;

                case Direction.East:
                    roverPosition.X += 1 * whichWayFactor;
                    break;

                case Direction.West:
                    roverPosition.X -= 1 * whichWayFactor;
                    break;

            }

            roverPosition = ApplyWrapping(roverPosition);
            var obstacleFound = CheckObstacle(roverPosition);
                        
            return roverPosition;

        }

        internal String TurnRoverRight(String roverDirection)
        {

            switch (roverDirection)
            {
                case Direction.North:
                    roverDirection = Direction.East;
                    break;

                case Direction.South:
                    roverDirection = Direction.West;
                    break;

                case Direction.East:
                    roverDirection = Direction.South;
                    break;

                case Direction.West:
                    roverDirection = Direction.North;
                    break;

            }


            return roverDirection;
           

        }

        internal String TurnRoverLeft(String roverDirection)
        {

            switch (roverDirection)
            {
                case Direction.North:
                    roverDirection = Direction.West;
                    break;

                case Direction.South:
                    roverDirection = Direction.East;
                    break;

                case Direction.East:
                    roverDirection = Direction.North;
                    break;

                case Direction.West:
                    roverDirection = Direction.South;
                    break;

            }


            return roverDirection;
        }

        #endregion

        #region "Behaviors"

        private Point ApplyWrapping(Point roverPosition)
        {

            if (roverPosition.X > _gridDimension.X) roverPosition.X = 1;
            if (roverPosition.X < 0) roverPosition.X = _gridDimension.X;

            if (roverPosition.Y > _gridDimension.Y) roverPosition.Y = 1;
            if (roverPosition.Y < 0) roverPosition.Y = _gridDimension.Y;
            
            return roverPosition;
        }

        private Boolean CheckObstacle(Point roverPosition)
        {

            var obstacleFound = _obstacleList.Find(o => o.Position.X == roverPosition.X && o.Position.Y == roverPosition.Y);

            if (obstacleFound != null)
                return true;
            else
                return false;

        }

        

        #endregion

    }
}
