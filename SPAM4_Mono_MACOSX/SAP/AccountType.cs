using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections; 
using GUILayer;
using AccountLayer;
using ValidationLayer;

namespace SAP
{
    public partial class AccountType : Form
    {
        public AccountType()
        {
            InitializeComponent();
        }

        private void PopupBtn_Click(object sender, EventArgs e)
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
                GUIutils.ShowMessage("Account Type code doesnt exist");
                return;
            }

            DataRow dr = dt.Rows[0];
            this.AccTypeCodetxt.Text = dr["A_CODE"].ToString();
            this.AccTypeNametxt.Text = dr["A_DESC"].ToString();
            string t_type = dr["A_TYPE"].ToString();
            if (t_type == "A")
            {
                this.AccClassCombo.SelectedItem = "ASSET";
            }
            else if (t_type == "L")
            {
                this.AccClassCombo.SelectedItem = "LIABILITY";
            }
            else if (t_type == "E")
            {
                this.AccClassCombo.SelectedItem = "EXPENSE";
            }
            else if (t_type == "I")
            {
                this.AccClassCombo.SelectedItem = "INCOME";
            }

            this.CBALtxt.Text = dr["A_CURRB"].ToString();

            this.AddBtn.Enabled = false;
            this.deletebtn.Enabled = true;
            this.UPdatebtn.Enabled = false;
            
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string acc_code = AccTypeCodetxt.Text;
            string acc_name = AccTypeNametxt.Text.ToUpper();
            string acc_class = "";
            string curbal = CBALtxt.Text;

            if (!Validator.IsValidString(acc_code))
            {
                GUIutils.ShowMessage("Account COde Is Not Valid");
                return;
            }
            if (acc_code.Length != 2)
            {
                GUIutils.ShowMessage("Account Code Should be Two Characters");
                return;
            }
            if (Group.Isexist(acc_code))
            {
                GUIutils.ShowMessage("Account Code Already Exists");
                return;
            }

            if (!Validator.IsValidString(acc_name))
            {
                GUIutils.ShowMessage("Account Name Is Not Valid");
                return;
            }

            if (AccClassCombo.SelectedIndex == -1)
            {
                GUIutils.ShowMessage("select An Account Class");
                return;
            }

            acc_class = AccClassCombo.SelectedItem.ToString().Trim().ToUpper();

            if (!(acc_class == "ASSET" || acc_class == "LIABILITY" ||
                acc_class == "EXPENSE" || acc_class == "INCOME"))
            {
                GUIutils.ShowMessage("Account class should be selected");
                return;
            }

            acc_class = acc_class.Substring(0, 1);

            if( !Validator.IsValidNumber(curbal))
            {
                GUIutils.ShowMessage("Current Balance should be Numeric Value");
                return;
            }

            decimal crr = Convert.ToDecimal(curbal);

            Group.AddGroup(acc_code, acc_name, acc_class, crr);
        }

        private void AccountType_Load(object sender, EventArgs e)
        {
            this.UPdatebtn.Enabled = false;
            this.deletebtn.Enabled = false;
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            string acc_code = AccTypeCodetxt.Text;

            DataTable dt = Group.GetGroup(acc_code);
            if (dt.Rows.Count == 0)
            {
                GUIutils.ShowMessage("Account Type Code Doesn't Exist");
                return;
            }
          
            Group.DeleteGroup(acc_code);


        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            this.AccTypeCodetxt.Clear();
            this.AccTypeNametxt.Clear();
            this.AccClassCombo.SelectedIndex = -1;
            this.CBALtxt.Clear();
            this.AddBtn.Enabled = true;
            this.deletebtn.Enabled = false;
            this.UPdatebtn.Enabled = false;
        }

        private void UPdatebtn_Click(object sender, EventArgs e)
        {
            string acc_code = AccTypeCodetxt.Text;
            string acc_name = AccTypeNametxt.Text.ToUpper();
            string acc_class = "";
            string curbal = CBALtxt.Text;

            if (!Validator.IsValidString(acc_code))
            {
                GUIutils.ShowMessage("Account COde Is Not Valid");
                return;
            }
            if (acc_code.Length != 2)
            {
                GUIutils.ShowMessage("Account Code Should be Two Characters");
                return;
            }
            if (!Group.Isexist(acc_code))
            {
                GUIutils.ShowMessage("Account Code Doesn't Exists");
                return;
            }

            if (!Validator.IsValidString(acc_name))
            {
                GUIutils.ShowMessage("Account Name Is Not Valid");
                return;
            }

            if (AccClassCombo.SelectedIndex == -1)
            {
                GUIutils.ShowMessage("select An Account Class");
                return;
            }

            acc_class = AccClassCombo.SelectedItem.ToString().Trim().ToUpper();

            if (!(acc_class == "ASSET" || acc_class == "LIABILITY" ||
                acc_class == "EXPENSE" || acc_class == "INCOME"))
            {
                GUIutils.ShowMessage("Account class should be selected");
                return;
            }

            acc_class = acc_class.Substring(0, 1);

            if (!Validator.IsValidNumber(curbal))
            {
                GUIutils.ShowMessage("Current Balance should be Numeric Value");
                return;
            }

            decimal crr = Convert.ToDecimal(curbal);
            Group.UpdateGroup(acc_code, acc_name, acc_class, crr);
        }

        private void AccTypeCodetxt_TextChanged(object sender, EventArgs e)
        {
            this.AddBtn.Enabled = true;
            this.UPdatebtn.Enabled = false;
            this.deletebtn.Enabled = false;

        }

        private void AccTypeNametxt_TextChanged(object sender, EventArgs e)
        {
            this.deletebtn.Enabled = false;
            this.AddBtn.Enabled = true;
            this.UPdatebtn.Enabled = true;
        }
    }
}
