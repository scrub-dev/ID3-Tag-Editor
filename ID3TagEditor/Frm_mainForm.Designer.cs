namespace ID3TagEditor
{
    partial class Frm_mainForm
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
            this.Txt_folderSelected = new System.Windows.Forms.TextBox();
            this.Btn_selectFolder = new System.Windows.Forms.Button();
            this.Rtb_output = new System.Windows.Forms.RichTextBox();
            this.Lbx_files = new System.Windows.Forms.ListBox();
            this.Lbl_selectedSong = new System.Windows.Forms.Label();
            this.Txt_selectedSong = new System.Windows.Forms.TextBox();
            this.Txt_artist = new System.Windows.Forms.TextBox();
            this.Txt_song = new System.Windows.Forms.TextBox();
            this.Txt_album = new System.Windows.Forms.TextBox();
            this.Txt_year = new System.Windows.Forms.TextBox();
            this.Lbl_artist = new System.Windows.Forms.Label();
            this.Lbl_song = new System.Windows.Forms.Label();
            this.Lbl_album = new System.Windows.Forms.Label();
            this.Lbl_year = new System.Windows.Forms.Label();
            this.Chk_artist = new System.Windows.Forms.CheckBox();
            this.Chk_song = new System.Windows.Forms.CheckBox();
            this.Chk_album = new System.Windows.Forms.CheckBox();
            this.Chk_year = new System.Windows.Forms.CheckBox();
            this.Btn_previous = new System.Windows.Forms.Button();
            this.Btn_write = new System.Windows.Forms.Button();
            this.Btn_next = new System.Windows.Forms.Button();
            this.Ms_mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportABugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_eraseAll = new System.Windows.Forms.Button();
            this.Btn_erase = new System.Windows.Forms.Button();
            this.Btn_clearOutput = new System.Windows.Forms.Button();
            this.Ms_mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txt_folderSelected
            // 
            this.Txt_folderSelected.Location = new System.Drawing.Point(100, 27);
            this.Txt_folderSelected.Name = "Txt_folderSelected";
            this.Txt_folderSelected.Size = new System.Drawing.Size(191, 20);
            this.Txt_folderSelected.TabIndex = 0;
            // 
            // Btn_selectFolder
            // 
            this.Btn_selectFolder.Location = new System.Drawing.Point(12, 25);
            this.Btn_selectFolder.Name = "Btn_selectFolder";
            this.Btn_selectFolder.Size = new System.Drawing.Size(82, 23);
            this.Btn_selectFolder.TabIndex = 1;
            this.Btn_selectFolder.Text = "Select Folder";
            this.Btn_selectFolder.UseVisualStyleBackColor = true;
            this.Btn_selectFolder.Click += new System.EventHandler(this.Btn_selectFolder_Click);
            // 
            // Rtb_output
            // 
            this.Rtb_output.Location = new System.Drawing.Point(12, 256);
            this.Rtb_output.Name = "Rtb_output";
            this.Rtb_output.ReadOnly = true;
            this.Rtb_output.Size = new System.Drawing.Size(286, 178);
            this.Rtb_output.TabIndex = 2;
            this.Rtb_output.Text = "";
            this.Rtb_output.TextChanged += new System.EventHandler(this.Rtb_output_TextChanged);
            // 
            // Lbx_files
            // 
            this.Lbx_files.FormattingEnabled = true;
            this.Lbx_files.Location = new System.Drawing.Point(304, 25);
            this.Lbx_files.Name = "Lbx_files";
            this.Lbx_files.Size = new System.Drawing.Size(280, 407);
            this.Lbx_files.TabIndex = 3;
            this.Lbx_files.SelectedIndexChanged += new System.EventHandler(this.Lbx_files_SelectedIndexChanged);
            // 
            // Lbl_selectedSong
            // 
            this.Lbl_selectedSong.AutoSize = true;
            this.Lbl_selectedSong.Location = new System.Drawing.Point(14, 55);
            this.Lbl_selectedSong.Name = "Lbl_selectedSong";
            this.Lbl_selectedSong.Size = new System.Drawing.Size(80, 13);
            this.Lbl_selectedSong.TabIndex = 7;
            this.Lbl_selectedSong.Text = "Selected Song:";
            // 
            // Txt_selectedSong
            // 
            this.Txt_selectedSong.Enabled = false;
            this.Txt_selectedSong.Location = new System.Drawing.Point(100, 52);
            this.Txt_selectedSong.Name = "Txt_selectedSong";
            this.Txt_selectedSong.Size = new System.Drawing.Size(191, 20);
            this.Txt_selectedSong.TabIndex = 8;
            // 
            // Txt_artist
            // 
            this.Txt_artist.Enabled = false;
            this.Txt_artist.Location = new System.Drawing.Point(100, 79);
            this.Txt_artist.Name = "Txt_artist";
            this.Txt_artist.Size = new System.Drawing.Size(100, 20);
            this.Txt_artist.TabIndex = 9;
            // 
            // Txt_song
            // 
            this.Txt_song.Enabled = false;
            this.Txt_song.Location = new System.Drawing.Point(100, 105);
            this.Txt_song.Name = "Txt_song";
            this.Txt_song.Size = new System.Drawing.Size(100, 20);
            this.Txt_song.TabIndex = 10;
            // 
            // Txt_album
            // 
            this.Txt_album.Enabled = false;
            this.Txt_album.Location = new System.Drawing.Point(100, 131);
            this.Txt_album.Name = "Txt_album";
            this.Txt_album.Size = new System.Drawing.Size(100, 20);
            this.Txt_album.TabIndex = 11;
            // 
            // Txt_year
            // 
            this.Txt_year.Enabled = false;
            this.Txt_year.Location = new System.Drawing.Point(100, 157);
            this.Txt_year.Name = "Txt_year";
            this.Txt_year.Size = new System.Drawing.Size(100, 20);
            this.Txt_year.TabIndex = 12;
            // 
            // Lbl_artist
            // 
            this.Lbl_artist.AutoSize = true;
            this.Lbl_artist.Location = new System.Drawing.Point(32, 82);
            this.Lbl_artist.Name = "Lbl_artist";
            this.Lbl_artist.Size = new System.Drawing.Size(62, 13);
            this.Lbl_artist.TabIndex = 13;
            this.Lbl_artist.Text = "Artist name:";
            // 
            // Lbl_song
            // 
            this.Lbl_song.AutoSize = true;
            this.Lbl_song.Location = new System.Drawing.Point(30, 108);
            this.Lbl_song.Name = "Lbl_song";
            this.Lbl_song.Size = new System.Drawing.Size(64, 13);
            this.Lbl_song.TabIndex = 14;
            this.Lbl_song.Text = "Song name:";
            // 
            // Lbl_album
            // 
            this.Lbl_album.AutoSize = true;
            this.Lbl_album.Location = new System.Drawing.Point(26, 134);
            this.Lbl_album.Name = "Lbl_album";
            this.Lbl_album.Size = new System.Drawing.Size(68, 13);
            this.Lbl_album.TabIndex = 15;
            this.Lbl_album.Text = "Album name:";
            // 
            // Lbl_year
            // 
            this.Lbl_year.AutoSize = true;
            this.Lbl_year.Location = new System.Drawing.Point(33, 160);
            this.Lbl_year.Name = "Lbl_year";
            this.Lbl_year.Size = new System.Drawing.Size(61, 13);
            this.Lbl_year.TabIndex = 16;
            this.Lbl_year.Text = "Year made:";
            // 
            // Chk_artist
            // 
            this.Chk_artist.AutoSize = true;
            this.Chk_artist.Location = new System.Drawing.Point(207, 81);
            this.Chk_artist.Name = "Chk_artist";
            this.Chk_artist.Size = new System.Drawing.Size(85, 17);
            this.Chk_artist.TabIndex = 17;
            this.Chk_artist.Text = "Enable Artist";
            this.Chk_artist.UseVisualStyleBackColor = true;
            this.Chk_artist.CheckedChanged += new System.EventHandler(this.Chk_artist_CheckedChanged);
            // 
            // Chk_song
            // 
            this.Chk_song.AutoSize = true;
            this.Chk_song.Location = new System.Drawing.Point(207, 107);
            this.Chk_song.Name = "Chk_song";
            this.Chk_song.Size = new System.Drawing.Size(87, 17);
            this.Chk_song.TabIndex = 18;
            this.Chk_song.Text = "Enable Song";
            this.Chk_song.UseVisualStyleBackColor = true;
            this.Chk_song.CheckedChanged += new System.EventHandler(this.Chk_song_CheckedChanged);
            // 
            // Chk_album
            // 
            this.Chk_album.AutoSize = true;
            this.Chk_album.Location = new System.Drawing.Point(207, 133);
            this.Chk_album.Name = "Chk_album";
            this.Chk_album.Size = new System.Drawing.Size(91, 17);
            this.Chk_album.TabIndex = 19;
            this.Chk_album.Text = "Enable Album";
            this.Chk_album.UseVisualStyleBackColor = true;
            this.Chk_album.CheckedChanged += new System.EventHandler(this.Chk_album_CheckedChanged);
            // 
            // Chk_year
            // 
            this.Chk_year.AutoSize = true;
            this.Chk_year.Cursor = System.Windows.Forms.Cursors.Default;
            this.Chk_year.Location = new System.Drawing.Point(207, 159);
            this.Chk_year.Name = "Chk_year";
            this.Chk_year.Size = new System.Drawing.Size(84, 17);
            this.Chk_year.TabIndex = 20;
            this.Chk_year.Text = "Enable Year";
            this.Chk_year.UseVisualStyleBackColor = true;
            this.Chk_year.CheckedChanged += new System.EventHandler(this.Chk_year_CheckedChanged);
            // 
            // Btn_previous
            // 
            this.Btn_previous.Location = new System.Drawing.Point(19, 199);
            this.Btn_previous.Name = "Btn_previous";
            this.Btn_previous.Size = new System.Drawing.Size(90, 23);
            this.Btn_previous.TabIndex = 21;
            this.Btn_previous.Text = "Previous";
            this.Btn_previous.UseVisualStyleBackColor = true;
            this.Btn_previous.Click += new System.EventHandler(this.Btn_previous_Click);
            // 
            // Btn_write
            // 
            this.Btn_write.Location = new System.Drawing.Point(115, 199);
            this.Btn_write.Name = "Btn_write";
            this.Btn_write.Size = new System.Drawing.Size(90, 23);
            this.Btn_write.TabIndex = 22;
            this.Btn_write.Text = "Write";
            this.Btn_write.UseVisualStyleBackColor = true;
            this.Btn_write.Click += new System.EventHandler(this.Btn_write_Click);
            // 
            // Btn_next
            // 
            this.Btn_next.Location = new System.Drawing.Point(212, 199);
            this.Btn_next.Name = "Btn_next";
            this.Btn_next.Size = new System.Drawing.Size(86, 23);
            this.Btn_next.TabIndex = 23;
            this.Btn_next.Text = "Next";
            this.Btn_next.UseVisualStyleBackColor = true;
            this.Btn_next.Click += new System.EventHandler(this.Btn_next_Click);
            // 
            // Ms_mainMenuStrip
            // 
            this.Ms_mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.Ms_mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.Ms_mainMenuStrip.Name = "Ms_mainMenuStrip";
            this.Ms_mainMenuStrip.Size = new System.Drawing.Size(596, 24);
            this.Ms_mainMenuStrip.TabIndex = 24;
            this.Ms_mainMenuStrip.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutUsToolStripMenuItem,
            this.ReportABugToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // AboutUsToolStripMenuItem
            // 
            this.AboutUsToolStripMenuItem.Name = "AboutUsToolStripMenuItem";
            this.AboutUsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AboutUsToolStripMenuItem.Text = "About Us";
            this.AboutUsToolStripMenuItem.Click += new System.EventHandler(this.AboutUsToolStripMenuItem_Click);
            // 
            // ReportABugToolStripMenuItem
            // 
            this.ReportABugToolStripMenuItem.Name = "ReportABugToolStripMenuItem";
            this.ReportABugToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ReportABugToolStripMenuItem.Text = "Report a Bug";
            this.ReportABugToolStripMenuItem.Click += new System.EventHandler(this.ReportABugToolStripMenuItem_Click);
            // 
            // Btn_eraseAll
            // 
            this.Btn_eraseAll.Location = new System.Drawing.Point(19, 227);
            this.Btn_eraseAll.Name = "Btn_eraseAll";
            this.Btn_eraseAll.Size = new System.Drawing.Size(90, 23);
            this.Btn_eraseAll.TabIndex = 25;
            this.Btn_eraseAll.Text = "Erase All";
            this.Btn_eraseAll.UseVisualStyleBackColor = true;
            this.Btn_eraseAll.Click += new System.EventHandler(this.Btn_eraseAll_Click);
            // 
            // Btn_erase
            // 
            this.Btn_erase.Location = new System.Drawing.Point(115, 228);
            this.Btn_erase.Name = "Btn_erase";
            this.Btn_erase.Size = new System.Drawing.Size(90, 23);
            this.Btn_erase.TabIndex = 26;
            this.Btn_erase.Text = "Erase Tag";
            this.Btn_erase.UseVisualStyleBackColor = true;
            this.Btn_erase.Click += new System.EventHandler(this.Btn_erase_Click);
            // 
            // Btn_clearOutput
            // 
            this.Btn_clearOutput.Location = new System.Drawing.Point(212, 227);
            this.Btn_clearOutput.Name = "Btn_clearOutput";
            this.Btn_clearOutput.Size = new System.Drawing.Size(86, 23);
            this.Btn_clearOutput.TabIndex = 27;
            this.Btn_clearOutput.Text = "Clear Output";
            this.Btn_clearOutput.UseVisualStyleBackColor = true;
            this.Btn_clearOutput.Click += new System.EventHandler(this.Btn_clearOutput_Click);
            // 
            // Frm_mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 450);
            this.Controls.Add(this.Btn_clearOutput);
            this.Controls.Add(this.Btn_erase);
            this.Controls.Add(this.Btn_eraseAll);
            this.Controls.Add(this.Btn_next);
            this.Controls.Add(this.Btn_write);
            this.Controls.Add(this.Btn_previous);
            this.Controls.Add(this.Chk_year);
            this.Controls.Add(this.Chk_album);
            this.Controls.Add(this.Chk_song);
            this.Controls.Add(this.Chk_artist);
            this.Controls.Add(this.Lbl_year);
            this.Controls.Add(this.Lbl_album);
            this.Controls.Add(this.Lbl_song);
            this.Controls.Add(this.Lbl_artist);
            this.Controls.Add(this.Txt_year);
            this.Controls.Add(this.Txt_album);
            this.Controls.Add(this.Txt_song);
            this.Controls.Add(this.Txt_artist);
            this.Controls.Add(this.Txt_selectedSong);
            this.Controls.Add(this.Lbl_selectedSong);
            this.Controls.Add(this.Lbx_files);
            this.Controls.Add(this.Rtb_output);
            this.Controls.Add(this.Btn_selectFolder);
            this.Controls.Add(this.Txt_folderSelected);
            this.Controls.Add(this.Ms_mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_mainForm";
            this.ShowIcon = false;
            this.Text = "ID3 Tag Editor";
            this.Load += new System.EventHandler(this.Frm_mainForm_Load);
            this.Ms_mainMenuStrip.ResumeLayout(false);
            this.Ms_mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_folderSelected;
        private System.Windows.Forms.Button Btn_selectFolder;
        private System.Windows.Forms.RichTextBox Rtb_output;
        private System.Windows.Forms.ListBox Lbx_files;
        private System.Windows.Forms.Label Lbl_selectedSong;
        private System.Windows.Forms.TextBox Txt_selectedSong;
        private System.Windows.Forms.TextBox Txt_artist;
        private System.Windows.Forms.TextBox Txt_song;
        private System.Windows.Forms.TextBox Txt_album;
        private System.Windows.Forms.TextBox Txt_year;
        private System.Windows.Forms.Label Lbl_artist;
        private System.Windows.Forms.Label Lbl_song;
        private System.Windows.Forms.Label Lbl_album;
        private System.Windows.Forms.Label Lbl_year;
        private System.Windows.Forms.CheckBox Chk_artist;
        private System.Windows.Forms.CheckBox Chk_song;
        private System.Windows.Forms.CheckBox Chk_album;
        private System.Windows.Forms.CheckBox Chk_year;
        private System.Windows.Forms.Button Btn_previous;
        private System.Windows.Forms.Button Btn_write;
        private System.Windows.Forms.Button Btn_next;
        private System.Windows.Forms.MenuStrip Ms_mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReportABugToolStripMenuItem;
        private System.Windows.Forms.Button Btn_eraseAll;
        private System.Windows.Forms.Button Btn_erase;
        private System.Windows.Forms.Button Btn_clearOutput;
    }
}

