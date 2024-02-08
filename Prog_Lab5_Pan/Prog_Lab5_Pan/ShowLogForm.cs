using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Lab5_Pan
{
    public partial class ShowLogForm : Form
    {
        DBActions DB = new DBActions();
        public ShowLogForm()
        {
            InitializeComponent();
            dgvTempLog.DataSource = DB.getData();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            dgvTempLog.DataSource = DB.getDataByDate(DateTime.Parse(dtpStartDate.Text), DateTime.Parse(dtpEndDate.Text));
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            int i = 0;
            StreamWriter sw = null;
            DataTable table = DB.getDataByDate(DateTime.Parse(dtpStartDate.Text), DateTime.Parse(dtpEndDate.Text));
            String date = DateTime.Now.GetDateTimeFormats('u')[0];
            String submittedFilePath = $"D:/!Учеба/Prog_Projects/Prog_Lab5_Pan/DataExport_.txt";
             SaveFileDialog savedialog = new SaveFileDialog();

             savedialog.Title = "Экспортировать как...";
             savedialog.OverwritePrompt = true;
             savedialog.CheckPathExists = true;
             savedialog.Filter = "Текстовые документы (*.txt)|*.txt";
             savedialog.FileName = "Export";

             if (savedialog.ShowDialog() == DialogResult.OK) //если в диалоговом окне нажата кнопка "ОК"
             {
                 try
                 {

                    sw = new StreamWriter(savedialog.FileName, false);

                    for (i = 0; i < table.Columns.Count - 1; i++)
                    {

                        sw.Write(table.Columns[i].ColumnName + ";");

                    }
                    sw.Write(table.Columns[i].ColumnName);
                    sw.WriteLine();

                    foreach (DataRow row in table.Rows)
                    {
                        object[] array = row.ItemArray;

                        for (i = 0; i < array.Length - 1; i++)
                        {
                            sw.Write(array[i].ToString() + ";");
                        }
                        sw.Write(array[i].ToString());
                        sw.WriteLine();
                    }
                    sw.Close();


                }
                catch
                 {
                     MessageBox.Show("Ошибка сохранения", "Ошибка",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }

             }

            

            
        }
    }
}
