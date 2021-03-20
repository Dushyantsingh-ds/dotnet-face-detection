using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sanskriti_Univ_01
{
    class DBcon
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataSet ds; int rno = 0;
        MemoryStream ms;
        byte[] photo_aray;

        private void CreateConnection()
        {
            con = new SqlConnection("user id=sa;password=123;database=prash");
            loaddata();
            showdata();
        }
        void loaddata()
        {
            adapter = new SqlDataAdapter("select sno,sname,course,fee,photo from student", con);
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            ds = new DataSet(); adapter.Fill(ds, "student");
        }
        void showdata()
        {
            if (ds.Tables[0].Rows.Count > 0)
            {
                textBox1.Text = ds.Tables[0].Rows[rno][0].ToString();
                textBox2.Text = ds.Tables[0].Rows[rno][1].ToString();
                textBox3.Text = ds.Tables[0].Rows[rno][2].ToString();
                textBox4.Text = ds.Tables[0].Rows[rno][3].ToString();
                pictureBox1.Image = null;
                if (ds.Tables[0].Rows[rno][4] != System.DBNull.Value)
                {
                    photo_aray = (byte[])ds.Tables[0].Rows[rno][4];
                    MemoryStream ms = new MemoryStream(photo_aray);
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
            else
                MessageBox.Show("No Records");
        }


    }
}
