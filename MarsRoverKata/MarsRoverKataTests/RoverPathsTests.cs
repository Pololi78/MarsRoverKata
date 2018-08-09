using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRoverKataApi;
using System.Collections.Generic;
using MarsRoverKataApi.Exceptions;

namespace MarsRoverKataTests
{
    [TestClass]
    public class RoverPathTests
    {

        
        [TestMethod]
        public void Rover_Reaches_Correct_Position_1()
        {

            var gridDimension = new Point(2, 2);
            var obstacleList = new List<Obstacle>();

            var marsGrid = new MarsGrid(gridDimension, obstacleList);

            var rover = new Rover(marsGrid, new Point(1, 1), Direction.North);

            var roverInfo = rover.MoveAndTurn("FF");

            Assert.IsTrue(roverInfo.RoverDirection == Direction.North &&
                          roverInfo.RoverPosition.X == 1 &&
                          roverInfo.RoverPosition.Y == 1);
        }

        [TestMethod]
        public void Rover_Reaches_Correct_Position_2()
        {

            var gridDimension = new Point(5, 5);
            var obstacleList = new List<Obstacle>();

            var marsGrid = new MarsGrid(gridDimension, obstacleList);

            var rover = new Rover(marsGrid, new Point(1, 2), Direction.North);

            var roverInfo = rover.MoveAndTurn("LFLFLFLFF");

            Assert.IsTrue(roverInfo.RoverDirection == Direction.North &&
                          roverInfo.RoverPosition.X == 1 &&
                          roverInfo.RoverPosition.Y == 3);
        }

        [TestMethod]
        public void Rover_Reaches_Correct_Position_3()
        {

            var gridDimension = new Point(5, 5);
            var obstacleList = new List<Obstacle>();

            var marsGrid = new MarsGrid(gridDimension, obstacleList);

            var rover = new Rover(marsGrid, new Point(3, 3), Direction.East);

            var roverInfo = rover.MoveAndTurn("FFRFFRFRRF");

            Assert.IsTrue(roverInfo.RoverDirection == Direction.East &&
                          roverInfo.RoverPosition.X == 5 &&
                          roverInfo.RoverPosition.Y == 1);
        }

        
    }
}
