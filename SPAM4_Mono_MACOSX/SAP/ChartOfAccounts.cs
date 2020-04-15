using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using AccountLayer;
using GUILayer;
using ValidationLayer;

namespace SAP
{
    public partial class ChartOfAccounts : Form
    {
        public ChartOfAccounts()
        {
            InitializeComponent();

            this.DRCRCombo.Items.Add("DR");
            this.DRCRCombo.Items.Add("CR");

        }

        private void ChartOfAccounts_Load(object sender, EventArgs e)
        {
           // this.deleteBtn.Enabled = false;
           // this.updatebtn.Enabled = false;

           DataTable dt = Group.ListGroup();
           foreach(DataRow r in dt.Rows)
               AccTypeCombo.Items.Add(r[1]).ToString();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.AccCodetxt.Clear();
            this.AccDestxt.Clear();
            this.AccTypeCombo.SelectedIndex = -1;
            this.DRCRCombo.SelectedIndex = -1;
            this.OPBALTXT.Clear();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string sub_code = AccCodetxt.Text;
            string sub_desc = AccDestxt.Text.ToUpper();
            string s_type = "";
            string opbal = OPBALTXT.Text;
            string s_drcr = "";
            string sname = "";
            string stype = "";

            if (!Validator.IsValidString(sub_code))
            {
                GUIutils.ShowMessage("Account code is not valid");
                return;
            }

            if (sub_code.Length != 5)
            {
                GUIutils.ShowMessage("Account code should be five characters");
                return;
            }

            if (SubGroup.IsSubGroup(sub_code))
            {
                GUIutils.ShowMessage("Account Code already exist");
                return;
            }

            if (!Validator.IsValidString(sub_desc))
            {
                GUIutils.ShowMessage("Account description is not valid");
            }

            if (AccTypeCombo.SelectedIndex == -1)
            {
                GUIutils.ShowMessage("Select an account class");
                return;
            }

           sname = AccTypeCombo.SelectedItem.ToString().ToUpper();
            DataTable dt = Group.ListGroup();
            foreach(DataRow r in dt.Rows)
            {
                if( sname == r[1].ToString().ToUpper())
                {
                    s_type = r[0].ToString();
                    break;
                }
            }
            

           /* if( !(s_type == "ASSET" || s_type == "LIABILITY" ||
                s_type == "EXPENSE" || s_type == "INCOME"))
            {
                GUIutils.ShowMessage("Account class should be selected");
                return;
            }*/

           // s_type = s_type.Substring(0, 1);

            if (!Validator.IsValidNumber(opbal))
            {
                GUIutils.ShowMessage("Opening balance should be numeric");
                return;
            }

            decimal s_opbal = Convert.ToDecimal(opbal);

            if (DRCRCombo.SelectedIndex == -1)
            {
                GUIutils.ShowMessage("Select debit or credit");
                return;
            }

            s_drcr = DRCRCombo.SelectedItem.ToString().ToUpper();

            if (!(s_drcr == "DR" || s_drcr == "CR"))
            {
                GUIutils.ShowMessage("select Debit or Credit");
                return;
            }

            SubGroup.AddSubGroup(sub_code, sub_desc, s_type, s_opbal, s_drcr, "T");
        }

        private void OPBALTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void popupbtn_Click(object sender, EventArgs e)
        {
            DataTable dt = SubGroup.ViewSubGroup();
            ArrayList arr = GetSelectedItem.ItemSelect(
                dt, new int[] { 1 }, new int[] { 0 });

            if (arr == null)
            {
                return;
            }

            
            string tacc_code = arr[0].ToString();
            DataTable dts = SubGroup.GetSubGroup(tacc_code);
            if (dts.Rows.Count == 0)
            {
                GUIutils.ShowMessage("Account code doesnt exist");
                return;
            }

            DataRow dr = dts.Rows[0];
            this.AccCodetxt.Text = dr["S_CODE"].ToString();
            this.AccDestxt.Text = dr["S_DESC"].ToString();
            string sname = dr["S_TYPE"].ToString();
            string s_type = "";
            DataTable dtt = Group.ListGroup();
            foreach (DataRow rw in dtt.Rows)
            {
                if (sname == rw[0].ToString())
                {
                    s_type = rw[1].ToString().ToUpper();
                    break;
                }
            }
            this.AccTypeCombo.SelectedItem = s_type;
            this.AccTypeCombo.Refresh();
            
            /*if (s_type == "A")
            {
                this.AccTypeCombo.SelectedItem = "ASSET";
            }
            else if (s_type == "L")
            {
                this.AccTypeCombo.SelectedItem = "LIABILITY";
            }
            else if (s_type == "E")
            {
                this.AccTypeCombo.SelectedItem = "EXPENSE";
            }
            else if (s_type == "I")
            {
                this.AccTypeCombo.SelectedItem = "INCOME";
            }*/
            this.OPBALTXT.Text = dr["S_OPBAL"].ToString();
            this.DRCRCombo.SelectedItem = dr["S_DRCR"].ToString();
            
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string sub_code = AccCodetxt.Text;

            if (!Validator.IsValidString(sub_code))
            {
                GUIutils.ShowMessage("Enter the valid Account code");
                return;
            }

            if (!SubGroup.IsSubGroup(sub_code))
            {
                GUIutils.ShowMessage("Account code doesn't exist");
                return;
            }

            SubGroup.DeleteSubGroup(sub_code);
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            string sub_code = AccCodetxt.Text;
            string sub_desc = AccDestxt.Text.ToUpper();
            string s_type = "";
            string opbal = OPBALTXT.Text;
            string s_drcr = "";

            if (!Validator.IsValidString(sub_code))
            {
                GUIutils.ShowMessage("Account code is not valid");
                return;
            }

            if (sub_code.Length != 5)
            {
                GUIutils.ShowMessage("Account code should be five characters");
                return;
            }

            if (!SubGroup.IsSubGroup(sub_code))
            {
                GUIutils.ShowMessage("Account Code doesn't exist");
                return;
            }

            if (!Validator.IsValidString(sub_desc))
            {
                GUIutils.ShowMessage("Account description is not valid");
            }

            if (AccTypeCombo.SelectedIndex == -1)
            {
                GUIutils.ShowMessage("Select an account class");
                return;
            }
            string sname = AccTypeCombo.SelectedItem.ToString().ToUpper();
            DataTable dt = Group.ListGroup();
            foreach (DataRow r in dt.Rows)
            {
                if (sname == r[1].ToString())
                {
                    s_type = r[0].ToString();
                    break;
                }
            }
           // s_type = AccTypeCombo.SelectedItem.ToString().ToUpper();

           /* if (!(s_type == "ASSET" || s_type == "LIABILITY" ||
                s_type == "EXPENSE" || s_type == "INCOME"))
            {
                GUIutils.ShowMessage("Account class should be selected");
                return;
            }*/

           // s_type = s_type.Substring(0, 1);

            if (!Validator.IsValidNumber(opbal))
            {
                GUIutils.ShowMessage("Opening balance should be numeric");
                return;
            }

            decimal s_opbal = Convert.ToDecimal(opbal);

            if (DRCRCombo.SelectedIndex == -1)
            {
                GUIutils.ShowMessage("Select debit or credit");
                return;
            }

            s_drcr = DRCRCombo.SelectedItem.ToString().ToUpper();

            if (!(s_drcr == "DR" || s_drcr == "CR"))
            {
                GUIutils.ShowMessage("select Debit or Credit");
                return;
            }

            SubGroup.UpdateSubGroup(sub_code, sub_desc, s_type, s_opbal, s_drcr, "T");
        }

        private void AccTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }
    }
}
