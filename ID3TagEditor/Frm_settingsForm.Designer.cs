namespace ID3TagEditor
{
    partial class Frm_settingsForm
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
            this.Btn_close = new System.Windows.Forms.Button();
            this.Btn_apply = new System.Windows.Forms.Button();
            this.Chk_Tooltips = new System.Windows.Forms.CheckBox();
            this.Chk_ContOnWrite = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Btn_close
            // 
            this.Btn_close.Location = new System.Drawing.Point(282, 100);
            this.Btn_close.Name = "Btn_close";
            this.Btn_close.Size = new System.Drawing.Size(75, 23);
            this.Btn_close.TabIndex = 0;
            this.Btn_close.Text = "Close";
            this.Btn_close.UseVisualStyleBackColor = true;
            this.Btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // Btn_apply
            // 
            this.Btn_apply.Location = new System.Drawing.Point(201, 100);
            this.Btn_apply.Name = "Btn_apply";
            this.Btn_apply.Size = new System.Drawing.Size(75, 23);
            this.Btn_apply.TabIndex = 1;
            this.Btn_apply.Text = "Apply";
            this.Btn_apply.UseVisualStyleBackColor = true;
            this.Btn_apply.Click += new System.EventHandler(this.Btn_apply_Click);
            // 
            // Chk_Tooltips
            // 
            this.Chk_Tooltips.AutoSize = true;
            this.Chk_Tooltips.Location = new System.Drawing.Point(12, 12);
            this.Chk_Tooltips.Name = "Chk_Tooltips";
            this.Chk_Tooltips.Size = new System.Drawing.Size(99, 17);
            this.Chk_Tooltips.TabIndex = 2;
            this.Chk_Tooltips.Text = "Enable Tooltips";
            this.Chk_Tooltips.UseVisualStyleBackColor = true;
            this.Chk_Tooltips.CheckedChanged += new System.EventHandler(this.Chk_Tooltips_CheckedChanged);
            // 
            // Chk_ContOnWrite
            // 
            this.Chk_ContOnWrite.AutoSize = true;
            this.Chk_ContOnWrite.Location = new System.Drawing.Point(12, 35);
            this.Chk_ContOnWrite.Name = "Chk_ContOnWrite";
            this.Chk_ContOnWrite.Size = new System.Drawing.Size(144, 17);
            this.Chk_ContOnWrite.TabIndex = 4;
            this.Chk_ContOnWrite.Text = "Enable Continue on write";
            this.Chk_ContOnWrite.UseVisualStyleBackColor = true;
            this.Chk_ContOnWrite.CheckedChanged += new System.EventHandler(this.Chk_ContOnWrite_CheckedChanged);
            // 
            // Frm_settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 133);
            this.Controls.Add(this.Chk_ContOnWrite);
            this.Controls.Add(this.Chk_Tooltips);
            this.Controls.Add(this.Btn_apply);
            this.Controls.Add(this.Btn_close);
            this.Name = "Frm_settingsForm";
            this.ShowIcon = false;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_close;
        private System.Windows.Forms.Button Btn_apply;
        private System.Windows.Forms.CheckBox Chk_Tooltips;
        private System.Windows.Forms.CheckBox Chk_ContOnWrite;
    }
}