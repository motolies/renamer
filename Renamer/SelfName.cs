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
    public partial class SelfName : Form
    {
        public Mainform mf;
        

        public SelfName()
        {
            InitializeComponent();
        }
        private void SelfName_Load(object sender, EventArgs e)
        {
            label1.Text = mf.Listview1.SelectedItems[0].SubItems[0].Text+ " (을)를";
            tb_Rename.Text = mf.Listview1.SelectedItems[0].SubItems[0].Text;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            OK();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch { }
        }

        private void tb_Rename_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OK();
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        private void OK()
        {
            mf.Chng(tb_Rename.Text, "", "", "selfname");
            this.Close();
        }

      
    }
}
