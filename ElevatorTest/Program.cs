using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator e1 = new Elevator();
            e1.maxFloor = 15;
            e1.capacity = 20;
            e1.Run();

            while (true)
            {
                
            }
        }
    }
}
