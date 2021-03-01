using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace TechnologicalUnemployment4
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService

    {
        DataAccessLayer dal;
        public WebService1()

        {
            dal = new DataAccessLayer();

        }


        [WebMethod]
        public List<Building> ShowBuildings()
        {
            try
            {
                return dal.GetBuildings();
              
            }
            catch (WebException exe)
            {
                throw new SoapException("Please check your connection and try again.", SoapException.ClientFaultCode, exe);
            }
            catch (SqlException exe)
            {
                if (exe.ErrorCode == 0)
                {   //Connection issues
                    throw new SoapException("Database connection error, please contact support.", SoapException.ClientFaultCode, exe);
                }
                else
                {
                    throw new SoapException("Unknown error, please contact support.", SoapException.ClientFaultCode, exe);
                }
            }
            catch (Win32Exception winExe)
            {
                throw new SoapException("Database connection error, please contact support.", SoapException.ClientFaultCode, winExe);
            }
        }

        [WebMethod]
        public List<Office> ShowOffices()
        {
            List<Office> listOfOffices = new List<Office>();
            try
            {
                listOfOffices = dal.GetOffices();

            }
            catch (WebException exe)
            {
                throw new SoapException("Please check your connection and try again.", SoapException.ClientFaultCode, exe);
            }
            catch (SqlException exe)
            {
                if(exe.ErrorCode == 0)
                {	//Connection issues
                throw new SoapException("Database connection error, please contact support.", SoapException.ClientFaultCode, exe);
                }
                else
                {
                    throw new SoapException("Unknown error, please contact support.", SoapException.ClientFaultCode, exe);
                }
            }

            return listOfOffices;
        }


    }
}
    

