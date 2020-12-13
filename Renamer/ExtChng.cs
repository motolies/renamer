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
    public partial class ExtChng : Form
    {
        public Mainform mf;
        public ExtChng()
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

        private void tb_ExtChng_KeyDown(object sender, KeyEventArgs e)
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
            mf.Chng(tb_ExtChng.Text, "", "", "extchng");
            this.Close();
        }
     
    }
}
