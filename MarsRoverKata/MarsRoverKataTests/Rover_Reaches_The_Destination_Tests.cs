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
        public void Rover_Reaches_The_Destination_1()
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
        public void Rover_Reaches_The_Destination_2()
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
        public void Rover_Reaches_The_Destination_3()
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

        [TestMethod]
        public void Rover_Reaches_The_Destination_4()
        {

            var gridDimension = new Point(20, 17);

            var obstacleListString = "2,3;2,4;2,5;2,6;2,7;2,8;2,9;2,10";
            obstacleListString += ";4,8;4,14;7,4;8,4;9,4;9,12;9,13;13,10;13,11;17,16";
            var obstacleList = CreateObstacleList(obstacleListString);
            
            var marsGrid = new MarsGrid(gridDimension, obstacleList);

            var rover = new Rover(marsGrid, new Point(8, 2), Direction.North);

            var roverInfo = rover.MoveAndTurn("RFFFLFFFRFRFFFFFFFFRFFFL");
            
            Assert.IsTrue(roverInfo.RoverDirection == Direction.South &&
                          roverInfo.RoverPosition.X == 9 &&
                          roverInfo.RoverPosition.Y == 14);
        }

        private List<Obstacle> CreateObstacleList(String obstacleListString)
        {

            var obstacleList = new List<Obstacle>();
            var obstaclePointList = obstacleListString.Split(';');

            foreach (var obstaclePoint in obstaclePointList)
            {

                var xy = obstaclePoint.Split(',');

                var obstacle = new Obstacle(new Point(Convert.ToInt32(xy[0]), Convert.ToInt32(xy[1])));
                obstacleList.Add(obstacle);
            }

            return obstacleList;
            
        }



    }
}
