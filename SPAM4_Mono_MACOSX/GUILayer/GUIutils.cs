using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUILayer
{
    public class GUIutils
    {

        public static DialogResult ShowMessage(string msg)
        {
            return MessageBox.Show(msg,"",MessageBoxButtons.OK);
        }
    }
}
