using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Data;
using System.Data.SqlClient;

namespace Quizapp
{
    class Class1
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-EPC3UFBV;Initial Catalog=master;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        SqlCommandBuilder cmdb;
        DataSet ds;

        public int add_data(string Username,string PRN,int Marks)
        {
            
            string str = "insert into Table_1 values('" + Username + "','" + PRN + "','" + Marks + "')";
            cmd = new SqlCommand(str, con);
            con.Open();
            int no = cmd.ExecuteNonQuery();
            con.Close();
            return (no);
          
        }
        
    }
}
