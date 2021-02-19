using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TechnologicalUnemployment4
{
    public class Office
    {
        private string officeNumber;
        private string buildingAddress;
        private string ventilationSetting;
        private int temperatureSetting;

        public string OfficeNumber { get => officeNumber; set => officeNumber = value; }
        public string BuildingAddress { get => buildingAddress; set => buildingAddress = value; }
        public string VentilationSetting { get => ventilationSetting; set => ventilationSetting = value; }
        public int TemperatureSetting { get => temperatureSetting; set => temperatureSetting = value; }
   
        
    }
}