using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Renamer
{
    public partial class MsgFileFolder : Form
    {
        public Mainform mf;

        public MsgFileFolder()
        {
            InitializeComponent();
        }

        private void btn_File_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                mf.mfChecked = chb_Continue.Checked.ToString();
                mf.mfReturn = "file";

                this.Close();
            }
            catch
            {
                this.Close();
            }
        }

        private void btn_Folder_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                mf.mfChecked = chb_Continue.Checked.ToString();
                mf.mfReturn = "folder";

                this.Close();
            }
            catch
            {
                this.Close();
            }
        }

        private void btn_Cancel_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                mf.mfChecked = chb_Continue.Checked.ToString();
                mf.mfReturn = "cancel";

                this.Close();
            }
            catch
            {
                this.Close();
            }
        }

        private void MsgFileFolder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                mf.mfChecked = chb_Continue.Checked.ToString();
                mf.mfReturn = "cancel";
                this.Close();
            }
        }
    }
}
