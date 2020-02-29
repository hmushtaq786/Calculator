using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car carObj = new Car();
            carObj.CarMake = "Honda";
            carObj.CarModel = "Civic";
            carObj.CarModelYear = 2019;
            carObj.CarEnginePower = 1600;

            Console.WriteLine("My Favourite car is "+carObj.CarMake+", "+carObj.CarModel+ ", "+carObj.CarModelYear+", "+carObj.CarEnginePower );
            int i = 0;
        }
    }
}
