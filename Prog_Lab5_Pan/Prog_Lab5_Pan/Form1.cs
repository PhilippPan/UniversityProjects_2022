using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Lab5_Pan
{
    public partial class MainForm : Form
    {
        int Rtemp, Atemp;
        DBActions DB = new DBActions();

        public MainForm()
        {
            InitializeComponent();
            getTemp();
            getPower();
            //MessageBox.Show(" " + DateTime.Now.GetDateTimeFormats('u')[0]);
            if (DB.setData(cmbRoom.SelectedIndex+1, Rtemp, Atemp, txtSystemInfo.Text.ToString(), DateTime.Now.GetDateTimeFormats('u')[0]) < 1) MessageBox.Show("Ошибка добавления данных");
        }

        private void cmbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            getTemp();
            getPower();
            if (DB.setData(cmbRoom.SelectedIndex + 1, Rtemp, Atemp, txtSystemInfo.Text.ToString(), DateTime.Now.GetDateTimeFormats('u')[0]) < 1) MessageBox.Show("Ошибка добавления данных");
        }

        private void btnShowLog_Click(object sender, EventArgs e)
        {
            ShowLogForm form = new ShowLogForm();
            form.ShowDialog();
        }

        private void getTemp()
        {
            Random rnd = new Random();
            Rtemp = rnd.Next(19, 25);
            Atemp = Rtemp + 1;

            txtInputAirTemp.Text = Atemp.ToString() + " С";
            txtRoomTemp.Text = Rtemp.ToString() + " С";
            if (Rtemp >= 21) txtSystemInfo.Text = "Температура превышена";
            else  txtSystemInfo.Text = "Температура в норме";
        }

        private void getPower()
        {
            int Intensity = scrIntencity.Value;
            txtIntensity.Text = Intensity + " куб. м/мин";
            double Koef;
            switch (Atemp)
            {
                case 21: Koef = 716.2; break;
                case 22: Koef = 717.2; break;
                case 23: Koef = 718.2; break;
                case 24: Koef = 719.0; break;
                case 25: Koef = 720.3; break;
                case 26: Koef = 721.4; break;
                default: Koef = 715; break;
            }
            double Power = Intensity/Koef * 100;
            txtSystemPower.Text = Power.ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            getPower();
        }
    }
}
