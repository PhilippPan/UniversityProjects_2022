using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Lab6_Pan
{
    public partial class SettingsForm : Form
    {
        public SettingsForm(int BS, int PS, int GS, int S)
        {
            InitializeComponent();
            txtBallSize.Text =  BS.ToString();
            txtPlatfSize.Text = PS.ToString();
            txtGatesSize.Text = GS.ToString();
            txtSpeed.Text =     S.ToString();

        }
        public int BS, PS, GS, S;
        private void btnDone_Click(object sender, EventArgs e)
        {
            bool BSch = int.TryParse(txtBallSize.Text, out BS);
            bool PSch = int.TryParse(txtPlatfSize.Text, out PS);
            bool GSch = int.TryParse(txtGatesSize.Text, out GS);
            bool Sch =  int.TryParse(txtSpeed.Text, out S);
            if (BSch && PSch && GSch && Sch)
            {
                if (BS > 30 || BS < 1)              MessageBox.Show("Размер мяча не должен быть больше 30 и меньше 1");
                else if (GS > 600 || GS < 50)       MessageBox.Show("Размер ворот не должен быть больше 600 и меньше 50");
                else if (PS >= GS - BS || PS <= BS) MessageBox.Show("Размер платформ не должен быть больше размера ворот и меньше размера мяча");
                else if (S > 15 || S < 1)           MessageBox.Show("Скорость не должна быть больше 15 и меньше 1");
                else
                {
                    this.Close();
                }
            }
            else MessageBox.Show("Вы ввели некорректные данные!");

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
