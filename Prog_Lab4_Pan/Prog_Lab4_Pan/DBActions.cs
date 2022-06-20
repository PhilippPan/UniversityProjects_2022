using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Prog_Lab4_Pan
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

        
        public DataSet getAllData()
        {
            openConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM lab4_ItemsTable";
            command.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(command);

            DataSet data = new DataSet();
            DataTable dt1 = data.Tables.Add();
            DataTable dt2 = data.Tables.Add();
            da.Fill(data.Tables[0]);

            command.CommandText = "SELECT * FROM lab4_ProvidersTable";
            da = new SqlDataAdapter(command);
            da.Fill(data.Tables[1]);
            
            closeConnection();
            return data;
        }

        public DataTable getPoviderID(string ColName, string TableName)
        {
            openConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = $"SELECT {ColName} FROM {TableName}";
            command.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            closeConnection();
            da.Fill(data);
            return data;
        }

        public string getDataByID(string ID, string TableName, string ColName, string IDColName)
        {
            try
            {
                openConnection();
                SqlCommand command = new SqlCommand();
                command.CommandText = $"SELECT {ColName} FROM {TableName} WHERE {IDColName} = '{ID}'";
                command.Connection = con;
                SqlDataAdapter da = new SqlDataAdapter(command);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                string res = reader.GetValue(0).ToString();
                reader.Close();
                closeConnection();
                return res;
            }
            catch (Exception e) { return $"error: {e}"; }
        }

        public DateTime getDatetimeByID(int ID, string TableName, string ColName)
        {
            try
            {
                openConnection();
                SqlCommand command = new SqlCommand();
                command.CommandText = $"SELECT {ColName} FROM {TableName} WHERE ID_Item = '{ID}'";
                command.Connection = con;
                SqlDataAdapter da = new SqlDataAdapter(command);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                DateTime res = (DateTime)reader.GetValue(0);
                reader.Close();
                closeConnection();
                return res;
            }
            catch { return DateTime.Now; }
        }

        public string editDataInTable1(int ID, string TableName, string IN, string IC, int PI, DateTime SD, int SA, int SC, int SN)
        {
            try
            {
                openConnection();
                SqlCommand command = new SqlCommand();
                command.CommandText = $"UPDATE {TableName} SET " +
                    $"ItemName =        '{IN}',  " +
                    $"ItemCode =        '{IC}',  " +
                    $"ProviderID =      {PI},  " +
                    $"SupplyDate =      '{SD}',  " +
                    $"SupplyAmount =    {SA},  " +
                    $"SupplyCost =      {SC},  " +
                    $"StorageNumber =   {SN}  " +
                    $"WHERE ID_Item =  '{ID}'";
                command.Connection = con;
                command.ExecuteNonQuery();
                closeConnection();
                return "Данные успешно обновлены!";
            }
            catch { return "Произошла ошибка при обновлении данных"; }
        }

        public string editDataInTable2(int ID, string TableName, string PN, long PH)
        {
            try
            {
                openConnection();
                SqlCommand command = new SqlCommand();
                command.CommandText = $"UPDATE {TableName} SET " +
                    $"ProviderName =        '{PN}',  " +
                    $"PhoneNumber =        {PH}  " +
                    $"WHERE ID_Provider =  '{ID}'";
                command.Connection = con;
                command.ExecuteNonQuery();
                closeConnection();
                return "Данные успешно обновлены!";
            }
            catch { return "Произошла ошибка при обновлении данных"; }
        }

        // Q2
        public DataTable getDataSetByID(string What, string TableName, string IDCol, string ID)
        {
            
            openConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = $"SELECT {What} FROM {TableName} WHERE {IDCol} = '{ID}'";
            command.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            da.Fill(data);
            closeConnection();
            return data;
        }

        // Q4
        public string editItemCode(string TableName, string ID, string IC)
        {
            try
            {
                openConnection();
                SqlCommand command = new SqlCommand();
                command.CommandText = $"UPDATE {TableName} SET ItemCode = '{IC}' WHERE ItemName =  '{ID}'";
                command.Connection = con;
                command.ExecuteNonQuery();
                closeConnection();
                return "Данные успешно обновлены!";
            }
            catch { return "Произошла ошибка при обновлении данных"; }
        }

        // Q1
        public DataTable getDataSetFromDateTime(DateTime Sd, DateTime Ed, string SN)
        {
            
            openConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = $"SELECT * FROM lab4_ItemsTable WHERE (SupplyDate BETWEEN @Sd AND @Ed) AND (StorageNumber = '{SN}')";
            command.Connection = con;
            SqlParameter Sparameter = new SqlParameter("@Sd", Sd);
            command.Parameters.Add(Sparameter);
            SqlParameter Eparameter = new SqlParameter("@Ed", Ed);
            command.Parameters.Add(Eparameter);

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            da.Fill(data);
            closeConnection();
            return data;
        }
    }
}
