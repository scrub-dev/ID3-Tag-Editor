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
using TagLib;

namespace ID3TagEditor
{
    public partial class Frm_mainForm : Form
    {
        public String directory = ""; 
        public string[] Files; 
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

                Files = Directory.GetFiles(Txt_folderSelected.Text, "*.mp3");
                Rtb_output.AppendText("\n" + Files.Length + " MP3 File(s) found");
                if (Files.Length == 0)
                {
                    DialogResult dr = MessageBox.Show("You selected a folder with no MP3 Files in it, Would you like to pick another folder?", "No Files Found", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    switch (dr)
                    {
                        case DialogResult.Yes:
                            ChooseFolder();
                            break;
                        case DialogResult.No:
                            return;
                    }
                }
                else
                {
                    for (int i = 0; i < Files.Length; i++)
                    {
                        Lbx_files.Items.Add(Files[i].Substring(Txt_folderSelected.TextLength + 1));
                    }
                    Lbx_files.SetSelected(selected, true);
                }

            }
        }

        private void Frm_mainForm_Load(object sender, EventArgs e)
        {
            Rtb_output.AppendText("Launch: Successful");
        }

        private void Btn_selectFolder_Click(object sender, EventArgs e)
        {
            if (Lbx_files.Items != null) Lbx_files.Items.Clear();
            ChooseFolder();
        }

        private void Rtb_output_TextChanged(object sender, EventArgs e)
        {
            Rtb_output.ScrollToCaret();
        }

        private void Lbx_files_SelectedIndexChanged(object sender, EventArgs e)
        {
            Txt_selectedSong.Text = Lbx_files.SelectedItem.ToString();
        }

        private void Chk_artist_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_artist.Checked)
            {
                Txt_artist.Enabled = true;
            }
            else
            {
                Txt_artist.Enabled = false;
                Txt_artist.Text = "";
            }
        }

        private void Chk_song_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_song.Checked)
            {
                Txt_song.Enabled = true;
            }
            else
            {
                Txt_song.Enabled = false;
                Txt_song.Text = "";
            }
        }

        private void Chk_album_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_album.Checked)
            {
                Txt_album.Enabled = true;
            }
            else
            {
                Txt_album.Enabled = false;
                Txt_album.Text = "";
            }
        }

        private void Chk_year_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_year.Checked)
            {
                Txt_year.Enabled = true;
            }
            else
            {
                Txt_year.Enabled = false;
                Txt_year.Text = "";
            }
        }

        private void Btn_write_Click(object sender, EventArgs e)
        {
            if (Chk_song.Checked && Txt_song.Text == "") { MessageBox.Show("Song field enabled but left blank", "Song Field Blank", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (Chk_artist.Checked && Txt_artist.Text == "") { MessageBox.Show("Artist field enabled but left blank", "Artist Field Blank", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (Chk_album.Checked && Txt_album.Text == "") { MessageBox.Show("Album field enabled but left blank", "Album Field Blank", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (Chk_year.Checked && Txt_year.Text == "") { MessageBox.Show("Year field enabled but left blank", "Year Field Blank", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            try
            {
                TagLib.File MetaFile = TagLib.File.Create(Txt_folderSelected.Text + "\\" + Txt_selectedSong.Text);

                if (Chk_song.Checked) MetaFile.Tag.Title = Txt_song.Text;
                if (Chk_artist.Checked) MetaFile.Tag.Performers = new string[1] { Txt_artist.Text };
                if (Chk_album.Checked) MetaFile.Tag.Album = Txt_album.Text;
                if (Chk_year.Checked) MetaFile.Tag.Year = Convert.ToUInt16(Txt_year.Text);
                MetaFile.Save();
                Rtb_output.AppendText("\n" + Txt_selectedSong.Text + " : Tags have been wrote");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + Txt_folderSelected.Text + "\\" + Txt_selectedSong.Text, "An Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex);
            }
        }

        private void Btn_eraseAll_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("You are about to wipe all Meta Tags from all MP3 Files in the selected Directory", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            switch (dr)
            {
                case DialogResult.OK:
                    for (int i = 0; i < Lbx_files.Items.Count; i++)
                    {
                        RemoveTags(Lbx_files.Items[i].ToString());
                    }
                    break;
                case DialogResult.Cancel:
                    return;
            }
        }

        private void Btn_erase_Click(object sender, EventArgs e)
        {
            RemoveTags(Txt_selectedSong.Text);
        }

        void RemoveTags(string file)
        {
            try
            {
                TagLib.File MetaFile = TagLib.File.Create(Txt_folderSelected.Text + "\\" + file);
                MetaFile.RemoveTags(TagTypes.AllTags);
                Rtb_output.AppendText("\n" + file + " : Tags have been removed");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "An Error has Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
