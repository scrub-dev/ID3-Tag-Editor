using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ID3TagEditor
{
    public partial class Frm_mainForm : Form
    {
        public String directory = "";
        //public string[] Files;
        public int selected = 0;

        public Frm_mainForm()
        {
            InitializeComponent();
        }

        public void ChooseFolder()
        {
            FolderBrowserDialog Fbd_selectDirectory = new FolderBrowserDialog();
            if(Fbd_selectDirectory.ShowDialog() == DialogResult.OK)
            {
                Txt_folderSelected.Text = Fbd_selectDirectory.SelectedPath;
                directory = Fbd_selectDirectory.SelectedPath;
            }
        }

        private void Frm_mainForm_Load(object sender, EventArgs e)
        {
            Rtb_output.AppendText("Launch: Successful");
        }

        private void Btn_selectFolder_Click(object sender, EventArgs e)
        {
            ChooseFolder();
        }

        private void Txt_folderSelected_TextChanged(object sender, EventArgs e)
        {
            string[] Files = Directory.GetFiles(@Txt_folderSelected.Text, "*.mp3");
            Rtb_output.AppendText("\n"+Files.Length +" MP3 File(s) found");

            for(int i = 0; i < Files.Length; i++)
            {
                Lbx_files.Items.Add(Files[i].Substring(Txt_folderSelected.TextLength + 1));
            }
            Lbx_files.SetSelected(selected, true);
        }
    }
}
