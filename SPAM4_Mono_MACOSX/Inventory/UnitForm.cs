using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using InventoryLayer;
using ValidationLayer;
using GUILayer;


namespace Inventory
{
    public partial class UnitForm : Form
    {
        public UnitForm()
        {
            InitializeComponent();
        }

        private void UnitForm_Load(object sender, EventArgs e)
        {
            deletebtn.Enabled = false;
            updatebtn.Enabled = false;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            string ucode = codetxt.Text.ToLower();
            string udesc = desctxt.Text;

            if (!Validator.IsValidString(ucode))
            {
                GUIutils.ShowMessage("Account COde Is Not Valid");
                return;
            }
            
            if (Unit.Isexist(ucode))
            {
                GUIutils.ShowMessage("Account Code Already Exists");
                return;
            }

            if (!Validator.IsValidString(udesc))
            {
                GUIutils.ShowMessage("Account Name Is Not Valid");
                return;
            }


            Unit.AddUnit(ucode, udesc);
            codetxt.Clear();
            desctxt.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dts = Unit.ListUnit();
            ArrayList arr = GetSelectedItem.ItemSelect(dts, new int[] { 1 }, new int[] { 0 });

            if (arr == null)
            {
                return;
            }

            string tacc_code = arr[0].ToString();
            DataTable dt = Unit.GetUnit(tacc_code);
            if (dt.Rows.Count == 0)
            {
                GUIutils.ShowMessage("Group Type code doesnt exist");
                return;
            }

            DataRow dr = dt.Rows[0];

            codetxt.Text = dr["ucode"].ToString();
            desctxt.Text = dr["uname"].ToString();

            deletebtn.Enabled = true;
            addbtn.Enabled = false;
        }

        private void desctxt_TextChanged(object sender, EventArgs e)
        {
            updatebtn.Enabled = true;
            deletebtn.Enabled = true;
        }

        private void codetxt_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void codetxt_Leave(object sender, EventArgs e)
        {
            string ucode = codetxt.Text;

            if (!Validator.IsValidString(ucode))
            {
                GUIutils.ShowMessage("Account COde Is Not Valid");
                return;
            }

            if (!Unit.Isexist(ucode))
            {
                //GUIutils.ShowMessage("Account Code doesnt  Exists");
                return;
            }

            DataTable dt = Unit.GetUnit(ucode);
            DataRow dr = dt.Rows[0];


            string desc = dr["uname"] as string;
            desctxt.Text = desc.ToString();

            deletebtn.Enabled = true;
            updatebtn.Enabled = false;
        }

        private void codetxt_TextChanged(object sender, EventArgs e)
        {
            addbtn.Enabled = true;
            updatebtn.Enabled = false;
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
           
            if (!Unit.Isexist(code))
            {
                GUIutils.ShowMessage("Account Code Doesn't Exists");
                return;
            }

            if (!Validator.IsValidString(name))
            {
                GUIutils.ShowMessage("Account Name Is Not Valid");
                return;
            }


            Unit.UpdateUnit(code, name);
            codetxt.Clear();
            desctxt.Clear();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            string code = codetxt.Text;

            DataTable dt = Unit.GetUnit(code);
            if (dt.Rows.Count == 0)
            {
                GUIutils.ShowMessage("Account Type Code Doesn't Exist");
                return;
            }

            Unit.DeleteUnit(code);
            codetxt.Clear();
            desctxt.Clear();

        }
    }
}
