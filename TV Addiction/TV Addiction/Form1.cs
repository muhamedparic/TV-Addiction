using System;
using System.IO;
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
            string folderPath = fbd_selectFolder.SelectedPath;
            string seriesName = Microsoft.VisualBasic.Interaction.InputBox("Please enter the name of the series", "Enter name");
            
        }

        private void cbbox_selectSeries_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void form_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save
        }
    }
}
