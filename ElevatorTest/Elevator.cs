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
        public int currentLoad;
        bool runDirection;

        Timer elevatorRunTimer = new Timer();

        public List<People> peoples;

        public List<People> currentPeople;

        public Elevator()
        {
            currentFloor = 0;
            runDirection = true;

            peoples = new List<People>();
            currentPeople = new List<People>();
        }

        public void Run()
        {
            //elevatorRunTimer.Interval = 1000;
            //elevatorRunTimer.Enabled = true;
            //elevatorRunTimer.AutoReset = true;
            //elevatorRunTimer.Elapsed += elevatorRunTimer_Elapsed;

            for (int i = 0; i < 100; i++)
            {
                PickUpPeople();
            }
        }

        private void PickUpPeople()
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

            int count = currentPeople.Count - 1;
            for (int i = count; i >=0 ; i--)
            {
                People p = currentPeople[i];
                if (p.goFloor == currentFloor)
                {
                    currentPeople.Remove(p);
                    capacity++;
                    Utils.WriteMsg("People:" + p.id + " is off board");
                }
            }

            count = peoples.Count - 1;
            for (int i = count; i >= 0; i--)
            {
                People p = peoples[i];

                if (capacity <= 0)
                {
                    break;
                }
                if (p.currentFloor == currentFloor && ( (p.goFloor > p.currentFloor && runDirection) ||
                                                        (p.goFloor < p.currentFloor && !runDirection) 
                                                       )
                    )
                {
                    currentPeople.Add(p);
                    peoples.Remove(p);
                    capacity--;
                    Utils.WriteMsg("People:" + p.id + " is on board");
                }
            }
        }

        private void elevatorRunTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            PickUpPeople();
        }
    }
}
