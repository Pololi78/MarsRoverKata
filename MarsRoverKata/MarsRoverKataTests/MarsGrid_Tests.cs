using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRoverKataApi;
using System.Collections.Generic;
using MarsRoverKataApi.Exceptions;

namespace MarsRoverKataTests
{
    [TestClass]
    public class MarsGrid_Tests
    {

        #region "Exceptions"

        [TestMethod]
        [ExpectedException(typeof(GridDimensionInvalidException))]
        public void Grid_Dimensions_Are_Invalid()
        {

            var gridDimension = new Point(0, 1);
            var obstacleList = new List<Obstacle>();

            var marsGrid = new MarsGrid(gridDimension, obstacleList);
                      

        }

        [TestMethod]
        [ExpectedException(typeof(ObstaclePositionInvalidException))]
        public void Obstacle_Position_Is_Invalid()
        {

            var gridDimension = new Point(1, 1);
            var obstacleList = new List<Obstacle>();
            obstacleList.Add(new Obstacle(new Point(1, 2)));

            var marsGrid = new MarsGrid(gridDimension, obstacleList);


        }



        #endregion

        #region "Behaviors"

        [TestMethod]
        public void Rover_Turns_Left_From_North()
        {

            var gridDimension = new Point(1, 1);
            var obstacleList = new List<Obstacle>();

            var marsGrid = new MarsGrid(gridDimension, obstacleList);

            var newDirection = marsGrid.TurnRoverLeft(Direction.North);

            Assert.IsTrue(newDirection == Direction.West);

        }

        #endregion

    }
}
