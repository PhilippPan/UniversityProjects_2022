using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Prog_Practos2_Pan
{
    public partial class Practos2 : Form
    {
        public Practos2()
        {
            InitializeComponent();

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            // получаем введенные пользователем данные о кол-ве строк и столбцов
            int ColN = int.Parse(cmbColl.SelectedItem.ToString());
            int RowN = int.Parse(cmbRows.SelectedItem.ToString());
            // создаем массив
            int[,] newArr = new int[RowN,ColN];
            // получаем его длину и ширину
            int height = newArr.GetLength(0);
            int width = newArr.GetLength(1);
            // очищаем элемент просмотра данных
            this.ArrayView.Columns.Clear();
            this.ArrayView.ColumnCount = width;
            // генерируем рандомные значения и выводим их на интерфейс
            for (int i=0; i<height; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.ArrayView);

                for (int j = 0; j < width; j++)
                {
                    newArr[i, j] = rnd.Next(0, 100);
                    row.Cells[j].Value = newArr[i, j];
                }
                this.ArrayView.Rows.Add(row); // добавление строки с данными в элемент просмотра
            }

        }
    }
}
