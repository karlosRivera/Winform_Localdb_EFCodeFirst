using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFConnectLocalDB.Model;

namespace EFConnectLocalDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //<connectionStrings>
            //    <add name="TestDBContext" connectionString="Data Source=(LocalDb)\v11.0;AttachDbFilename=E:\Backup_100916\VS2013\EFTest\EFTest\DB\Sample.mdf;Integrated Security=True" providerName="System.Data.SqlClient" />
            //</connectionStrings>

            //AppDomain.CurrentDomain.SetData("DataDirectory", @"c:\users\tridip.bbakolkata\documents\visual studio 2013\Projects\EFTest\EFTest");


            //Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\AG.mdf;Database=AG;Integrated Security=True;User Instance=True;Trusted_Connection=Yes 


            AppDomain.CurrentDomain.SetData("DataDirectory", AppDomain.CurrentDomain.BaseDirectory + "App_Data");

            EmployeeDB db = new EmployeeDB();
            var data = db.Employees.ToList();

        }
    }
}
