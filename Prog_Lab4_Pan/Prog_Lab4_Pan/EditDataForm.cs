using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Lab4_Pan
{
    public partial class EditDataForm : Form
    {
        DBActions DB = new DBActions();
        public EditDataForm(DataSet ds)
        {
            InitializeComponent();
            dgvTable1.DataSource = ds.Tables[0];
            dgvTable2.DataSource = ds.Tables[1];
            
            txtProviderID.DataSource =      DB.getPoviderID("ID_Provider", "lab4_ProvidersTable");
            txtProviderID.DisplayMember =   DB.getPoviderID("ID_Provider", "lab4_ProvidersTable").Columns[0].ToString();
            txtProviderID.ValueMember =     DB.getPoviderID("ID_Provider", "lab4_ProvidersTable").Columns[0].ToString();


        }

        private void btnUpdateT1_Click(object sender, EventArgs e)
        {
            int SelectedRow = dgvTable1.CurrentRow.Index;
            int chsnID = int.Parse(dgvTable1[0, SelectedRow].Value.ToString());
            string TableName = "lab4_ItemsTable";

            int userSA, userSC, userSN, userPI;
            bool check1 = int.TryParse(txtProviderID.Text, out userPI);
            bool check2 = int.TryParse(txtSupplyAmmount.Text, out userSA);
            bool check3 = int.TryParse(txtSupplyCost.Text, out userSC);
            bool check4 = int.TryParse(txtStorageNum.Text, out userSN);

            if (check1 && check2 && check3 && check4)
            {
                MessageBox.Show(DB.editDataInTable1(chsnID, TableName,
                    txtitemName.Text,
                    txtItemCode.Text,
                    userPI,
                    dtpSupplyDate.Value.Date,
                    userSA,
                    userSC,
                    userSN));
            }
            else MessageBox.Show("Вы ввели некорректные данные");
            dgvTable1.DataSource = DB.getAllData().Tables[0];
        }

        private void dgvTable1_SelectionChanged(object sender, EventArgs e)
        {
            int SelectedRow = dgvTable1.CurrentRow.Index;
            string chsnID = dgvTable1[0, SelectedRow].Value.ToString();// int.Parse(dgvTable1[0, SelectedRow].Value.ToString());
            string TableName = "lab4_ItemsTable";

            txtitemName.Text = DB.getDataByID(chsnID, TableName, "ItemName", "ID_Item");
            txtItemCode.Text = DB.getDataByID(chsnID, TableName, "ItemCode", "ID_Item");
            txtProviderID.Text = DB.getDataByID(chsnID, TableName, "ProviderID", "ID_Item");
            txtSupplyAmmount.Text = DB.getDataByID(chsnID, TableName, "SupplyAmount", "ID_Item");
            txtSupplyCost.Text = DB.getDataByID(chsnID, TableName, "SupplyCost", "ID_Item");
            txtStorageNum.Text = DB.getDataByID(chsnID, TableName, "StorageNumber", "ID_Item");
            dtpSupplyDate.Value = DB.getDatetimeByID(int.Parse(chsnID), TableName, "SupplyDate");
        }

        // Table 2
        private void btnUpdateT2_Click(object sender, EventArgs e)
        {
            int SelectedRow = dgvTable2.CurrentRow.Index;
            int chsnID = int.Parse(dgvTable2[0, SelectedRow].Value.ToString());
            string TableName = "lab4_ProvidersTable";

            bool check1 = long.TryParse(txtPhoneNumber.Text, out long userPhone);

            if (check1 && txtPhoneNumber.Text.Length >= 11)
            {
                MessageBox.Show(DB.editDataInTable2(chsnID, TableName, txtProviderName.Text, userPhone));
            }
            else MessageBox.Show("Вы ввели неверные данные");
            dgvTable2.DataSource = DB.getAllData().Tables[1];
        }

        private void dgvTable2_SelectionChanged(object sender, EventArgs e)
        {
            int SelectedRow = dgvTable2.CurrentRow.Index;
            string chsnID = dgvTable2[0, SelectedRow].Value.ToString();
            string TableName = "lab4_ProvidersTable";

            txtProviderName.Text = DB.getDataByID(chsnID, TableName, "ProviderName", "ID_Provider");
            txtPhoneNumber.Text = DB.getDataByID(chsnID, TableName, "PhoneNumber", "ID_Provider");
        }
    }
}
