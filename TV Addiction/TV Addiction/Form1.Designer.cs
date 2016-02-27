namespace TV_Addiction
{
    partial class form_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_main));
            this.cbbox_selectSeries = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_deleteSeries = new System.Windows.Forms.Button();
            this.btn_addSeries = new System.Windows.Forms.Button();
            this.lbox_selectSeason = new System.Windows.Forms.ListBox();
            this.lbox_selectEpisode = new System.Windows.Forms.ListBox();
            this.btn_playNext = new System.Windows.Forms.Button();
            this.btn_playSelected = new System.Windows.Forms.Button();
            this.btn_seriesSettings = new System.Windows.Forms.Button();
            this.fbd_selectFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbox_selectSeries
            // 
            this.cbbox_selectSeries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbox_selectSeries.FormattingEnabled = true;
            this.cbbox_selectSeries.Location = new System.Drawing.Point(6, 19);
            this.cbbox_selectSeries.Name = "cbbox_selectSeries";
            this.cbbox_selectSeries.Size = new System.Drawing.Size(363, 21);
            this.cbbox_selectSeries.Sorted = true;
            this.cbbox_selectSeries.TabIndex = 0;
            this.cbbox_selectSeries.SelectedIndexChanged += new System.EventHandler(this.cbbox_selectSeries_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_deleteSeries);
            this.groupBox1.Controls.Add(this.btn_addSeries);
            this.groupBox1.Controls.Add(this.cbbox_selectSeries);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 84);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "What do you feel like watching?";
            // 
            // btn_deleteSeries
            // 
            this.btn_deleteSeries.Image = ((System.Drawing.Image)(resources.GetObject("btn_deleteSeries.Image")));
            this.btn_deleteSeries.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_deleteSeries.Location = new System.Drawing.Point(248, 46);
            this.btn_deleteSeries.Name = "btn_deleteSeries";
            this.btn_deleteSeries.Size = new System.Drawing.Size(121, 31);
            this.btn_deleteSeries.TabIndex = 2;
            this.btn_deleteSeries.Text = "Delete";
            this.btn_deleteSeries.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_deleteSeries.UseVisualStyleBackColor = true;
            // 
            // btn_addSeries
            // 
            this.btn_addSeries.Image = ((System.Drawing.Image)(resources.GetObject("btn_addSeries.Image")));
            this.btn_addSeries.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_addSeries.Location = new System.Drawing.Point(6, 47);
            this.btn_addSeries.Name = "btn_addSeries";
            this.btn_addSeries.Size = new System.Drawing.Size(121, 31);
            this.btn_addSeries.TabIndex = 1;
            this.btn_addSeries.Text = "Add";
            this.btn_addSeries.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_addSeries.UseVisualStyleBackColor = true;
            this.btn_addSeries.Click += new System.EventHandler(this.btn_addSeries_Click);
            // 
            // lbox_selectSeason
            // 
            this.lbox_selectSeason.FormattingEnabled = true;
            this.lbox_selectSeason.Location = new System.Drawing.Point(18, 114);
            this.lbox_selectSeason.Name = "lbox_selectSeason";
            this.lbox_selectSeason.Size = new System.Drawing.Size(121, 134);
            this.lbox_selectSeason.TabIndex = 2;
            // 
            // lbox_selectEpisode
            // 
            this.lbox_selectEpisode.FormattingEnabled = true;
            this.lbox_selectEpisode.Location = new System.Drawing.Point(260, 114);
            this.lbox_selectEpisode.Name = "lbox_selectEpisode";
            this.lbox_selectEpisode.Size = new System.Drawing.Size(121, 134);
            this.lbox_selectEpisode.TabIndex = 3;
            // 
            // btn_playNext
            // 
            this.btn_playNext.Image = ((System.Drawing.Image)(resources.GetObject("btn_playNext.Image")));
            this.btn_playNext.Location = new System.Drawing.Point(145, 114);
            this.btn_playNext.Name = "btn_playNext";
            this.btn_playNext.Size = new System.Drawing.Size(109, 34);
            this.btn_playNext.TabIndex = 4;
            this.btn_playNext.Text = "Play next";
            this.btn_playNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_playNext.UseVisualStyleBackColor = true;
            this.btn_playNext.Click += new System.EventHandler(this.btn_playNext_Click);
            // 
            // btn_playSelected
            // 
            this.btn_playSelected.Image = ((System.Drawing.Image)(resources.GetObject("btn_playSelected.Image")));
            this.btn_playSelected.Location = new System.Drawing.Point(145, 214);
            this.btn_playSelected.Name = "btn_playSelected";
            this.btn_playSelected.Size = new System.Drawing.Size(109, 34);
            this.btn_playSelected.TabIndex = 5;
            this.btn_playSelected.Text = "Play selected";
            this.btn_playSelected.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_playSelected.UseVisualStyleBackColor = true;
            // 
            // btn_seriesSettings
            // 
            this.btn_seriesSettings.Location = new System.Drawing.Point(145, 164);
            this.btn_seriesSettings.Name = "btn_seriesSettings";
            this.btn_seriesSettings.Size = new System.Drawing.Size(109, 34);
            this.btn_seriesSettings.TabIndex = 6;
            this.btn_seriesSettings.Text = "Settings";
            this.btn_seriesSettings.UseVisualStyleBackColor = true;
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 262);
            this.Controls.Add(this.btn_seriesSettings);
            this.Controls.Add(this.btn_playSelected);
            this.Controls.Add(this.btn_playNext);
            this.Controls.Add(this.lbox_selectEpisode);
            this.Controls.Add(this.lbox_selectSeason);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_main";
            this.Text = "TV Addiction";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_main_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbox_selectSeries;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_deleteSeries;
        private System.Windows.Forms.Button btn_addSeries;
        private System.Windows.Forms.ListBox lbox_selectSeason;
        private System.Windows.Forms.ListBox lbox_selectEpisode;
        private System.Windows.Forms.Button btn_playNext;
        private System.Windows.Forms.Button btn_playSelected;
        private System.Windows.Forms.Button btn_seriesSettings;
        private System.Windows.Forms.FolderBrowserDialog fbd_selectFolder;
    }
}

