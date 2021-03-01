using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            WebService1 webService1 = new WebService1();
            Building[] buildingList = new Building[0];
            Office[] officeList = new Office[0];
            try
            {
                buildingList = webService1.ShowBuildings();
                officeList = webService1.ShowOffices();

                Console.WriteLine("Buildings:");
                foreach (Building tmpBuilding in buildingList)
                {
                    Console.WriteLine(tmpBuilding.Address);
                }
                Console.WriteLine("Offices:");
                foreach (Office tmpOffice in officeList)
                {
                    Console.WriteLine(tmpOffice.BuildingAddress + "\t" + tmpOffice.OfficeNumber + "\t" + tmpOffice.TemperatureSetting + "\t" + tmpOffice.VentilationSetting);
                }

            }
            catch (WebException)
            {
                Console.WriteLine("Please check your connection and try again.");
            }
            Console.ReadLine();
        }
    }
}

