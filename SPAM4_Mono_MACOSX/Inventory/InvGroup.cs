using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using InventoryLayer;
using ValidationLayer;
using GUILayer;

namespace Inventory
{
    public partial class InvGroup : Form
    {
        public InvGroup()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            addbtn.Enabled = true;
            updatebtn.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string icode = codetxt.Text;
            string idesc = desctxt.Text;

            if (!Validator.IsValidString(icode))
            {
                GUIutils.ShowMessage("Account COde Is Not Valid");
                return;
            }
            if (icode.Length != 3)
            {
                GUIutils.ShowMessage("Account Code Should be Three Characters");
                return;
            }
            if (Group.Isexist(icode))
            {
                GUIutils.ShowMessage("Account Code Already Exists");
                return;
            }

            if (!Validator.IsValidString(idesc))
            {
                GUIutils.ShowMessage("Account Name Is Not Valid");
                return;
            }

           
            Group.AddGroup(icode, idesc);
            codetxt.Clear();
            desctxt.Clear();
        }

        private void codetxt_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void codetxt_Leave(object sender, EventArgs e)
        {
            string icode = codetxt.Text;

            if (!Validator.IsValidString(icode))
            {
                GUIutils.ShowMessage("Account COde Is Not Valid");
                return;
            }
            if (icode.Length != 3)
            {
                GUIutils.ShowMessage("Account Code Should be Three Characters");
                return;
            }
            if (!Group.Isexist(icode))
            {
                //GUIutils.ShowMessage("Account Code doesnt  Exists");
                return;
            }

            DataTable dt = Group.GetGroup(icode);
            DataRow dr = dt.Rows[0];


            string desc = dr["gname"] as string;
            desctxt.Text = desc.ToString();

            deletebtn.Enabled = true;
            updatebtn.Enabled = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dts = Group.ListGroup();
            ArrayList arr = GetSelectedItem.ItemSelect(dts, new int[] { 1 }, new int[] { 0 });

            if (arr == null)
            {
                return;
            }

            string tacc_code = arr[0].ToString();
            DataTable dt = Group.GetGroup(tacc_code);
            if (dt.Rows.Count == 0)
            {
                GUIutils.ShowMessage("Group Type code doesnt exist");
                return;
            }

            DataRow dr = dt.Rows[0];

            codetxt.Text = dr["gcode"].ToString();
            desctxt.Text = dr["gname"].ToString();

            deletebtn.Enabled = true;
            addbtn.Enabled = false;
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            string code = codetxt.Text;
            string name = desctxt.Text;
           

            if (!Validator.IsValidString(code))
            {
                GUIutils.ShowMessage("Account COde Is Not Valid");
                return;
            }
            if (code.Length != 3)
            {
                GUIutils.ShowMessage("Account Code Should be Three Characters");
                return;
            }
            if (!Group.Isexist(code))
            {
                GUIutils.ShowMessage("Account Code Doesn't Exists");
                return;
            }

            if (!Validator.IsValidString(name))
            {
                GUIutils.ShowMessage("Account Name Is Not Valid");
                return;
            }

                        
            Group.UpdateGroup(code, name);
            codetxt.Clear();
            desctxt.Clear();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            string code = codetxt.Text;

            DataTable dt = Group.GetGroup(code);
            if (dt.Rows.Count == 0)
            {
                GUIutils.ShowMessage("Account Type Code Doesn't Exist");
                return;
            }

            Group.DeleteGroup(code);
            codetxt.Clear();
            desctxt.Clear();

        }

        private void InvGroup_Load(object sender, EventArgs e)
        {
            deletebtn.Enabled = false;
            updatebtn.Enabled = false;
        }

        private void desctxt_TextChanged(object sender, EventArgs e)
        {
            updatebtn.Enabled = true;
            deletebtn.Enabled = false;
        }
    }
}
