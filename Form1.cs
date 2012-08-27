using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace DatabaseDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string cs = GetConnectionString();

            //need to upgrade to sql engine v4.0?
            if (!IsV40Installed())
            {
                SqlCeEngine engine = new SqlCeEngine(cs);
                engine.Upgrade();
            }

            //open connection
            SqlCeConnection sc = new SqlCeConnection(cs);

            //query customers
            string sql = "SELECT * FROM Customers";
            SqlCeCommand cmd = new SqlCeCommand(sql, sc);

            //create grid
            SqlCeDataAdapter sda = new SqlCeDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

            //close connection
            sc.Close();
        }

        //typical northwind sample db path
        static private string GetConnectionString()
        {
            return "Data Source=C:\\Program Files (x86)\\Microsoft SQL Server Compact Edition\\v4.0\\Samples\\Northwind.sdf;";
        }

        //from http://stackoverflow.com/questions/7089709/mssqlce-version-detection-upgrade
        internal static bool IsV40Installed()
        {
            try
            {
                System.Reflection.Assembly.Load("System.Data.SqlServerCe, Version=4.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91");
            }
            catch (System.IO.FileNotFoundException)
            {
                return false;
            }
            return true;
        }
    }
}