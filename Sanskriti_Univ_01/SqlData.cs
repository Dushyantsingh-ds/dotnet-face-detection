using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data.Sql;

using System.Configuration;

public static class SqlData
{

    public static SqlConnection Conn;
    public static string ConnStr;

    public static void CreateConnection()
    {
        ConnStr = "Data Source=DESKTOP-OO4P3SV;Initial Catalog=FaceDetection_net;User Id=sa;Password=abc123";
        Conn = new SqlConnection(ConnStr);
    }


    public static DataTable LogTab(string UserName, string Password)
    {

        CreateConnection();
        Conn.Open();
        string sqlQurey = string.Format("Select CID, MUName, MUMobile, MUEmail, MURole, MUPassword, MUCity,MUCountry,MULastLoginTime from Authentication_A where MUName={0} and MUPassword={1}", "'" + UserName + "'", "'" + Password + "'");

        SqlDataAdapter SqlCmd = new SqlDataAdapter(sqlQurey, Conn);
        DataTable dt = new DataTable();
        SqlCmd.Fill(dt);
        Conn.Close();
        return (dt);


    }

        public static void UpdateDG(string updatee)
    {
        int retrun_value = 0;
        CreateConnection();
        string query = "UPDATE UserRecor set EventAttend = 'Attended', EventAttendDateTime = @EventAttendDateTime_) where UserName = @updatee";
        Conn.Open();
        SqlCommand command = new SqlCommand(query, Conn);

        try
        {
            command.Parameters.Add("@updatee", updatee);
            command.Parameters.Add("@EventAttendDateTime_", DateTime.Now);
            command.ExecuteNonQuery();
        }
        catch (SqlException se)
        {
            
        }
        finally
        {

            Conn.Close();
        }
    }


    public static void insertvalues(string UserName, string Role, string City, string mobile, string status)
    {
        int retrun_value = 0;
        CreateConnection();
        string query = "INSERT INTO UserRecord(UserName, UserRole, UserCity, UserMobile, EventAttend, BookingDateTime) " +
            "VALUES(@UserName_, @UserRole_,@UserCity_,@UserMobile_,@EventAttend_, @BookingDateTime_)";
        Conn.Open();
        SqlCommand command = new SqlCommand(query, Conn);

        try
        {
            command.Parameters.Add("@UserName_", UserName);
            command.Parameters.Add("@UserRole_", Role);
            command.Parameters.Add("@UserCity_", City);
            command.Parameters.Add("@UserMobile_", mobile);
            command.Parameters.Add("@EventAttend_", status);
            command.Parameters.Add("@BookingDateTime_", DateTime.Now);

            command.ExecuteNonQuery();

        }
        catch (SqlException se)
        {
            
        }
        finally
        {

            Conn.Close();
        }
    }
public static int Publish_release(string serialnumber_txt, string category_txt, string model_txt, string mfd_txt, string refferdate_txt, string vendorname_txt, string city_txt, string status_txt, string replacedto_txt, string endofsession_txt, string description_txt)
    {
        int retrun_value = 0;
        CreateConnection();
        string query = "INSERT INTO Publish_Release (SerialNumber,Category,Model,MFD,RefferDate,VendorName,City,Status,ReplacedTo,EndofSession,Description) VALUES(@SerialNuumber,@Category,@Model,@MFD,@RefferDate,@VendorName,@City,@Status,@ReplacedTo,@EndofSession,@Description)";
        Conn.Open();
        SqlCommand command = new SqlCommand(query, Conn);

        try
        {
            command.Parameters.Add("@SerialNuumber", serialnumber_txt);
            command.Parameters.Add("@Category", category_txt);
            command.Parameters.Add("@Model", model_txt);
            command.Parameters.Add("@MFD", mfd_txt);
            command.Parameters.Add("@RefferDate", refferdate_txt);
            command.Parameters.Add("@VendorName", vendorname_txt);
            command.Parameters.Add("@City", city_txt);
            command.Parameters.Add("@Status", status_txt);
            command.Parameters.Add("@ReplacedTo", replacedto_txt);
            command.Parameters.Add("@EndofSession", endofsession_txt);
            command.Parameters.Add("@Description", description_txt);


            command.ExecuteNonQuery();
            return retrun_value = 1;

        }
        catch (SqlException se)
        {
            return retrun_value = 0;
            string eroor = Convert.ToString(se);

        }
        finally
        {

            Conn.Close();
        }
    }

    public static string Page_Load(int Id)
    {
        CreateConnection();
        Conn.Open();

        string sql = string.Format("SELECT Photo FROM LogTab WHERE Id ={0}", Id);
        SqlDataAdapter sda = new SqlDataAdapter(sql, Conn);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        Conn.Close();

        string imageUrl = "data:image/jpg;base64," + Convert.ToBase64String((byte[])dt.Rows[0]["Photo"]);

        return imageUrl;


    }

    public static DataTable ContactDT(int UserId)
    {

        CreateConnection();
        string sqlQurey = string.Format("Select * from ContactTab where UserId={0}", "" + UserId + "");
        SqlDataAdapter sda = new SqlDataAdapter(sqlQurey, Conn);
        DataTable dt = new DataTable();
        try
        {
            Conn.Open();
            sda.Fill(dt);
        }
        catch (SqlException se)
        {
            string eroor = Convert.ToString(se);
        }

        Conn.Close();
        return dt;


    }

    public static DataTable getDataconfirm()
    {

        CreateConnection();
        string SqlString = "Select * from Admintble where slist='true'";
        SqlDataAdapter sda = new SqlDataAdapter(SqlString, Conn);
        DataTable dt = new DataTable();
        try
        {
            Conn.Open();
            sda.Fill(dt);
        }
        catch (SqlException se)
        {
            string eroor = Convert.ToString(se);
        }
        finally
        {
            Conn.Close();
        }
        return dt;
    }
    public static DataTable qureypass(string SqlString)
    {

        CreateConnection();

        SqlDataAdapter sda = new SqlDataAdapter(SqlString, Conn);
        DataTable dt = new DataTable();
        try
        {
            Conn.Open();
            sda.Fill(dt);
        }
        catch (SqlException se)
        {
            string eroor = Convert.ToString(se);

        }
        finally
        {
            Conn.Close();
        }
        return dt;
    }

    public static DataTable GetData_0()
    {
        ConnStr = "Data Source=DESKTOP-OO4P3SV;Initial Catalog=FaceDetection_net;User Id=sa;Password=abc123";
     
        string UserName_;
        DataTable dt = new DataTable();

        using (SqlConnection con = new SqlConnection(ConnStr))
        {
            SqlCommand cmd = new SqlCommand("select distinct(UserName) From UserRecord");
            SqlDataAdapter sda = new SqlDataAdapter();

            cmd.Connection = con;
            sda.SelectCommand = cmd;

            sda.Fill(dt);
        }

        int columnIndex = 0; //single-column DataTable
        string[] userArr = new string[dt.Rows.Count];
        int i, k = 0;
        for (i = 0; i < dt.Rows.Count; i++)
        {
            userArr[i] = dt.Rows[i][columnIndex].ToString();
            k++;

        }
        DataTable dt_2 = new DataTable();
        for (i = 0; i < k; i++)
        {

            using (SqlConnection con = new SqlConnection(ConnStr))
            {
                using (SqlCommand cmd = new SqlCommand("select UserName,UserCity,UserMobile,UserRole,UserMobile,EventAttend,BookingDateTime,EventAttendDateTime from UserRecord where UserName=@UserName_"))
                {
                    cmd.Parameters.AddWithValue("@UserName_", userArr[i]);
                    SqlDataAdapter sda = new SqlDataAdapter();
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(dt_2);


                }
            }

        }
       return dt_2;
    }
    public static DataTable Release_DataTable()
    {
        DataTable DataTable_Release = new DataTable();
        CreateConnection();
        string sqlCon = Convert.ToString(SqlData.Conn);
        Conn.Open();
        SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT UserName as Name,UserRole as Role,UserCity as City,UserMobile as Mobile,EventAttend as Event_Attend,BookingDateTime,EventAttendDateTime FROM UserRecord", Conn);
        sqlDa.Fill(DataTable_Release);
        SqlData.Conn.Close();
        return DataTable_Release;
        DataTable DataTable_DataGrid = new DataTable();
        if (DataTable_Release.Rows.Count > 0)
        {
            return DataTable_Release;
        }

    }

}