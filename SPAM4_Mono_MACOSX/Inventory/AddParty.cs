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
    public partial class AddParty : Form
    {
        public AddParty()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            updatebtn.Enabled = true;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            updatebtn.Enabled = true;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            string code = vad.Text;
            string desc = desctxt.Text;
            string acc = accodetxt.Text;
            string ad1 = ad1txt.Text;
            string ad2 = ad2txt.Text;
            string ph = phtxt.Text;
            string fax = faxtxt.Text;
            string city = citytxt.Text;
            string de = detxt.Text;

            if (!Validator.IsValidString(code))
            {
                GUIutils.ShowMessage(" COde Is Not Valid");
                return;
            }

            if (Party.Isexist(code))
            {
                GUIutils.ShowMessage(" Code Already Exists");
                return;
            }

            if (!Validator.IsValidString(desc))
            {
                GUIutils.ShowMessage(" Name Is Not Valid");
                return;
            }

           
            if (!Validator.IsValidString(ad1))
            {
                GUIutils.ShowMessage(" Address Is Not Valid");
                return;
            }
           
            if (!Validator.IsValidString(ph))
            {
                GUIutils.ShowMessage(" Phone No Is Not Valid");
                return;
            }
            
            if (!Validator.IsValidString(city))
            {
                GUIutils.ShowMessage(" City Is Not Valid");
                return;
            }

           


           Party.AddParty(code, desc, acc, ad1, ad2, ph,fax, city,de);
            vad.Clear();
            desctxt.Clear();
            accodetxt.Clear();
            ad1txt.Clear();
            ad2txt.Clear();
            phtxt.Clear();
            faxtxt.Clear();
            citytxt.Clear();
            detxt.Clear();
        }

        private void clickbtn_Click(object sender, EventArgs e)
        {
            DataTable dts = Party.ListParty();
            ArrayList arr = GetSelectedItem.ItemSelect(dts, new int[] { 1 }, new int[] { 0 });

            if (arr == null)
            {
                return;
            }

            string tacc_code = arr[0].ToString().Trim();
            DataTable dt = Party.GetParty(tacc_code);
            if (dt.Rows.Count == 0)
            {
                GUIutils.ShowMessage("Party code doesnt exist");
                return;
            }

            DataRow dr = dt.Rows[0];

            vad.Text = dr["pcode"].ToString().Trim();
            desctxt.Text = dr["pname"].ToString().Trim();
            accodetxt.Text = dr["p_acccode"].ToString().Trim();
            ad1txt.Text  = dr["address1"].ToString().Trim();
            ad2txt.Text = dr["address2"].ToString().Trim();
            phtxt.Text = dr["phone"].ToString().Trim();
            faxtxt.Text = dr["fax"].ToString().Trim();
            citytxt.Text = dr["city"].ToString().Trim();
            detxt.Text = dr["otherdetail"].ToString().Trim();


            deletebtn.Enabled = true;
            addbtn.Enabled = false;
            updatebtn.Enabled = false;
        }

        private void codetxt_TextChanged(object sender, EventArgs e)
        {

            updatebtn.Enabled = false;

        }

        private void codetxt_Leave(object sender, EventArgs e)
        {
            string code = vad.Text.Trim();

            if (Party.Isexist(code))
            {
                GUIutils.ShowMessage("Code  exist");

            }
            else
            {
                desctxt.Clear();
                accodetxt.Clear();
                ad1txt.Clear();
                ad2txt.Clear();
                phtxt.Clear();
                faxtxt.Clear();
                citytxt.Clear();
                detxt.Clear();
            }

            DataTable dt = Party.GetParty(code);
            if (dt.Rows.Count == 0)
            {
                GUIutils.ShowMessage("Party code doesnt exist");
                return;
            }

            DataRow dr = dt.Rows[0];

            //codetxt.Text = dr["pcode"].ToString().Trim();
            desctxt.Text = dr["pname"].ToString().Trim();
            accodetxt.Text = dr["p_acccode"].ToString().Trim();
            ad1txt.Text = dr["address1"].ToString().Trim();
            ad2txt.Text = dr["address2"].ToString().Trim();
            phtxt.Text = dr["phone"].ToString().Trim();
            faxtxt.Text = dr["fax"].ToString().Trim();
            citytxt.Text = dr["city"].ToString().Trim();
            detxt.Text = dr["otherdetail"].ToString().Trim();


            deletebtn.Enabled = true;
            addbtn.Enabled = true;
            updatebtn.Enabled = false;
        }

        private void desctxt_TextChanged(object sender, EventArgs e)
        {
            updatebtn.Enabled = true;
        }

        private void accodetxt_TextChanged(object sender, EventArgs e)
        {
            updatebtn.Enabled = true;
        }

        private void ad1txt_TextChanged(object sender, EventArgs e)
        {
            updatebtn.Enabled = true;
        }

        private void ad2txt_TextChanged(object sender, EventArgs e)
        {
            updatebtn.Enabled = true;
        }

        private void faxtxt_TextChanged(object sender, EventArgs e)
        {
            updatebtn.Enabled = true;
        }

        private void citytxt_TextChanged(object sender, EventArgs e)
        {
            updatebtn.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AddParty_Load(object sender, EventArgs e)
        {
            updatebtn.Enabled  = false;
            deletebtn.Enabled = false;
            addbtn.Enabled = true;
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            string code = vad.Text;
            string desc = desctxt.Text;
            string acc = accodetxt.Text;
            string ad1 = ad1txt.Text;
            string ad2 = ad2txt.Text;
            string ph = phtxt.Text;
            string fax = faxtxt.Text;
            string city = citytxt.Text;
            string de = detxt.Text;

            if (!Validator.IsValidString(code))
            {
                GUIutils.ShowMessage(" Code Is Not Valid");
                return;
            }

            if (!Party.Isexist(code))
            {
                GUIutils.ShowMessage(" Code doesnt Exists");
                return;
            }

            if (!Validator.IsValidString(desc))
            {
                GUIutils.ShowMessage(" Name Is Not Valid");
                return;
            }

            if (!Validator.IsValidString(acc))
            {
                GUIutils.ShowMessage(" Account code Is Not Valid");
                return;
            }
            if (!Validator.IsValidString(ad1))
            {
                GUIutils.ShowMessage(" Address Is Not Valid");
                return;
            }
            if (!Validator.IsValidString(ad2))
            {
                GUIutils.ShowMessage(" Address Is Not Valid");
                return;
            }
            if (!Validator.IsValidString(ph))
            {
                GUIutils.ShowMessage(" Phone No Is Not Valid");
                return;
            }
            if (!Validator.IsValidString(fax))
            {
                GUIutils.ShowMessage(" fax No Is Not Valid");
                return;
            }
            if (!Validator.IsValidString(city))
            {
                GUIutils.ShowMessage(" City Is Not Valid");
                return;
            }

            if (!Validator.IsValidString(de))
            {
                GUIutils.ShowMessage(" detail Is Not Valid");
                return;
            }


            Party.UpdateParty(code, desc, acc, ad1, ad2, ph, fax, city, de);


            vad.Clear();
            desctxt.Clear();
            accodetxt.Clear();
            ad1txt.Clear();
            ad2txt.Clear();
            phtxt.Clear();
            faxtxt.Clear();
            citytxt.Clear();
            detxt.Clear();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            string code = vad.Text.Trim();
            if (!Validator.IsValidString(code))
            {
                GUIutils.ShowMessage(" Code Is Not Valid");
                return;
            }

            if (!Party.Isexist(code))
            {
                GUIutils.ShowMessage(" Code doesnt Exists");
                return;
            }

            Party.DeleteParty(code);
            vad.Clear();
            desctxt.Clear();
            accodetxt.Clear();
            ad1txt.Clear();
            ad2txt.Clear();
            phtxt.Clear();
            faxtxt.Clear();
            citytxt.Clear();
            detxt.Clear();

            addbtn.Enabled = true;
            updatebtn.Enabled = false;

        }




    }
}
