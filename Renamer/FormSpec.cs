using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Renamer
{
    class FormSpec
    {


        public static void ini(Form Form)
        {
            Form.StartPosition = FormStartPosition.CenterScreen;
            Form.FormBorderStyle = FormBorderStyle.FixedSingle;
            Form.MaximizeBox = false;
            Form.MinimizeBox = false;
            Form.ShowIcon = false;
        }


    }
}
