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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbox_selectSeries
            // 
            this.cbbox_selectSeries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbox_selectSeries.FormattingEnabled = true;
            this.cbbox_selectSeries.Location = new System.Drawing.Point(6, 19);
            this.cbbox_selectSeries.Name = "cbbox_selectSeries";
            this.cbbox_selectSeries.Size = new System.Drawing.Size(364, 21);
            this.cbbox_selectSeries.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_deleteSeries);
            this.groupBox1.Controls.Add(this.btn_addSeries);
            this.groupBox1.Controls.Add(this.cbbox_selectSeries);
            this.groupBox1.Location = new System.Drawing.Point(36, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 84);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "What do you feel like watching?";
            // 
            // btn_deleteSeries
            // 
            this.btn_deleteSeries.Image = ((System.Drawing.Image)(resources.GetObject("btn_deleteSeries.Image")));
            this.btn_deleteSeries.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_deleteSeries.Location = new System.Drawing.Point(282, 46);
            this.btn_deleteSeries.Name = "btn_deleteSeries";
            this.btn_deleteSeries.Size = new System.Drawing.Size(88, 31);
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
            this.btn_addSeries.Size = new System.Drawing.Size(88, 31);
            this.btn_addSeries.TabIndex = 1;
            this.btn_addSeries.Text = "Add";
            this.btn_addSeries.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_addSeries.UseVisualStyleBackColor = true;
            // 
            // lbox_selectSeason
            // 
            this.lbox_selectSeason.FormattingEnabled = true;
            this.lbox_selectSeason.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "1",
            "2",
            "3",
            "5",
            "6",
            "7",
            "8"});
            this.lbox_selectSeason.Location = new System.Drawing.Point(42, 138);
            this.lbox_selectSeason.Name = "lbox_selectSeason";
            this.lbox_selectSeason.Size = new System.Drawing.Size(121, 134);
            this.lbox_selectSeason.TabIndex = 2;
            // 
            // lbox_selectEpisode
            // 
            this.lbox_selectEpisode.FormattingEnabled = true;
            this.lbox_selectEpisode.Location = new System.Drawing.Point(285, 138);
            this.lbox_selectEpisode.Name = "lbox_selectEpisode";
            this.lbox_selectEpisode.Size = new System.Drawing.Size(121, 134);
            this.lbox_selectEpisode.TabIndex = 3;
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 356);
            this.Controls.Add(this.lbox_selectEpisode);
            this.Controls.Add(this.lbox_selectSeason);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_main";
            this.Text = "TV Addiction";
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
    }
}

