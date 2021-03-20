using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Data.SqlClient;
using System.Data.Sql;

namespace Sanskriti_Univ_01
{
    public partial class AddNew_UC : UserControl
    {

        
        public AddNew_UC()
        {

            InitializeComponent();
            try
            {
                SqlData.CreateConnection();
                DataTable dts = new DataTable();
                dataGridView1.DataSource = dts;
                dataGridView1.DataSource = SqlData.GetData_0();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error Found");
            } 
                        

        }

        private void AddNew_btn_Click(object sender, EventArgs e)
        {
            AddNew AddNew_Ob1 = new AddNew();
            AddNew_Ob1.Show();
        }

        private void AddNew_UC_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlData.CreateConnection();
            DataTable dts = new DataTable();
            dataGridView1.DataSource = dts;
            dataGridView1.DataSource = SqlData.GetData_0();
        }
    }
}
