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
    public partial class NoteForm : Form
    {
        public NoteForm(string N, int D1, int D2)
        {
            InitializeComponent();
            float D3 = 0, uD1 = 0 + D1, uD2 = 0 + D2;
            D3 = uD2/uD1;
            txtCheck.Text = $"Название предприятия: {N}\nКвалификационный уровень рабочих кадров: {D3}";
        }
    }
}
