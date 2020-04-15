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
using GUILayer;

namespace Inventory
{
    public partial class Invoice : Form
    {
        string pcode;
        
        public Invoice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string invo = invotxt.Text.ToString().Trim();
            string crd = pcode.ToString().Trim();
            string refno = reftxt.Text.ToString().Trim();
            string date = datepicker.Text.ToString();
            string add = addtxt.Text.ToString().Trim();
            string type = invotypecmb.SelectedItem.ToString().Trim();
            string invotype = "";
            string cterms = termtxt.Text.ToString().Trim();
            decimal total = Convert.ToDecimal(tottxt.Text);
            decimal gtotal = Convert.ToDecimal(gttxt.Text);
           // decimal total = 0;
            //decimal gtotal = 0;
            
            decimal discount = Convert.ToDecimal(distxt.Text);
            decimal freight = Convert.ToDecimal(frgttxt.Text);

            if (type == "Purchase")
            {
                invotype = "PI";
            }
            else if (type == "Sales")
            {
                invotype = "SI";
            }
            else if (type == "Purchase Return")
            {
                invotype = "PR";
            }
            else if (type == "Sales Return")
            {
                invotype = "SR";
            }

            
            Transaction rst = new Transaction();
            List<TransactionEntry> st = new List<TransactionEntry>();

            int rs = this.itemdatagridview.Rows.Count;

            for (int i = 0; i < rs - 1; ++i)
            {                

                DataGridViewRow dr = this.itemdatagridview.Rows[i];
                TransactionEntry jr = new TransactionEntry();

                for (int j = 0; j < 5; ++j)
                {
                    
                    DataGridViewCell c = dr.Cells[j];
                    if (c.Value != null)
                    {
                        if (j == 0)
                        {
                            string iname = c.Value.ToString();

                            DataTable dt2 = Items.ListItem();
                            foreach (DataRow dr2 in dt2.Rows)
                            {
                                if (iname.Trim() == dr2["itemdesc"].ToString().Trim())
                                {
                                    jr.iname = dr2["itemcode"].ToString();
                                }
                            }

                        }
                        else if (j == 1)
                        {
                            jr.qty = Convert.ToDecimal(c.Value as Nullable);
                            
                        }
                        else if (j == 2)
                        {
                            jr.unit = c.Value.ToString();
                        }
                        else if (j == 3)
                        {
                            jr.rate = Convert.ToDecimal(c.Value as Nullable);
                            
                        }
                        else if (j == 4)
                        {
                            jr.val = Convert.ToDecimal(c.Value as Nullable);
                        }
                    }
                    
                    
                }
                
                st.Add(jr);

            }

            rst.invo = invo;
            rst.cr = crd;
            rst.refno = refno;
            rst.date = date;
            rst.add = add;
            rst.type = invotype;
            rst.cterms = cterms;
            rst.total = total;
            rst.gtotal = gtotal;
            rst.discount = discount;
            rst.freight = freight;
            
            rst.rs = st;
            if (!TransactionPoster.DoPost(rst))
            {

                MessageBox.Show("Anomaly in Posting");
                return;
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PurchaseInvoice_Load(object sender, EventArgs e)
        {
            invotypecmb.Items.Add("Purchase");
            invotypecmb.Items.Add("Purchase Return");
            invotypecmb.Items.Add("Sales");
            invotypecmb.Items.Add("Sales Return");

            DataTable dt = Items.ListItem();


            ///////////////////////////////////
            //// Item name 

            DataGridViewComboBoxColumn cw = new
                DataGridViewComboBoxColumn();
            
            cw.DataSource = dt;
            cw.DisplayMember = "itemdesc";
            cw.HeaderText = "ITEM";
            this.itemdatagridview.Columns.Add(cw);


            ///////////////////////////////////////
            ////// Quantity
            //////
            DataGridViewTextBoxColumn cw1 = new DataGridViewTextBoxColumn();
            
           
           // cw1.DataSource = dt;
            //cw1.DisplayMember = "";
            
           cw1.HeaderText = "Quantity";
           // this.itemdatagridview.ColumnAdded(cw1);
           this.itemdatagridview.Columns.Add(cw1);


            //////////////////////////////////////
            //// Unit
            ////
            DataGridViewComboBoxColumn cw2 = new
                 DataGridViewComboBoxColumn();

            cw2.DataSource = dt;
            cw2.DisplayMember = "unit";
            cw2.HeaderText = "Unit";
            this.itemdatagridview.Columns.Add(cw2);


            //////////////////////////////////////
            //// Rate
            ////
            DataGridViewComboBoxColumn cw3 = new
                 DataGridViewComboBoxColumn();

            cw3.DataSource = dt;
            cw3.DisplayMember = "rate";
            cw3.HeaderText = "Rate";
            
            this.itemdatagridview.Columns.Add(cw3);

            //////////////////////////////////////
            //// Unit
            ////
            DataGridViewTextBoxColumn cw4 = new DataGridViewTextBoxColumn();

            //cw4.DataSource = dt;
            
           // cw4.DisplayMember = ;
            cw4.HeaderText = "Value";
            this.itemdatagridview.Columns.Add(cw4);


            ///////////////////////////////////////
            ///// Retrieve next journal id
            /////
            //int rst = JournalPoster.NextJournal();
            //this.journalidtxt.Text = rst.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
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
                GUIutils.ShowMessage("Account Type code doesnt exist");
                return;
            }

            DataRow dr = dt.Rows[0];
            Crtxt.Text = dr["pname"].ToString();
            pcode = dr["pcode"].ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void termtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void itemdatagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
