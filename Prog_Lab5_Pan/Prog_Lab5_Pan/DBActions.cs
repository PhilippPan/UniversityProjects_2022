using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Prog_Lab5_Pan
{
    class DBActions
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\ph_study; Initial Catalog=ProgLabs; Integrated Security=true;");
        Encoding utf8 = Encoding.UTF8;

        public void openConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed) con.Open();
        }

        public void closeConnection()
        {
            if (con.State == System.Data.ConnectionState.Open) con.Close();
        }

        public DataTable getData()
        {
            try
            {
                openConnection();
                SqlCommand com = new SqlCommand();
                com.CommandText = "SELECT * FROM lab5_TempLog";
                com.Connection = con;
                SqlDataAdapter da = new SqlDataAdapter(com);

                DataTable data = new DataTable();
                da.Fill(data);
                closeConnection();
                return data;
            } 
            catch { return null; }
        }

        public DataTable getDataByDate(DateTime Sd, DateTime Ed)
        {
            try
            {
                openConnection();
                SqlCommand com = new SqlCommand();
                com.CommandText = $"SELECT * FROM lab5_TempLog WHERE Date BETWEEN @Sd AND @Ed";
                com.Connection = con;
                SqlParameter Sparameter = new SqlParameter("@Sd", Sd);
                com.Parameters.Add(Sparameter);
                SqlParameter Eparameter = new SqlParameter("@Ed", Ed);
                com.Parameters.Add(Eparameter);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable data = new DataTable();
                da.Fill(data);
                closeConnection();
                return data;
            }
            catch { return null; }
        }

        public int setData(int RN, int RT, int AT, string S, string DT)
        {
            try
            {
                openConnection();
                SqlCommand com = new SqlCommand();
                com.CommandText = $"INSERT INTO lab5_TempLog VALUES ('{RN}', '{RT}', '{AT}', N'{S}', '{DT}')";
                com.Connection = con;
                com.ExecuteNonQuery();
                closeConnection();
                return 1;
            }
            catch { return 0; }
        }
    }
}
