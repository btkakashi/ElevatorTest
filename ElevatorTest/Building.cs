using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ElevatorTest
{
    public partial class Building : Form
    {
        int currentFloor;
        int maxFloor;
        bool runDirection;

        Panel lastFloor;

        public Building()
        {
            InitializeComponent();

            currentFloor = 1;
            maxFloor = 5;
            runDirection = true;

            this.elevatorRunTimer.Tick += new EventHandler(elevatorRunTimer_Tick);
            this.elevatorRunTimer.Enabled = false;

            lastFloor = this.plBuilding.Controls.Find("panel" + currentFloor, false)[0] as Panel;
            lastFloor.BackColor = Color.Green;

            this.btnStart.Visible = true;
            this.btnStop.Visible = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.elevatorRunTimer.Enabled = true;
            this.btnStart.Visible = false;
            this.btnStop.Visible = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.elevatorRunTimer.Enabled = false;
            this.btnStart.Visible = true;
            this.btnStop.Visible = false;
        }

        public void elevatorRunTimer_Tick(object sender, EventArgs e) 
        {
            if (currentFloor == maxFloor)
            {
                runDirection = false;
            }
            else if (currentFloor == 1)
            {
                runDirection = true;
            }

            if (runDirection)
            {
                currentFloor++;
            }
            else
            {
                currentFloor--;
            }

            lastFloor.BackColor = Color.White;

            Panel p = this.plBuilding.Controls.Find("panel" + currentFloor, false)[0] as Panel;
            p.BackColor = Color.Green;

            lastFloor = p;
        }


    }
}
