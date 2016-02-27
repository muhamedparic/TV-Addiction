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
using System.Xml;

namespace TV_Addiction
{
    public partial class form_main : Form
    {
        public form_main()
        {
            InitializeComponent();
            Settings.Load();
            LoadUserData();
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
#warning Method WIP
        }

        private void form_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cbbox_selectSeries.Items.Count == 0)
                return;
            using (XmlTextWriter writer = new XmlTextWriter(Settings.UserDataFile, Encoding.UTF8))
            {
                writer.Formatting = Formatting.Indented;
                writer.WriteStartDocument();
                writer.WriteStartElement("series");
                foreach (Series series in cbbox_selectSeries.Items)
                    series.WriteToXml(writer);
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
            }
        }

        private void btn_playNext_Click(object sender, EventArgs e)
        {
            try
            {
                Process vlcProcess = new Process();
                vlcProcess.StartInfo.FileName = Settings.VlcPath;
                vlcProcess.StartInfo.Arguments = (cbbox_selectSeries.SelectedItem as Series).GetNextEpisodePath();
                //vlcProcess.StartInfo.Arguments = @"C:\Users\Muhamed\Downloads\TV\The.Office.US.S06.Season.6.Complete.720p.HDTV.x264-[maximersk]\The.Office.US.S06E13.720p.HDTV.X264-MRSK.mkv";
                vlcProcess.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("An error has occured, probably your fault");
            }
        }

        private void LoadUserData(string file = null)
        {
            if (file == null)
                file = Settings.UserDataFile;
            
        }
    }
}
