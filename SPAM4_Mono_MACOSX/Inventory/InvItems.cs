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
    public partial class InvItems : Form
    {
        string ucode;
        string gcode;
        string pcode;

        public InvItems()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            deletebtn.Enabled = true;
            updatebtn.Enabled = true;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            deletebtn.Enabled = true;
            updatebtn.Enabled = true;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            string icode = codetxt.Text;
            string idesc = desctxt.Text;
            string grp = grouptxt.Text;
            string vend = vendortxt.Text;
            string unit = unittxt.Text;


            if (!Validator.IsValidString(icode))
            {
                GUIutils.ShowMessage(" COde Is Not Valid");
                return;
            }

            if (Items.Isexist(icode))
            {
                GUIutils.ShowMessage(" Code Already Exists");
                return;
            }

            if (!Validator.IsValidString(idesc))
            {
                GUIutils.ShowMessage(" Name Is Not Valid");
                return;
            }

            if (!Validator.IsValidNumber(ratetxt.Text))
            {
                GUIutils.ShowMessage("Rate should be Numeric Value");
                return;
            }

            if (!Validator.IsValidNumber(qntytxt.Text))
            {
                GUIutils.ShowMessage("Quantity should be Numeric Value");
                return;
            }

            if (!Validator.IsValidNumber(svaltxt.Text))
            {
                GUIutils.ShowMessage("StockValue  should be Numeric Value");
                return;
            }

            decimal rate = Convert.ToDecimal(ratetxt.Text);
            decimal qty = Convert.ToDecimal(qntytxt.Text);
            decimal val = Convert.ToDecimal(svaltxt.Text);


            Items.AddItem(icode, idesc, gcode, ucode, rate, qty, val, pcode);
            codetxt.Clear();
            desctxt.Clear();
            grouptxt.Clear();
            unittxt.Clear();
            qntytxt.Clear();
            svaltxt.Clear();
            vendortxt.Clear();
            ratetxt.Clear();
        }

        private void InvItems_Load(object sender, EventArgs e)
        {
            deletebtn.Enabled = false;
            updatebtn.Enabled = false;
        }

        private void ccbtn_Click(object sender, EventArgs e)
        {
            DataTable dts = Items.ListItem();
            ArrayList arr = GetSelectedItem.ItemSelect(dts, new int[] { 1 }, new int[] { 0 });

            if (arr == null)
            {
                return;
            }

            string tacc_code = arr[0].ToString();
            DataTable dt = Items.GetItem(tacc_code);
            if (dt.Rows.Count == 0)
            {
                GUIutils.ShowMessage("Group Type code doesnt exist");
                return;
            }

            DataRow dr = dt.Rows[0];

            codetxt.Text = dr["itemcode"].ToString();
            desctxt.Text = dr["itemdesc"].ToString();
            string grp = dr["itemgp"] as string;
            string unit = dr["unit"] as string;
            string vend = dr["vendor"] as string;

            DataTable dt1 = Group.GetGroup(grp);
            if (dt1.Rows.Count == 0)
            {
                GUIutils.ShowMessage("Group Type code doesnt exist");
                return;
            }

            DataRow dr1 = dt1.Rows[0];

            
            grouptxt.Text = dr1["gname"].ToString();

            DataTable dt2 = Unit.GetUnit(unit);
            if (dt2.Rows.Count == 0)
            {
                GUIutils.ShowMessage("Group Type code doesnt exist");
                return;
            }

            DataRow dr2 = dt2.Rows[0];
           
            unittxt.Text = dr2["uname"].ToString();

            DataTable dt3 = Party.GetParty(vend);
            if (dt3.Rows.Count == 0)
            {
                GUIutils.ShowMessage("Group Type code doesnt exist");
                return;
            }

            DataRow dr3 = dt3.Rows[0];
            vendortxt.Text = dr3["pname"].ToString();
                                 
            ratetxt.Text = dr["rate"].ToString();
            qntytxt.Text = dr["qty"].ToString();
            svaltxt.Text = dr["stockvalue"].ToString();


            deletebtn.Enabled = true;
            addbtn.Enabled = false;
            updatebtn.Enabled = false;
            
        }

        private void gcbtn_Click(object sender, EventArgs e)
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

            gcode = dr["gcode"].ToString();
            grouptxt.Text = dr["gname"].ToString();


        }

        private void vcbtn_Click(object sender, EventArgs e)
        {
             DataTable dts = Party.ListParty();
             ArrayList arr = GetSelectedItem.ItemSelect(dts, new int[] { 1 }, new int[] { 0 });

             if (arr == null)
             {
                 return;
             }

             string tacc_code = arr[0].ToString();
             DataTable dt = Party.GetParty(tacc_code);
             if (dt.Rows.Count == 0)
             {
                 GUIutils.ShowMessage("Group Type code doesnt exist");
                 return;
             }

             DataRow dr = dt.Rows[0];

             pcode = dr["pcode"].ToString();
             vendortxt.Text = dr["pname"].ToString();

        }

        private void ucbtn_Click(object sender, EventArgs e)
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
                GUIutils.ShowMessage("Unit code doesnt exist");
                return;
            }

            DataRow dr = dt.Rows[0];
            ucode = dr["ucode"].ToString();
            unittxt.Text = dr["uname"].ToString();

        }

        private void grouptxt_Leave(object sender, EventArgs e)
        {
            string gp = grouptxt.Text;
            bool flag = false;
            DataTable dt = Group.ListGroup();
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["gname"].ToString().Trim() == gp.Trim())
                {
                    flag = true;
                    return;
                }

               
            }

            if (flag == false)
            {
                GUIutils.ShowMessage("Group doesnt exist");
                grouptxt.Clear();
                return;
            }


        }

        private void unittxt_Leave(object sender, EventArgs e)
        {
            string unit = unittxt.Text;
            bool flag = false;
            DataTable dt = Unit.ListUnit();
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["uname"].ToString().Trim() == unit.Trim())
                {
                    flag = true;
                    return;
                }


            }

            if (flag == false)
            {
                GUIutils.ShowMessage(" Unit doesnt exist ");
                unittxt.Clear();
                
                return;

            }

        }

        private void grouptxt_TextChanged(object sender, EventArgs e)
        {
            deletebtn.Enabled = true;
            updatebtn.Enabled = true;
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            string icode = codetxt.Text;
            string idesc = desctxt.Text;
            string grp = grouptxt.Text;
            string vend = vendortxt.Text;
            string unit = unittxt.Text;


            if (!Validator.IsValidString(icode))
            {
                GUIutils.ShowMessage("Item COde Is Not Valid");
                return;
            }

            if (!Items.Isexist(icode))
            {
                GUIutils.ShowMessage("Item Code doesnt  Exists");
                return;
            }

            if (!Validator.IsValidString(idesc))
            {
                GUIutils.ShowMessage("Item Name Is Not Valid");
                return;
            }

            if (!Validator.IsValidNumber(ratetxt.Text))
            {
                GUIutils.ShowMessage("Rate should be Numeric Value");
                return;
            }

            if (!Validator.IsValidNumber(qntytxt.Text))
            {
                GUIutils.ShowMessage("Quantity should be Numeric Value");
                return;
            }

            if (!Validator.IsValidNumber(svaltxt.Text))
            {
                GUIutils.ShowMessage("Sock Value should be Numeric Value");
                return;
            }

            decimal rate = Convert.ToDecimal(ratetxt.Text);
            decimal qty = Convert.ToDecimal(qntytxt.Text);
            decimal val = Convert.ToDecimal(svaltxt.Text);

            DataTable dt = Group.ListGroup();
            foreach (DataRow dr in dt.Rows)
            {
                if (grp.Trim() == dr["gname"].ToString().Trim())
                {
                    gcode = dr["gcode"].ToString().Trim();
                }

               
            }

            DataTable dt1 = Unit.ListUnit();
            foreach (DataRow dr1 in dt1.Rows)
            {
                if (unit.Trim() == dr1["uname"].ToString().Trim())
                {
                    ucode = dr1["ucode"].ToString().Trim();
                }


            }

            DataTable dt3 = Party.ListParty();
            foreach (DataRow dr3 in dt3.Rows)
            {
                if (vend.Trim() == dr3["pname"].ToString().Trim())
                {
                    pcode = dr3["pcode"].ToString().Trim();
                }


            }

            Items.UpdateItem(icode, idesc, gcode, ucode, rate, qty, val, pcode);
            codetxt.Clear();
            desctxt.Clear();
            grouptxt.Clear();
            unittxt.Clear();
            qntytxt.Clear();
            svaltxt.Clear();
            vendortxt.Clear();
            ratetxt.Clear();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            string code = codetxt.Text;

            DataTable dt = Items.GetItem(code);
            if (dt.Rows.Count == 0)
            {
                GUIutils.ShowMessage("Item Code Doesn't Exist");
                return;
            }

           Items.DeleteItem(code);
            codetxt.Clear();
            desctxt.Clear();
            grouptxt.Clear();
            unittxt.Clear();
            qntytxt.Clear();
            svaltxt.Clear();
            vendortxt.Clear();
            ratetxt.Clear();

        }

        private void codetxt_Leave(object sender, EventArgs e)
        {
            string icode = codetxt.Text;

            if (!Validator.IsValidString(icode))
            {
                GUIutils.ShowMessage("Item COde Is Not Valid");
                return;
            }
           
            if (!Items.Isexist(icode))
            {
                //GUIutils.ShowMessage("Account Code doesnt  Exists");
                return;
            }

            DataTable dt = Items.GetItem(icode);
            DataRow dr = dt.Rows[0];


            string desc = dr["itemdesc"] as string;
            string grp = dr["itemgp"] as string;
            string unit = dr["unit"] as string;
            decimal rate = Convert.ToDecimal(dr["rate"] as object);
            decimal qty = Convert.ToDecimal(dr["qty"] as object);
            decimal val = Convert.ToDecimal(dr["stockvalue"] as object);
            string vend = dr["vendor"] as string;

            DataTable dt1 = Group.GetGroup(grp);
            if (dt1.Rows.Count == 0)
            {
                GUIutils.ShowMessage("Group Type code doesnt exist");
                return;
            }

            DataRow dr1 = dt1.Rows[0];

            
            grouptxt.Text = dr1["gname"].ToString();

            DataTable dt2 = Unit.GetUnit(unit);
            if (dt2.Rows.Count == 0)
            {
                GUIutils.ShowMessage("Group Type code doesnt exist");
                return;
            }

            DataRow dr2 = dt2.Rows[0];
            
            unittxt.Text = dr2["uname"].ToString();


            DataTable dt3 = Party.GetParty(vend);
            if (dt3.Rows.Count == 0)
            {
                GUIutils.ShowMessage("Group Type code doesnt exist");
                return;
            }

            DataRow dr3 = dt3.Rows[0];

            vendortxt.Text = dr3["pname"].ToString();

            desctxt.Text = desc.ToString();
           
            qntytxt.Text = qty.ToString();
            svaltxt.Text = val.ToString();
            vendortxt.Text = vend.ToString();
            ratetxt.Text = rate.ToString();

            desctxt.Clear();
            grouptxt.Clear();
            unittxt.Clear();
            qntytxt.Clear();
            svaltxt.Clear();
            vendortxt.Clear();
            ratetxt.Clear();

            deletebtn.Enabled = true;
            updatebtn.Enabled = true;

        }

        private void desctxt_TextChanged(object sender, EventArgs e)
        {
            deletebtn.Enabled = true;
            updatebtn.Enabled = true;
        }

        private void vendortxt_Leave(object sender, EventArgs e)
        {
            string ven = vendortxt.Text;
            bool flag = false;
            DataTable dt = Party.ListParty();
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["pname"].ToString().Trim() == ven.Trim())
                {
                    flag = true;
                    return;
                }


            }

            if (flag == false)
            {
                GUIutils.ShowMessage(" vendor doesnt exist ");
                unittxt.Clear();

                return;

            }

            deletebtn.Enabled = true;
            updatebtn.Enabled = true;
        }

        private void codetxt_TextChanged(object sender, EventArgs e)
        {
            addbtn.Enabled = true;
            updatebtn.Enabled = false;
            deletebtn.Enabled = false;
        }

        private void unittxt_TextChanged(object sender, EventArgs e)
        {
            deletebtn.Enabled = true;
            updatebtn.Enabled = true;
        }

        private void qntytxt_TextChanged(object sender, EventArgs e)
        {
            deletebtn.Enabled = true;
            updatebtn.Enabled = true;
        }

        private void svaltxt_TextChanged(object sender, EventArgs e)
        {
            deletebtn.Enabled = true;
            updatebtn.Enabled = true;
        }
    }
}