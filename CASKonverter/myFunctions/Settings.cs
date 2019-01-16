using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CASKonverter.myFunctions
{
    public partial class Settings : Form
    {
        myUtilities.myRegistry objRegistry = myUtilities.myRegistry.Instance;
        private string Codetabelle = String.Empty;

        public Settings()
        {
            InitializeComponent();

            Codetabelle = (string)objRegistry.readValue("Codetabelle");

            if (Codetabelle != null)
                tb_Codetabelle.Text = Codetabelle;

            string chkCodetabelle;
            try
            {
                chkCodetabelle = (string) objRegistry.readValue("chk Codetabelle");

                if (chkCodetabelle != null)
                    switch (chkCodetabelle)
                    {
                        case "False":
                            chkB_Codetabelle.Checked = false;
                            break;

                        case "True":
                            chkB_Codetabelle.Checked = true;
                            break;
                    }

            }
            catch { }
        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            string Codetabelle = (string)objRegistry.readValue("Codetabelle");
            bool chkCode = chkB_Codetabelle.Checked;

            if (!( (Codetabelle == null || Codetabelle == "") && chkCode == true))
            {
                bt_OK.Enabled = true;
                Close();
            }
            else
                bt_OK.Enabled = false;
        }

        private void bt_Durchsuchen_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult bFileOK = System.Windows.Forms.DialogResult.No; 
     
            //Dialogbox OpenFileDialog
            OpenFileDialog objOpenFileDialog = new OpenFileDialog();
            objOpenFileDialog.Filter = "Codetabelle|*.csv";

            if (Codetabelle != null)
                objOpenFileDialog.FileName = Codetabelle;
            bFileOK = objOpenFileDialog.ShowDialog();
            Codetabelle = objOpenFileDialog.FileName;

            tb_Codetabelle.Text = Codetabelle;
            objRegistry.regValue("Codetabelle", Codetabelle);
        }

        private void chkB_Codetabelle_CheckedChanged(object sender, EventArgs e)
        {
            string Codetabelle = (string) objRegistry.readValue("Codetabelle");

            if (Codetabelle == null || Codetabelle == "" || chkB_Codetabelle.Checked == true)
            {
                objRegistry.regValue("chk Codetabelle", chkB_Codetabelle.Checked);
                myUtilities.myCodetabelle.Instance.readCodeTable();
                bt_OK.Enabled = true;
            }
            else
            {
                MessageBox.Show("Bitte zuerst gültige Codetabelle auswählen!");
            }
        }
    }
}
