using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRoverKataApi;
using System.Collections.Generic;

namespace MarsRoverKataTests
{
    [TestClass]
    public class RoverTests
    {
        [TestMethod]
        public void Rover_Reaches_Correct_Position_1()
        {

            var gridDimension = new Point(2,2);
            var obstacleList = new List<Obstacle>();
            
            var marsGrid = new MarsGrid(gridDimension, obstacleList);

            var rover = new Rover(marsGrid, new Point(1, 1), Direction.North);

            rover.MoveAndTurn("FF");

            Assert.IsTrue(rover.CurrentRoverDirection == Direction.North && 
                          rover.CurrentRoverPosition.X == 1 && 
                          rover.CurrentRoverPosition.Y == 1);
        }

        [TestMethod]
        public void Rover_Reaches_Correct_Position_2()
        {

            var gridDimension = new Point(5, 5);
            var obstacleList = new List<Obstacle>();

            var marsGrid = new MarsGrid(gridDimension, obstacleList);

            var rover = new Rover(marsGrid, new Point(1, 2), Direction.North);

            rover.MoveAndTurn("LFLFLFLFF");

            Assert.IsTrue(rover.CurrentRoverDirection == Direction.North &&
                          rover.CurrentRoverPosition.X == 1 &&
                          rover.CurrentRoverPosition.Y == 3);
        }

        [TestMethod]
        public void Rover_Reaches_Correct_Position_3()
        {

            var gridDimension = new Point(5, 5);
            var obstacleList = new List<Obstacle>();

            var marsGrid = new MarsGrid(gridDimension, obstacleList);

            var rover = new Rover(marsGrid, new Point(3, 3), Direction.East);

            rover.MoveAndTurn("FFRFFRFRRF");

            Assert.IsTrue(rover.CurrentRoverDirection == Direction.East &&
                          rover.CurrentRoverPosition.X == 5 &&
                          rover.CurrentRoverPosition.Y == 1);
        }
    }
}
