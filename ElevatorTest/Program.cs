using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevatorTest
{
    static class Program
    {
        //static void Main(string[] args)
        //{
        //    int maxFloor = 10;

        //    List<People> peoples = new List<People>();
        //    for (int i = 0; i < 10; i++)
        //    {

        //        Random ro = new Random(i);
        //        int currentFloor = ro.Next(1, maxFloor);
        //        int goFloor = ro.Next(1, maxFloor);
        //        while (goFloor == currentFloor)
        //        {
        //            goFloor = ro.Next(1, maxFloor);
        //        }

        //        People p1 = new People(maxFloor);
        //        p1.currentFloor = currentFloor;
        //        p1.goFloor = goFloor;
        //        p1.id = i;
        //        peoples.Add(p1);

        //        Utils.WriteMsg("People " + p1.id + " is on floor:" + p1.currentFloor + " and he go to floor:" + p1.goFloor);
        //    }

        //    Elevator e1 = new Elevator();
        //    e1.maxFloor = maxFloor;
        //    e1.capacity = 20;
        //    e1.peoples = peoples;
        //    e1.Run();

        //    Console.ReadLine(); 
        //}

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Building());
        }
    }
}
