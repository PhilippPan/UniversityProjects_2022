using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Lab3_Pan
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            /*
            L03_13. Исходные данные: название предприятия, общее число рабочих (Д1), число рабочих
            должностей, замещенных рабочими необходимого разряда (Д2). Данные сохранить в динамическом массиве
            пользовательского типа (в соответствии со структурой вводимых данных). Выдать справку: название предприятия,
            квалификационный уровень рабочих кадров. Квалификационный ypoвень = Д2 / Д1. Ввод и редактирование данных
            осуществлять с помощью вывода модальной формы и с использованием различных элементов управления (ввод
            числовых данных должен дублироваться ползунками-скроллами).
            */

            txtD1.Text = tbD1.Value.ToString();
            txtD2.Text = tbD2.Value.ToString();

            var Col1 = new DataGridViewColumn();
            Col1.HeaderText = "Название предприятия";
            Col1.Width = 150;
            Col1.ReadOnly = true;
            Col1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Col1.CellTemplate = new DataGridViewTextBoxCell();
            dgTable.Columns.Add(Col1);

            var Col2 = new DataGridViewColumn();
            Col2.HeaderText = "Общее число рабочих";
            Col2.Width = 150;
            Col2.ReadOnly = true;
            Col2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Col2.CellTemplate = new DataGridViewTextBoxCell();
            dgTable.Columns.Add(Col2);

            var Col3 = new DataGridViewColumn();
            Col3.HeaderText = "Число рабочих должностей";
            Col3.Width = 150;
            Col3.ReadOnly = true;
            Col3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Col3.CellTemplate = new DataGridViewTextBoxCell();
            dgTable.Columns.Add(Col3);

        }
        struct LB3
        {
            public string Name;
            public int D1;
            public int D2;
        }
        public static int StrToIntCheck(string val)
        {
            bool Scc = int.TryParse(val, out int v2);
            if (Scc) return v2;
            else return 0; 

        }

        LB3[] lbArr = new LB3[100];
        int RowCount = 0;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (RowCount < 100)
            {
                LB3 NewRow = new LB3();
                NewRow.Name = txtPName.Text;
                NewRow.D1 = StrToIntCheck(txtD1.Text);
                NewRow.D2 = StrToIntCheck(txtD2.Text);
                lbArr[RowCount] = NewRow;

                dgTable.Rows.Add(lbArr[RowCount].Name, lbArr[RowCount].D1, lbArr[RowCount].D2);

                if (StrToIntCheck(txtD1.Text) == 0 || StrToIntCheck(txtD2.Text) == 0) txtErr.Text = "Проверьте корректность введенных данных";
                else txtErr.Text = "";

                RowCount++;
            } else MessageBox.Show("Массив переполнен!", "Упс", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //var row = dgTable.SelectedRows;
            try
            {
                dgTable.Rows.Remove(dgTable.CurrentRow);
            } catch { MessageBox.Show("Для удаления строки необходимо поместить курсор на одно из полей данных в ней", "Ошибочка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnNote_Click(object sender, EventArgs e)
        {
            try
            {
                int CurRowNum = dgTable.CurrentRow.Index;
                string cN = lbArr[CurRowNum].Name;
                int cD1 =   lbArr[CurRowNum].D1;
                int cD2 =   lbArr[CurRowNum].D2;

                NoteForm NF = new NoteForm(cN, cD1, cD2);
                NF.ShowDialog();
            }
            catch { MessageBox.Show("Нужно выбрать сроку с даннми", "Ошибочка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void tbD1_Scroll(object sender, EventArgs e)
        {
            txtD1.Text = tbD1.Value.ToString();
        }

        private void tbD2_Scroll(object sender, EventArgs e)
        {
            txtD2.Text = tbD2.Value.ToString();
        }
    }
}
