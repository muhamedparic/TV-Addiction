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
using System.Diagnostics;

namespace TV_Addiction
{
    public partial class form_main : Form
    {
        public form_main()
        {
            InitializeComponent();
            // TEMPORARY:
            Settings.VlcPath = @"C:\Program Files\VideoLAN\VLC\vlc.exe";
        }

        private void btn_addSeries_Click(object sender, EventArgs e)
        {
            fbd_selectFolder.ShowDialog();
            string folderPath = fbd_selectFolder.SelectedPath;
            if (folderPath.Length == 0)
                return;
            string seriesName = Microsoft.VisualBasic.Interaction.InputBox("Please enter the name of the series", "Enter name");
            cbbox_selectSeries.Items.Add(new Series(folderPath, seriesName));
        }

        private void cbbox_selectSeries_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void form_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save
        }

        private void btn_playNext_Click(object sender, EventArgs e)
        {
            try
            {
                Process vlcProcess = new Process();
                vlcProcess.StartInfo.FileName = Settings.VlcPath;
                vlcProcess.StartInfo.Arguments = (cbbox_selectSeries.SelectedItem as Series).GetNextEpisodePath();
                vlcProcess.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("An error has occured, probably your fault");
            }
        }
    }
}
