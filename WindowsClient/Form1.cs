using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsClient.ServiceReference4;

namespace WindowsClient
{
    public partial class Form1 : Form
    {
        private ServiceReference4.WebService1SoapClient webService;

        public Form1()
        {
         
        webService = new ServiceReference4.WebService1SoapClient();

        InitializeComponent();
        }


        private void radioButtonBuildings_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if(radioButtonBuildings.Checked)
            {
                Building[] buildings = webService.ShowBuildings();
                dataGridOffices.DataSource = buildings;
            }

            else if (radioButtonOffices.Checked)
            {
                Office[] offices = webService.ShowOffices();
                dataGridOffices.DataSource = offices;
            }
        }
    }
}
