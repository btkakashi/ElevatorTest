using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace ElevatorTest
{
    class Elevator
    {
        int currentFloor;
        public int maxFloor;
        public int capacity;
        bool runDirection;

        Timer elevatorRunTimer = new Timer();

        public Elevator()
        {
            currentFloor = 1;
            runDirection = true;
        }

        public void Run()
        {
            elevatorRunTimer.Interval = 1000;
            elevatorRunTimer.Enabled = true;
            elevatorRunTimer.AutoReset = true;
            elevatorRunTimer.Elapsed += elevatorRunTimer_Elapsed;
        }

        private void elevatorRunTimer_Elapsed(object sender, ElapsedEventArgs e)
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

            Utils.WriteMsg("Elevator is on floor:" + currentFloor);
        }
    }
}
