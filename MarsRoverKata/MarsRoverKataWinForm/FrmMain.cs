using MarsRoverKataApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarsRoverKataWinForm
{
    public partial class FrmMain : Form
    {

        private List<Obstacle> _obstacleList = new List<Obstacle>();
        private Rover _rover;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnSetupMarsAndRover_Click(object sender, EventArgs e)
        {

            var gridX = Convert.ToInt32(numMarsGridX.Value);
            var gridY = Convert.ToInt32(numMarsGridY.Value);
            
            var gridDimension = new MarsRoverKataApi.Point(gridX, gridY);
            var marsGrid = new MarsGrid(gridDimension, _obstacleList);
      
            var roverX = Convert.ToInt32(numRoverX.Value);
            var roverY = Convert.ToInt32(numRoverY.Value);
            
            var roverStartingPosition = new MarsRoverKataApi.Point(roverX, roverY);
            _rover = new Rover(marsGrid, roverStartingPosition, cboRoverDirection.Text);

            txtRoverStatus.Text = roverX + "," + roverY + " " + cboRoverDirection.Text;
            
        }

        private void btnAddObstacle_Click(object sender, EventArgs e)
        {

            var x = Convert.ToInt32(numObstacleX.Value);
            var y = Convert.ToInt32(numObstacleY.Value);

            var coordinates = new MarsRoverKataApi.Point(x, y);
            
            var obstacle = new Obstacle(coordinates);

            _obstacleList.Add(obstacle);

            txtObstacleList.Text += x + "," + y + ";";
                       

        }

        private void btnResetObstacleList_Click(object sender, EventArgs e)
        {

            _obstacleList = new List<Obstacle>();
            txtObstacleList.Text = String.Empty;

        }

        private void btnSendCommands_Click(object sender, EventArgs e)
        {

            var roverInfo = _rover.MoveAndTurn(txtCommands.Text);

            if (roverInfo.RoverHasBeenBlockedByObstacle)
            {

                MessageBox.Show("Rover has moved but found an obstacle!", "Rover", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                MessageBox.Show("Rover has moved!", "Rover", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txtRoverStatus.Text = roverInfo.RoverPosition.X + "," + roverInfo.RoverPosition.Y + " " + roverInfo.RoverDirection;
            txtCommands.Text = String.Empty;

        }
    }
}
