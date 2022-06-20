using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Prog_Practos4_Pan
{
    public partial class MainForm : Form
    {
        DBConnect DB = new DBConnect();
        public MainForm()
        {
            InitializeComponent();
            DB.openConnection();
            Encoding utf8 = Encoding.UTF8;
            ChooseSource(cmbSource.Text);
            UpdateCmb();
            //dgTable.AutoGenerateColumns = false;
        }

        public int ChooseSource(string TN)
        {
            switch (TN)
            {
                case "Таблица 1": return 1;
                case "Таблица 2": return 2;
                default: return 1;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string a = DB.AddDataToDB(txtBookAdd.Text, txtAuthorAdd.Text, int.Parse(txtStoreAdd.Text), ChooseSource(cmbSource.Text));
            MessageBox.Show(a);
            UpdateTable();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string a = DB.EditDataInDB(cmbBookEdit.Text, int.Parse(txtStoreEdit.Text), ChooseSource(cmbSource.Text));
            MessageBox.Show(a);
            UpdateTable();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string a = DB.DeleteDataInDB(cmbBookDel.Text, ChooseSource(cmbSource.Text));
            MessageBox.Show(a);
            UpdateTable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateTable();
        }
        private void UpdateTable()
        {
            string TableName;
            if (ChooseSource(cmbSource.Text) == 1) TableName = "pr4_Library";
            else TableName = "pr4_Library_2";
            string conS = @"Data Source=(localdb)\ph_study; Initial Catalog=ProgLabs; Integrated Security=true;";
            SqlConnection sqlConn = new SqlConnection(conS);
            sqlConn.Open();
            SqlDataAdapter da = new SqlDataAdapter($"SELECT BookName, AuthorName, AvailableInStorage FROM {TableName}", sqlConn);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds, TableName);
            dgTable.DataSource = ds.Tables[0];
            sqlConn.Close();
            UpdateCmb();
        }
        private void UpdateCmb()
        {
            string TableName;
            if (ChooseSource(cmbSource.Text) == 1) TableName = "pr4_Library";
            else TableName = "pr4_Library_2";
            string conS = @"Data Source=(localdb)\ph_study; Initial Catalog=ProgLabs; Integrated Security=true;";
            SqlConnection sqlConn = new SqlConnection(conS);
            sqlConn.Open();
            SqlDataAdapter da = new SqlDataAdapter($"SELECT BookName FROM {TableName}", sqlConn);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds, TableName);
            cmbBookDel.DataSource = ds.Tables[0];
            cmbBookEdit.DataSource = ds.Tables[0];
            sqlConn.Close();
        }
        private void btnChoose_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }
    }
}
