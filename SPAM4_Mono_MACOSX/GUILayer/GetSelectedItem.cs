using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;

namespace GUILayer
{
   public class GetSelectedItem
    {

        public static ArrayList ItemSelect(DataTable dt, int[] a, int[] b)
        {
            PopUpBox p = new PopUpBox();
            

            p.SetDataTable(dt, a,b);
            ArrayList st = p.Show();

            return st;
        }
    }
}
