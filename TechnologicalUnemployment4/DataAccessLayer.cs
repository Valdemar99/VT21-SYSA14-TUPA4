using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TechnologicalUnemployment4
{
    public class DataAccessLayer

    {
      
        private string connectionString = "Server=localhost;Database=Smart Office 2.0;User Id=user2.0;Password =losen";

        public List<Building> GetBuildings()
        {

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM BUILDING", sqlConnection))
                {
                    sqlConnection.Open();
                    SqlDataReader dataReader = sqlCommand.ExecuteReader();
                    List<Building> buildingList = new List<Building>();
                    while (dataReader.Read())
                    {
                        Building building = new Building();
                        building.Address = (string)dataReader["address"];
                        buildingList.Add(building);
                    }

                    return buildingList;
                }
            }
        }

            public List<Office> GetOffices()
            {

                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Office", sqlConnection))
                    {
                        sqlConnection.Open();
                        SqlDataReader dataReader = sqlCommand.ExecuteReader();
                        List<Office> officeList = new List<Office>();
                        while (dataReader.Read())
                        {
                            Office office = new Office();
                            office.BuildingAddress = (string)dataReader["BuildingAddress"];
                            office.OfficeNumber = (string)dataReader["OfficeNumber"];
                            office.TemperatureSetting = (int)dataReader["TemperatureSetting"];
                            office.VentilationSetting = (string)dataReader["VentilationSetting"];
                            officeList.Add(office);
                        }

                        return officeList;
                    }
                }


            }

    }
}