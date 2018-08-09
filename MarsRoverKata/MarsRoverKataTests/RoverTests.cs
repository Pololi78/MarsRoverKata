using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRoverKataApi;
using System.Collections.Generic;
using MarsRoverKataApi.Exceptions;

namespace MarsRoverKataTests
{
    [TestClass]
    public class RoverTests
    {

        #region "Exceptions"

        [TestMethod]
        [ExpectedException(typeof(RoverStartingPositionInvalidException ))]
        public void Rover_Starting_Position_Is_Invalid_Because_It_Is_Outside_The_Grid()
        {

            var gridDimension = new Point(1, 1);
            var obstacleList = new List<Obstacle>();

            var marsGrid = new MarsGrid(gridDimension, obstacleList);
            var rover = new Rover(marsGrid, new Point(1, 2), Direction.South);

        }

        [TestMethod]
        [ExpectedException(typeof(RoverStartingPositionInvalidException))]
        public void Rover_Starting_Position_Is_Invalid_Because_It_Is_On_An_Obstacle()
        {

            var gridDimension = new Point(3, 3);
            var obstacleList = new List<Obstacle>();
            obstacleList.Add(new Obstacle(new Point(1, 2)));

            var marsGrid = new MarsGrid(gridDimension, obstacleList);
            var rover = new Rover(marsGrid, new Point(1, 2), Direction.South);


        }

        [TestMethod]
        [ExpectedException(typeof(RoverStartingDirectionInvalidException))]
        public void Rover_Direction_Is_Invalid()
        {

            var gridDimension = new Point(1, 1);
            var obstacleList = new List<Obstacle>();
            
            var marsGrid = new MarsGrid(gridDimension, obstacleList);
            var rover = new Rover(marsGrid, new Point(1, 1), "D");


        }

        #endregion

        #region "Behaviors"

        [TestMethod]
        public void Rover_Receives_No_Commands()
        {
            var gridDimension = new Point(2, 2);
            var obstacleList = new List<Obstacle>();

            var marsGrid = new MarsGrid(gridDimension, obstacleList);

            var rover = new Rover(marsGrid, new Point(2, 2), Direction.North);

            var roverInfo = rover.MoveAndTurn("");

            Assert.IsTrue(roverInfo.RoverDirection == Direction.North &&
                          roverInfo.RoverPosition.X == 2 &&
                          roverInfo.RoverPosition.Y == 2);

        }

        #endregion
    }
}
