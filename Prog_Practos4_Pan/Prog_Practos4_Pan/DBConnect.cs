using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Prog_Practos4_Pan
{
    class DBConnect
    {
        SqlConnection Sql = new SqlConnection(@"Data Source=(localdb)\ph_study; Initial Catalog=ProgLabs; Integrated Security=true;");
        Encoding utf8 = Encoding.UTF8;
        string TableName;

        public void openConnection()
        {
            if (Sql.State == System.Data.ConnectionState.Closed) Sql.Open();
        }

        public void closeConnection()
        {
            if (Sql.State == System.Data.ConnectionState.Open) Sql.Close();
        }

        public SqlConnection GetSqlConnection()
        {
            return Sql;
        }

        public string AddDataToDB(string BN, string AN, int AS, int TN)
        {
            try
            {
                if (TN == 1) TableName = "pr4_Library";
                else TableName = "pr4_Library_2";

                SqlCommand com = new SqlCommand();
                com.CommandType = System.Data.CommandType.Text;
                com.CommandText = $@"INSERT INTO  {TableName} VALUES (N'{BN}', N'{AN}', {AS})";
                com.Connection = Sql;
                openConnection();
                com.ExecuteNonQuery();
                closeConnection();
                return "Row was added";
            } catch { return "Error"; }
        }

        public string EditDataInDB(string BN, int AS, int TN)
        {
            try
            {
                if (TN == 1) TableName = "pr4_Library";
                else TableName = "pr4_Library_2";

                SqlCommand com = new SqlCommand();
                com.CommandType = System.Data.CommandType.Text;
                com.CommandText = $"UPDATE {TableName} SET AvailableInStorage = {AS} WHERE BookName = '{BN}'";
                com.Connection = Sql;
                openConnection();
                com.ExecuteNonQuery();
                closeConnection();
                return "Row was edited";
            } catch { return "Error"; }
        }

        public string DeleteDataInDB(string BN, int TN)
        {
            try
            {
                if (TN == 1) TableName = "pr4_Library";
                else TableName = "pr4_Library_2";

                SqlCommand com = new SqlCommand();
                com.CommandType = System.Data.CommandType.Text;
                com.CommandText = $"DELETE FROM {TableName} WHERE BookName = '{BN}'";
                com.Connection = Sql;
                openConnection();
                com.ExecuteNonQuery();
                closeConnection();
                return "Row was deleted";
            }
            catch { return "Error"; }
        }

        /*public DataSet1 GetDataFromDB(int TN)
        {
            if (TN == 1) TableName = "pr4_Library";
            else TableName = "pr4_Library_2";

            openConnection();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM InventoryTable", Sql);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds, "InventoryTable");
            InventDataGrid.DataSource = ds.Tables[0];

            DataSet1 data = new DataSet1();
            
            closeConnection();
            return data;
        }*/
    }
}
