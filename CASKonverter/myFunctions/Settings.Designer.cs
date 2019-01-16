namespace CASKonverter.myFunctions
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.bt_OK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Codetabelle = new System.Windows.Forms.TextBox();
            this.bt_Durchsuchen = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.chkB_Codetabelle = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // bt_OK
            // 
            this.bt_OK.Location = new System.Drawing.Point(544, 150);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(55, 23);
            this.bt_OK.TabIndex = 0;
            this.bt_OK.Text = "OK";
            this.bt_OK.UseVisualStyleBackColor = true;
            this.bt_OK.Click += new System.EventHandler(this.bt_OK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codetabelle:";
            // 
            // tb_Codetabelle
            // 
            this.tb_Codetabelle.Location = new System.Drawing.Point(86, 13);
            this.tb_Codetabelle.Name = "tb_Codetabelle";
            this.tb_Codetabelle.Size = new System.Drawing.Size(475, 20);
            this.tb_Codetabelle.TabIndex = 2;
            // 
            // bt_Durchsuchen
            // 
            this.bt_Durchsuchen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_Durchsuchen.Image = ((System.Drawing.Image)(resources.GetObject("bt_Durchsuchen.Image")));
            this.bt_Durchsuchen.Location = new System.Drawing.Point(567, 11);
            this.bt_Durchsuchen.Name = "bt_Durchsuchen";
            this.bt_Durchsuchen.Size = new System.Drawing.Size(31, 28);
            this.bt_Durchsuchen.TabIndex = 3;
            this.bt_Durchsuchen.UseVisualStyleBackColor = true;
            this.bt_Durchsuchen.Click += new System.EventHandler(this.bt_Durchsuchen_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(86, 73);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(285, 58);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "Die Codeliste wird z.Zt. exklusiv für Logserv Gleisvermessung verwendet!";
            // 
            // chkB_Codetabelle
            // 
            this.chkB_Codetabelle.AutoSize = true;
            this.chkB_Codetabelle.Location = new System.Drawing.Point(86, 39);
            this.chkB_Codetabelle.Name = "chkB_Codetabelle";
            this.chkB_Codetabelle.Size = new System.Drawing.Size(135, 17);
            this.chkB_Codetabelle.TabIndex = 5;
            this.chkB_Codetabelle.Text = "Codetabelle anwenden";
            this.chkB_Codetabelle.UseVisualStyleBackColor = true;
            this.chkB_Codetabelle.CheckedChanged += new System.EventHandler(this.chkB_Codetabelle_CheckedChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 181);
            this.ControlBox = false;
            this.Controls.Add(this.chkB_Codetabelle);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.bt_Durchsuchen);
            this.Controls.Add(this.tb_Codetabelle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_OK);
            this.Name = "Settings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_OK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Codetabelle;
        private System.Windows.Forms.Button bt_Durchsuchen;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox chkB_Codetabelle;
    }
}