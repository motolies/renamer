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
    public partial class WriteNumber : Form
    {
        public Mainform mf;
        public WriteNumber()
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
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void tb_StartNumber_KeyDown(object sender, KeyEventArgs e)
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
            try
            {
                switch (comboBox.Text)
                {
                    case "이름 뒤에 번호붙임":
                        mf.Chng(tb_NumberComma.Text, tb_StartNumber.Text, "뒤", "writenumber");
                        this.Close();
                        break;
                    case "이름 앞에 번호붙임":
                        mf.Chng(tb_NumberComma.Text, tb_StartNumber.Text, "앞", "writenumber");
                        this.Close();
                        break;
                }

            }
            catch { }
        }
    }
}
