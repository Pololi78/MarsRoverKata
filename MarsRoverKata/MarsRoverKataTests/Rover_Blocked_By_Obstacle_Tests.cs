using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRoverKataApi;
using System.Collections.Generic;
using MarsRoverKataApi.Exceptions;

namespace MarsRoverKataTests
{
    [TestClass]
    public class Rover_Blocked_By_Obstacle_Tests
    {

                
        [TestMethod]
        public void Rover_Blocked_By_Obstacle_1()
        {

            var gridDimension = new Point(20, 17);

            var obstacleListString = "2,3;2,4;2,5;2,6;2,7;2,8;2,9;2,10";
            obstacleListString += ";4,8;4,14;7,4;8,4;9,4;9,12;9,13;13,10;13,11;17,16";
            var obstacleList = CreateObstacleList(obstacleListString);

            var marsGrid = new MarsGrid(gridDimension, obstacleList);

            var rover = new Rover(marsGrid, new Point(8, 2), Direction.North);

            var roverInfo = rover.MoveAndTurn("LFFRFFFFFFLFFFF");

            Assert.IsTrue(roverInfo.RoverHasBeenBlockedByObstacle &&
                          roverInfo.RoverDirection == Direction.West &&
                          roverInfo.RoverPosition.X == 5 &&
                          roverInfo.RoverPosition.Y == 8);
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
