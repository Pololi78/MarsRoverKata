using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRoverKataApi;
using System.Collections.Generic;

namespace MarsRoverKataTests
{
    [TestClass]
    public class MarsGridTests
    {
        [TestMethod]
        public void Rover_Turns_Left_From_North()
        {

            var gridDimension = new Point(1, 1);
            var obstacleList = new List<Obstacle>();

            var marsGrid = new MarsGrid(gridDimension, obstacleList);

            var newDirection = marsGrid.TurnRoverLeft(Direction.North);

            Assert.IsTrue(newDirection == Direction.West);

        }


    }
}
