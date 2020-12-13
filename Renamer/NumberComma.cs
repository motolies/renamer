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
    public partial class NumberComma : Form
    {
        public Mainform mf;
        public NumberComma()
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

        private void tb_NumberComma_KeyDown(object sender, KeyEventArgs e)
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
            if (comboBox1.Text == "제일 뒷 번호 맞춤")
            {
                mf.Chng(tb_NumberComma.Text, "", "뒤", "numbercomma");
                this.Close();
            }
            if (comboBox1.Text == "제일 앞 번호 맞춤")
            {
                mf.Chng(tb_NumberComma.Text, "", "앞", "numbercomma");
                this.Close();
            }
        }
    }
}
