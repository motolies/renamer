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
    public partial class GroupDel : Form
    {
        public Mainform mf;
        public GroupDel()
        {
            InitializeComponent();
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

        private void tb_Start_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void tb_Stop_KeyDown(object sender, KeyEventArgs e)
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
            mf.Chng(tb_Start.Text, tb_Stop.Text, "","groupdel");
            this.Close();
        }
    }
}
