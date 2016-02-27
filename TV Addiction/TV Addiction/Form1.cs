using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TV_Addiction
{
    public partial class form_main : Form
    {
        public form_main()
        {
            InitializeComponent();
        }

        private void btn_addSeries_Click(object sender, EventArgs e)
        {
            fbd_selectFolder.ShowDialog();
        }
    }
}
