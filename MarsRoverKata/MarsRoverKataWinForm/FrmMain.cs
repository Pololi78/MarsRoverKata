using MarsRoverKataApi;
using MarsRoverKataApi.Exceptions;
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
            cboRoverDirection.SelectedIndex = 0;
        }

        #region "UI events"

        private void btnSetupMarsAndRover_Click(object sender, EventArgs e)
        {


            MarsGrid marsGrid = null;

            btnSendCommands.Enabled = false;

            //Setup Mars grid

            var gridX = Convert.ToInt32(numMarsGridX.Value);
            var gridY = Convert.ToInt32(numMarsGridY.Value);
            
            var gridDimension = new MarsRoverKataApi.Point(gridX, gridY);

            try
            {
                marsGrid = new MarsGrid(gridDimension, _obstacleList);

            }
            catch (Exception ex)
            {

                if (ex is GridDimensionInvalidException || ex is ObstaclePositionInvalidException)
                {

                    MessageBox.Show(ex.Message, "Mars grid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                throw;
            }
                
            //Setup rover

            var roverX = Convert.ToInt32(numRoverX.Value);
            var roverY = Convert.ToInt32(numRoverY.Value);
            
            var roverStartingPosition = new MarsRoverKataApi.Point(roverX, roverY);


            try
            {
                _rover = new Rover(marsGrid, roverStartingPosition, cboRoverDirection.Text);
            }
            catch (Exception ex)
            {

                if (ex is RoverStartingDirectionInvalidException || ex is RoverStartingPositionInvalidException)
                {

                    MessageBox.Show(ex.Message, "Rover", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                throw;

            }


            btnSendCommands.Enabled = true;
            txtRoverStatus.Text = roverX + "," + roverY + " " + cboRoverDirection.Text;

            MessageBox.Show("Mars grid and rover correctly setup", "Setup", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
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

                var msg = "Rover has executed the commands but it found an obstacle!" + System.Environment.NewLine + System.Environment.NewLine + "Check the new status";
                MessageBox.Show(msg, "Rover", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                var msg = "Rover has executed the commands!" + System.Environment.NewLine + System.Environment.NewLine+ "Check the new status";
                MessageBox.Show(msg, "Rover", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txtRoverStatus.Text = roverInfo.RoverPosition.X + "," + roverInfo.RoverPosition.Y + " " + roverInfo.RoverDirection;
            txtCommands.Text = String.Empty;

        }

        #endregion

     }
}
