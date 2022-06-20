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
    public partial class ViewDataForm : Form
    {
        public ViewDataForm(DataSet ds)
        {
            InitializeComponent();
            dgvTable1.DataSource = ds.Tables[0];
            dgvTable2.DataSource = ds.Tables[1];

        }
    }
}
