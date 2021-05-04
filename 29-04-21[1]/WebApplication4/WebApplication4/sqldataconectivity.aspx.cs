using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication4
{
    public partial class sqldataconectivity : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataReader dr;
            SqlConnection connection;
            string query;
            SqlCommand sqlcommand;
            connection = new SqlConnection("Data Source=LAPTOP-E0NVL0L7\\SQLEXPRESS;Initial Catalog=Craftsman;Integrated Security=True");
            query = "select positionname from position";
            sqlcommand = new SqlCommand(query, connection);
            connection.Open();
            dr = sqlcommand.ExecuteReader();
            while(dr.Read())
            {
                DropDownList1.Items.Add(dr["positionname"].ToString());
            }
            dr.Close();
            connection.Close();


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection;
            string query;
            SqlCommand sqlcommand;
            connection = new SqlConnection("Data Source=LAPTOP-E0NVL0L7\\SQLEXPRESS;Initial Catalog=Craftsman;Integrated Security=True");
            query = "insert into Position(Positionid,Positionname) values(@a,@b)";
             sqlcommand = new SqlCommand(query, connection);
            sqlcommand.Parameters.AddWithValue("@a", txtpid.Text);
            sqlcommand.Parameters.AddWithValue("@b", txtpname.Text);
            connection.Open();
            sqlcommand.ExecuteNonQuery();
            connection.Close();


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection;
            string query;
            SqlCommand sqlcommand;
            connection = new SqlConnection("Data Source=LAPTOP-E0NVL0L7\\SQLEXPRESS;Initial Catalog=Craftsman;Integrated Security=True");
            query = "update  Position set positionname=@b where positionid=@a";
            sqlcommand = new SqlCommand(query, connection);
            sqlcommand.Parameters.AddWithValue("@a", txtpid.Text);
            sqlcommand.Parameters.AddWithValue("@b", txtpname.Text);
            connection.Open();
            sqlcommand.ExecuteNonQuery();
            connection.Close();

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection connection;
            string query;
            SqlCommand sqlcommand;
            connection = new SqlConnection("Data Source=LAPTOP-E0NVL0L7\\SQLEXPRESS;Initial Catalog=Craftsman;Integrated Security=True");
            query = "delete from position where positionid=@a";
            sqlcommand = new SqlCommand(query, connection);
            sqlcommand.Parameters.AddWithValue("@a", txtpid.Text);
           
            connection.Open();
            sqlcommand.ExecuteNonQuery();
            connection.Close();

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            SqlConnection connection;
            
            SqlCommand cmdcount;
            connection = new SqlConnection("Data Source=LAPTOP-E0NVL0L7\\SQLEXPRESS;Initial Catalog=Craftsman;Integrated Security=True");
             cmdcount = new SqlCommand("getCount3", connection);
            
            connection.Open();
            int c=Convert.ToInt32(cmdcount.ExecuteScalar());
            //intcount = Convert.ToInt32(cmdcount.Parameters["returnvalue"].Value);
            Response.Write(c);


        }
    }
}