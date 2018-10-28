using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ID3TagEditor
{
    public partial class Frm_settingsForm : Form
    {
        public Frm_settingsForm()
        {
            InitializeComponent();
            Chk_Tooltips.Checked = Properties.Settings.Default.EnableToolTips;
            Chk_ContOnWrite.Checked = Properties.Settings.Default.ContOnWrite;
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_apply_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.EnableToolTips = Chk_Tooltips.Checked;
            Properties.Settings.Default.ContOnWrite = Chk_ContOnWrite.Checked;
            Properties.Settings.Default.Save();
            Btn_apply.Enabled = false;
        }

        private void Chk_Tooltips_CheckedChanged(object sender, EventArgs e)
        {
            Btn_apply.Enabled = true;
        }

        private void Chk_ContOnWrite_CheckedChanged(object sender, EventArgs e)
        {
            Btn_apply.Enabled = true;
        }
    }
}
