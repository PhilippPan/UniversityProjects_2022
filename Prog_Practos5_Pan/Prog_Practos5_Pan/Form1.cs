using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Prog_Practos5_Pan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string fileName;
        private void btnShow_Click(object sender, EventArgs e)
        {
            OpenFileDialog FD = new OpenFileDialog();
            FD.Multiselect = false;
            FD.DefaultExt = "csv";
            FD.Filter = "CSV (*.csv)|*.csv";
            FD.ShowDialog();

            fileName = FD.FileName;
            if (fileName == "" || fileName == null)
            {
                return;
            }
            dgvResTable.Rows.Clear();
            dgvResTable.Columns.Clear();

            string[] lines = File.ReadAllLines(fileName);
            if (lines.Length > 0)
            {
                dgvResTable.RowCount = 1;
                dgvResTable.ColumnCount = lines[0].Split(';').Length;
                foreach (string line in lines)
                {
                    string[] words = line.Split(';');
                    dgvResTable.Rows.Add(words);
                }
            }
        }
    }
}
