using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Renamer
{
    public partial class usebutton : UserControl
    {
        public usebutton()
        {
            InitializeComponent();
            label.BackColor = SystemColors.ActiveCaption;
        }

        #region
        //버튼 이벤트 부분///////////////////////////////////////////////
        public delegate void UsebuttonClick(object sender, EventArgs e);
        public event UsebuttonClick ButtonClick;

        private void label_Click(object sender, EventArgs e)
        {
            if (ButtonClick != null)
                ButtonClick.Invoke(this, e);
        }
        /////////////////////////////////////////////////////////////////
        #endregion

        private void label_MouseMove(object sender, MouseEventArgs e)
        {
            label.BackColor = Color.FromArgb(115,135,157);
        }

        private void label_MouseLeave(object sender, EventArgs e)
        {
            label.BackColor = SystemColors.ActiveCaption;
        }

        private void label_MouseDown(object sender, MouseEventArgs e)
        {
            label.BackColor = Color.FromArgb(230, 172, 104);
        }
        //마우스 클릭
        //label.BackColor = Color.FromArgb(230,172,104);
        public string EditText
        {
            get { return label.Text; }
            set { label.Text = value; }
        }

       

        

        

    }
}
