using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace GUILayer

{
    enum PopUpType { 
        DATATABLE = 0,
        ARRAYLIST 
    };

    public partial class PopUpBox : Form
    {
        private DataTable _dt = null;
        private ArrayList _ar = null;
        private int[] _fields = null;
        private int[] _fields_to_return = null;
        private PopUpType _pt;
        private bool _ok = false;
        private int _selected_field = -1;
        


        public PopUpBox()
        {
            InitializeComponent();

         }

        public new ArrayList Show()
        {
            base.ShowDialog(); 


            if (_pt == PopUpType.ARRAYLIST)
            {

                if (_selected_field != -1)
                {
                    ArrayList ars = new ArrayList();
                    ars.Add(_ar[_selected_field]);
                    return ars;
                }
                else
                {
                    return null;
                }
            }
            else if ( _pt == PopUpType.DATATABLE )
            {
                if (_selected_field != -1)
                {
                    ArrayList ars = new ArrayList();

                    DataRow dr = _dt.Rows[_selected_field];


                    foreach (int st in _fields_to_return)
                    {
                        ars.Add(dr[st]);
                    }
                    return ars;
                }
                else
                {
                    return null;
                }

            }

            return null;
        }

        public void SetDataTable(DataTable dt, int[] a,int [] b)
        {
            _dt = dt;
            _fields = (int[])a;
            this._fields_to_return = (int[])b;
            _pt = PopUpType.DATATABLE;

            foreach (DataRow dr in _dt.Rows)
            {
                String prompt = "";
                foreach (int s in a)
                {
                    prompt += dr[s] + " ";
                    
                }
               searchlistbox.Items.Add(prompt);

            }
        }

        public void SetArrayList(ArrayList ar)
        {
            _ar = ar;
           
            _pt = PopUpType.ARRAYLIST;

            foreach (object obj in _ar)
            {
                searchlistbox.Items.Add(obj.ToString());
            }
        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {
            string x = searchtxt.Text;

            int _index = searchlistbox.Items.Count;

            int i = 0;
            while (i < _index)
            {
                string r = searchlistbox.Items[i].ToString();

                string trs = r.Substring(0, x.Length);
 
                if (trs == x)
                {
                    searchlistbox.SelectedIndex = i;
                    this._selected_field = i;

                    break;
                }
                i++;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _ok = true;
            base.Close();
        }

        private void searchlistbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._selected_field = searchlistbox.SelectedIndex;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
