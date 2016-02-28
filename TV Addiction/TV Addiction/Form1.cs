using System;
using System.Text;
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
            cbbox_selectSeries.Items.Add(new Series(seriesName, folderPath));
            if (cbbox_selectSeries.Items.Count == 1)
            {
                cbbox_selectSeries.SelectedIndex = 0;
                FillSeasonListBox();
            }
        }

        private void cbbox_selectSeries_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillSeasonListBox();
        }

        private void form_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (XmlTextWriter writer = new XmlTextWriter(Settings.UserDataFile, Encoding.UTF8))
            {
                if (cbbox_selectSeries.Items.Count == 0)
                {
                    writer.Close();
                    return;
                }
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
            (cbbox_selectSeries.SelectedItem as Series).AdvanceEpisode();
            FillSeasonListBox();
        }

        private void LoadUserData(string file = null)
        {
            //if (file == null)
            //    file = Settings.UserDataFile;

            //using (XmlTextReader reader = new XmlTextReader(file))
            //{
            //    Series curSeries;
            //    Episode curEpisode;
            //    while (reader.Read())
            //    {
            //        switch (reader.NodeType)
            //        {
            //            case XmlNodeType.Element:
            //                switch (reader.Name)
            //                {
            //                    case "show":
            //                        reader.Read();
            //                        string name = reader.Name;
            //                        reader.Read();
            //                        int nextEp = Convert.ToInt32(reader.Name);
            //                        reader.Read();
            //                        curSeries = new Series
            //                        break;
            //                }
            //                break;
            //        }
            //    }
            //}
        }

        private void btn_deleteSeries_Click(object sender, EventArgs e)
        {
            if (cbbox_selectSeries.SelectedItem == null)
                MessageBox.Show("No series selected!", "Can't delete that", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                if (MessageBox.Show("Are you sure you want to delete " + cbbox_selectSeries.SelectedItem.ToString() + "?", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    cbbox_selectSeries.Items.RemoveAt(cbbox_selectSeries.SelectedIndex);
                cbbox_selectSeries.SelectedIndex = 0;
                FillSeasonListBox();
            }
        }

        private void FillSeasonListBox()
        {
            lbox_selectSeason.Items.Clear();

            foreach (Episode ep in (cbbox_selectSeries.SelectedItem as Series).Episodes)
            {
                if (!lbox_selectSeason.Items.Contains("Season " + ep.Season.ToString()))
                    lbox_selectSeason.Items.Add("Season " + ep.Season.ToString());
            }

            lbox_selectSeason.SelectedIndex = 0;
            FillEpisodeListBox();
        }

        private void FillEpisodeListBox()
        {
            lbox_selectEpisode.Items.Clear();

            foreach (Episode ep in (cbbox_selectSeries.SelectedItem as Series).Episodes)
            {
                if ("Season " + ep.Season.ToString() == (lbox_selectSeason.SelectedItem as string))
                    lbox_selectEpisode.Items.Add(ep);
            }
            lbox_selectEpisode.SelectedIndex = 0;
        }

        private void lbox_selectSeason_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillEpisodeListBox();
        }
    }
}
