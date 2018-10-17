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
            this.SuspendLayout();
            // 
            // Txt_folderSelected
            // 
            this.Txt_folderSelected.Location = new System.Drawing.Point(100, 18);
            this.Txt_folderSelected.Name = "Txt_folderSelected";
            this.Txt_folderSelected.Size = new System.Drawing.Size(191, 20);
            this.Txt_folderSelected.TabIndex = 0;
            this.Txt_folderSelected.TextChanged += new System.EventHandler(this.Txt_folderSelected_TextChanged);
            // 
            // Btn_selectFolder
            // 
            this.Btn_selectFolder.Location = new System.Drawing.Point(12, 16);
            this.Btn_selectFolder.Name = "Btn_selectFolder";
            this.Btn_selectFolder.Size = new System.Drawing.Size(82, 23);
            this.Btn_selectFolder.TabIndex = 1;
            this.Btn_selectFolder.Text = "Select Folder";
            this.Btn_selectFolder.UseVisualStyleBackColor = true;
            this.Btn_selectFolder.Click += new System.EventHandler(this.Btn_selectFolder_Click);
            // 
            // Rtb_output
            // 
            this.Rtb_output.Location = new System.Drawing.Point(12, 342);
            this.Rtb_output.Name = "Rtb_output";
            this.Rtb_output.ReadOnly = true;
            this.Rtb_output.Size = new System.Drawing.Size(279, 96);
            this.Rtb_output.TabIndex = 2;
            this.Rtb_output.Text = "";
            // 
            // Lbx_files
            // 
            this.Lbx_files.FormattingEnabled = true;
            this.Lbx_files.Location = new System.Drawing.Point(297, 18);
            this.Lbx_files.Name = "Lbx_files";
            this.Lbx_files.Size = new System.Drawing.Size(282, 420);
            this.Lbx_files.TabIndex = 3;
            // 
            // Frm_mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 450);
            this.Controls.Add(this.Lbx_files);
            this.Controls.Add(this.Rtb_output);
            this.Controls.Add(this.Btn_selectFolder);
            this.Controls.Add(this.Txt_folderSelected);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_mainForm";
            this.ShowIcon = false;
            this.Text = "ID3 Tag Editor";
            this.Load += new System.EventHandler(this.Frm_mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_folderSelected;
        private System.Windows.Forms.Button Btn_selectFolder;
        private System.Windows.Forms.RichTextBox Rtb_output;
        private System.Windows.Forms.ListBox Lbx_files;
    }
}

