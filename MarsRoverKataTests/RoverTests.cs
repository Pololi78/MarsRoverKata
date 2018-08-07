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
        public void Rover_Does_Work()
        {

            var gridDimension = new Point(2,2);
            var obstacleList = new List<Obstacle>();
            obstacleList.Add(new Obstacle(new Point(1, 1)));

            var marsGrid = new MarsGrid(gridDimension, obstacleList);

            var rover = new Rover(marsGrid, new Point(1, 1), Direction.North);

            rover.ExecuteRoverCommandList("FF");

            Assert.IsTrue(rover.CurrentRoverDirection == Direction.North && 
                          rover.CurrentRoverPosition.X == 1 && 
                          rover.CurrentRoverPosition.Y == 1);
        }
    }
}
