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
    public partial class MainForm : Form
    {
        DBActions DB = new DBActions();
        public MainForm()
        {
            InitializeComponent();

            //cmbItemCode.DataSource = ;
            cmbItemCode.DataSource =    DB.getPoviderID("ItemCode", "lab4_ItemsTable");
            cmbItemCode.DisplayMember = DB.getPoviderID("ItemCode", "lab4_ItemsTable").Columns[0].ToString();
            cmbItemCode.ValueMember =   DB.getPoviderID("ItemCode", "lab4_ItemsTable").Columns[0].ToString();

            cmbItemName.DataSource = DB.getPoviderID("ItemName", "lab4_ItemsTable");
            cmbItemName.DisplayMember = DB.getPoviderID("ItemName", "lab4_ItemsTable").Columns[0].ToString();
            cmbItemName.ValueMember = DB.getPoviderID("ItemName", "lab4_ItemsTable").Columns[0].ToString();

            txtPrevItemCode.Text = "";
            /*cmbStorageNum.DataSource =    DB.getPoviderID("StorageNumber", "lab4_ItemsTable");
            cmbStorageNum.DisplayMember = DB.getPoviderID("StorageNumber", "lab4_ItemsTable").Columns[0].ToString();
            cmbStorageNum.ValueMember =   DB.getPoviderID("StorageNumber", "lab4_ItemsTable").Columns[0].ToString();*/
        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            ViewDataForm VF = new ViewDataForm(DB.getAllData());
            VF.ShowDialog();
        }

        private void btnEditData_Click(object sender, EventArgs e)
        {
            EditDataForm EF = new EditDataForm(DB.getAllData());
            EF.ShowDialog();
        }

        private void btnQ1_Click(object sender, EventArgs e)
        {
            string userSN;
            try { userSN = cmbStorageNum.SelectedItem.ToString(); }
            catch { userSN = "1"; }
            dgResultTable.DataSource = DB.getDataSetFromDateTime(DateTime.Parse(dtpStartDate.Text), DateTime.Parse(dtpEndDate.Text), userSN);
        }

        private void btnQ2_Click(object sender, EventArgs e)
        {
           dgResultTable.DataSource = DB.getDataSetByID("*", "lab4_ItemsTable", "ItemCode", cmbItemCode.Text);
        }

        private void btnQ3_Click(object sender, EventArgs e)
        {
            dgResultTable.DataSource = DB.getPoviderID("SupplyCost", "lab4_ItemsTable");
            int RC = dgResultTable.Rows.Count;
            int A = 0, C = 0;
            for (int i = 0; i < RC; i++)
            {
                A += int.Parse(dgResultTable[0, i].Value.ToString());
                if (int.Parse(dgResultTable[0, i].Value.ToString()) > C) C = int.Parse(dgResultTable[0, i].Value.ToString());
            }
            int AvrgVal = A / RC;

            MessageBox.Show("Средняя цена: " + AvrgVal + "\nМаксимальное значение: " + C);
        }

        private void btnQ4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DB.editItemCode("lab4_ItemsTable", cmbItemName.Text, txtNewItemCode.Text));
            txtNewItemCode.Text = "";
        }

        private void cmbItemName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPrevItemCode.Text = DB.getDataByID(cmbItemName.Text, "lab4_ItemsTable", "ItemCode", "ItemName");
        }
    }
}
