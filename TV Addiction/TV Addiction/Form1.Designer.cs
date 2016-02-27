namespace TV_Addiction
{
    partial class Form1
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_addSeries = new System.Windows.Forms.Button();
            this.btn_deleteSeries = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(364, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_deleteSeries);
            this.groupBox1.Controls.Add(this.btn_addSeries);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(36, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 84);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "What do you feel like watching?";
            // 
            // btn_addSeries
            // 
            this.btn_addSeries.Location = new System.Drawing.Point(6, 47);
            this.btn_addSeries.Name = "btn_addSeries";
            this.btn_addSeries.Size = new System.Drawing.Size(88, 31);
            this.btn_addSeries.TabIndex = 1;
            this.btn_addSeries.Text = "Add";
            this.btn_addSeries.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_addSeries.UseVisualStyleBackColor = true;
            // 
            // btn_deleteSeries
            // 
            this.btn_deleteSeries.Location = new System.Drawing.Point(282, 46);
            this.btn_deleteSeries.Name = "btn_deleteSeries";
            this.btn_deleteSeries.Size = new System.Drawing.Size(88, 31);
            this.btn_deleteSeries.TabIndex = 2;
            this.btn_deleteSeries.Text = "Delete";
            this.btn_deleteSeries.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_deleteSeries.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 356);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_deleteSeries;
        private System.Windows.Forms.Button btn_addSeries;
    }
}

