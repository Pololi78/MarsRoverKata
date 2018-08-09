namespace MarsRoverKataWinForm
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboRoverDirection = new System.Windows.Forms.ComboBox();
            this.btnSetupMarsAndRover = new System.Windows.Forms.Button();
            this.btnResetObstacleList = new System.Windows.Forms.Button();
            this.txtObstacleList = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.numRoverY = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numRoverX = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddObstacle = new System.Windows.Forms.Button();
            this.numObstacleY = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numObstacleX = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numMarsGridY = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numMarsGridX = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSendCommands = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtRoverStatus = new System.Windows.Forms.TextBox();
            this.txtCommands = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRoverY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRoverX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numObstacleY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numObstacleX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMarsGridY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMarsGridX)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cboRoverDirection);
            this.groupBox1.Controls.Add(this.btnSetupMarsAndRover);
            this.groupBox1.Controls.Add(this.btnResetObstacleList);
            this.groupBox1.Controls.Add(this.txtObstacleList);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.numRoverY);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.numRoverX);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnAddObstacle);
            this.groupBox1.Controls.Add(this.numObstacleY);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numObstacleX);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numMarsGridY);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numMarsGridX);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 284);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Define Mars and rover";
            // 
            // cboRoverDirection
            // 
            this.cboRoverDirection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoverDirection.FormattingEnabled = true;
            this.cboRoverDirection.Items.AddRange(new object[] {
            "N",
            "S",
            "W",
            "E"});
            this.cboRoverDirection.Location = new System.Drawing.Point(347, 194);
            this.cboRoverDirection.MaxDropDownItems = 4;
            this.cboRoverDirection.Name = "cboRoverDirection";
            this.cboRoverDirection.Size = new System.Drawing.Size(55, 21);
            this.cboRoverDirection.TabIndex = 19;
            // 
            // btnSetupMarsAndRover
            // 
            this.btnSetupMarsAndRover.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetupMarsAndRover.ForeColor = System.Drawing.Color.Black;
            this.btnSetupMarsAndRover.Location = new System.Drawing.Point(23, 246);
            this.btnSetupMarsAndRover.Name = "btnSetupMarsAndRover";
            this.btnSetupMarsAndRover.Size = new System.Drawing.Size(417, 23);
            this.btnSetupMarsAndRover.TabIndex = 19;
            this.btnSetupMarsAndRover.Text = "Setup Mars and rover";
            this.btnSetupMarsAndRover.UseVisualStyleBackColor = true;
            this.btnSetupMarsAndRover.Click += new System.EventHandler(this.btnSetupMarsAndRover_Click);
            // 
            // btnResetObstacleList
            // 
            this.btnResetObstacleList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetObstacleList.ForeColor = System.Drawing.Color.Black;
            this.btnResetObstacleList.Location = new System.Drawing.Point(347, 101);
            this.btnResetObstacleList.Name = "btnResetObstacleList";
            this.btnResetObstacleList.Size = new System.Drawing.Size(93, 23);
            this.btnResetObstacleList.TabIndex = 18;
            this.btnResetObstacleList.Text = "Reset obstacles";
            this.btnResetObstacleList.UseVisualStyleBackColor = true;
            this.btnResetObstacleList.Click += new System.EventHandler(this.btnResetObstacleList_Click);
            // 
            // txtObstacleList
            // 
            this.txtObstacleList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObstacleList.Location = new System.Drawing.Point(88, 101);
            this.txtObstacleList.Multiline = true;
            this.txtObstacleList.Name = "txtObstacleList";
            this.txtObstacleList.ReadOnly = true;
            this.txtObstacleList.Size = new System.Drawing.Size(230, 73);
            this.txtObstacleList.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 23);
            this.label10.TabIndex = 16;
            this.label10.Text = "Obstacles:";
            // 
            // numRoverY
            // 
            this.numRoverY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numRoverY.Location = new System.Drawing.Point(278, 194);
            this.numRoverY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRoverY.Name = "numRoverY";
            this.numRoverY.Size = new System.Drawing.Size(40, 20);
            this.numRoverY.TabIndex = 15;
            this.numRoverY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(255, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Y";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(167, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 23);
            this.label9.TabIndex = 13;
            this.label9.Text = "X";
            // 
            // numRoverX
            // 
            this.numRoverX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numRoverX.Location = new System.Drawing.Point(190, 194);
            this.numRoverX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRoverX.Name = "numRoverX";
            this.numRoverX.Size = new System.Drawing.Size(40, 20);
            this.numRoverX.TabIndex = 12;
            this.numRoverX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 33);
            this.label7.TabIndex = 11;
            this.label7.Text = "Rover coordinates and direction:";
            // 
            // btnAddObstacle
            // 
            this.btnAddObstacle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddObstacle.ForeColor = System.Drawing.Color.Black;
            this.btnAddObstacle.Location = new System.Drawing.Point(347, 65);
            this.btnAddObstacle.Name = "btnAddObstacle";
            this.btnAddObstacle.Size = new System.Drawing.Size(93, 23);
            this.btnAddObstacle.TabIndex = 10;
            this.btnAddObstacle.Text = "Add obstacle";
            this.btnAddObstacle.UseVisualStyleBackColor = true;
            this.btnAddObstacle.Click += new System.EventHandler(this.btnAddObstacle_Click);
            // 
            // numObstacleY
            // 
            this.numObstacleY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numObstacleY.Location = new System.Drawing.Point(278, 65);
            this.numObstacleY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numObstacleY.Name = "numObstacleY";
            this.numObstacleY.Size = new System.Drawing.Size(40, 20);
            this.numObstacleY.TabIndex = 9;
            this.numObstacleY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(255, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Y";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(167, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "X";
            // 
            // numObstacleX
            // 
            this.numObstacleX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numObstacleX.Location = new System.Drawing.Point(190, 65);
            this.numObstacleX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numObstacleX.Name = "numObstacleX";
            this.numObstacleX.Size = new System.Drawing.Size(40, 20);
            this.numObstacleX.TabIndex = 6;
            this.numObstacleX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Obstacle coordinates:";
            // 
            // numMarsGridY
            // 
            this.numMarsGridY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMarsGridY.Location = new System.Drawing.Point(278, 34);
            this.numMarsGridY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMarsGridY.Name = "numMarsGridY";
            this.numMarsGridY.Size = new System.Drawing.Size(40, 20);
            this.numMarsGridY.TabIndex = 4;
            this.numMarsGridY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(255, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Y";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "X";
            // 
            // numMarsGridX
            // 
            this.numMarsGridX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMarsGridX.Location = new System.Drawing.Point(190, 34);
            this.numMarsGridX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMarsGridX.Name = "numMarsGridX";
            this.numMarsGridX.Size = new System.Drawing.Size(40, 20);
            this.numMarsGridX.TabIndex = 1;
            this.numMarsGridX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mars grid max coordinates:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnSendCommands);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.txtRoverStatus);
            this.groupBox2.Controls.Add(this.txtCommands);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(13, 410);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(469, 178);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Move and turn the rover";
            // 
            // btnSendCommands
            // 
            this.btnSendCommands.Enabled = false;
            this.btnSendCommands.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendCommands.ForeColor = System.Drawing.Color.Black;
            this.btnSendCommands.Location = new System.Drawing.Point(258, 101);
            this.btnSendCommands.Name = "btnSendCommands";
            this.btnSendCommands.Size = new System.Drawing.Size(192, 23);
            this.btnSendCommands.TabIndex = 20;
            this.btnSendCommands.Text = "Send commands to rover";
            this.btnSendCommands.UseVisualStyleBackColor = true;
            this.btnSendCommands.Click += new System.EventHandler(this.btnSendCommands_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(11, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(149, 125);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // txtRoverStatus
            // 
            this.txtRoverStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoverStatus.Location = new System.Drawing.Point(258, 134);
            this.txtRoverStatus.Multiline = true;
            this.txtRoverStatus.Name = "txtRoverStatus";
            this.txtRoverStatus.ReadOnly = true;
            this.txtRoverStatus.Size = new System.Drawing.Size(192, 23);
            this.txtRoverStatus.TabIndex = 0;
            // 
            // txtCommands
            // 
            this.txtCommands.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommands.Location = new System.Drawing.Point(258, 32);
            this.txtCommands.Multiline = true;
            this.txtCommands.Name = "txtCommands";
            this.txtCommands.Size = new System.Drawing.Size(192, 63);
            this.txtCommands.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(176, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 23);
            this.label11.TabIndex = 17;
            this.label11.Text = "Rover status:";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(178, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 60);
            this.label12.TabIndex = 19;
            this.label12.Text = "Commands:\r\n(F,B,L,R)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(469, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(495, 603);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mars Rover Kata";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRoverY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRoverX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numObstacleY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numObstacleX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMarsGridY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMarsGridX)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboRoverDirection;
        private System.Windows.Forms.Button btnSetupMarsAndRover;
        private System.Windows.Forms.Button btnResetObstacleList;
        private System.Windows.Forms.TextBox txtObstacleList;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numRoverY;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numRoverX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddObstacle;
        private System.Windows.Forms.NumericUpDown numObstacleY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numObstacleX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numMarsGridY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numMarsGridX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSendCommands;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCommands;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRoverStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

