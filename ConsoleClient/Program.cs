using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            WebService1 webService1 = new WebService1();
            Building[] buildingList = webService1.ShowBuildings();
            foreach (Building tmpBuilding in buildingList)
            {
                Console.WriteLine(tmpBuilding.Address);
                

            }

            Office[] officeList = webService1.ShowOffices();
            foreach (Office tmpOffice in officeList)
             
            {
                    
             Console.WriteLine(tmpOffice.BuildingAddress + "\t" + tmpOffice.OfficeNumber + "\t" + tmpOffice.TemperatureSetting + "\t" + tmpOffice.VentilationSetting);
                

             }


            //  Console.WriteLine(webService1.ShowOffices());
                  Console.ReadLine();
                }


            }
        }

