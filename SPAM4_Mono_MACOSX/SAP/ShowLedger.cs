using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using AccountLayer;
using GUILayer;
using HTMLRenderKit;


namespace SAP
{
    public partial class ShowLedger : Form
    {
        private string _acc_code;
        private string _acc_string;
        public ShowLedger()
        {
            InitializeComponent();
        }

        private void Choosebtn_Click(object sender, EventArgs e)
        {
            DataTable dt = SubGroup.ViewSubGroup();
            ArrayList arr = GetSelectedItem.ItemSelect(
                dt, new int[] { 1 }, new int[] { 0,1 });

            if (arr == null)
            {
                return;
            }


             _acc_code = arr[0].ToString();
            acctxt.Text = _acc_code;
            _acc_string = arr[1].ToString();
            
        }

        private void Showbtn_Click(object sender, EventArgs e)
        {
            string tacc_code = acctxt.Text;
            if (!SubGroup.IsSubGroup(tacc_code))
            {
                GUIutils.ShowMessage("Account does not exist");
                return;
            }

            DataTable dt = LedgerBalance.LedgerTable(tacc_code);
            Report2(dt);
        }

#if false

        private void Report2(DataTable dt)
        {

            CHTMLDocument ds = new CHTMLDocument();
            CHTMLText txt = new CHTMLText("Ledger");

            txt.setItalic(true);
            CHTMLHorizontalRule hr = new CHTMLHorizontalRule();
            CHTMLInput input = new CHTMLInput();
            //
            //
            //
            CHTMLTable table = new CHTMLTable();
            table.setBorder(1);
            table.setCaption(new CHTMLText("Ledger Of " + _acc_string));

            CHTMLTableRow row = null;
            row = new CHTMLTableRow();

            CHTMLTableCell cell = null;

            cell = new CHTMLTableCell(alignment.HEADING);
            cell.addObject(new CHTMLText("  Date "));
            row.addObject(cell);

            cell = new CHTMLTableCell(alignment.HEADING);
            cell.addObject(new CHTMLText(" Account Name "));
            row.addObject(cell);

            cell = new CHTMLTableCell(alignment.HEADING);
            cell.addObject(new CHTMLText("  DR "));
            row.addObject(cell);

            cell = new CHTMLTableCell(alignment.HEADING);
            cell.addObject(new CHTMLText("  CR "));
            row.addObject(cell);


            row.backgroundColor = "red";
            table.addObject(row);
           
            foreach (DataRow dr in dt.Rows)
            {
                row = new CHTMLTableRow();
                cell = new CHTMLTableCell(alignment.HEADING);
                cell.addObject(new CHTMLText(dr["J_DATE"].ToString()));
                row.addObject(cell);
                cell = new CHTMLTableCell(alignment.HEADING);
                if (dr["J_DRCR"].ToString() == "CR")
                {
                    cell.addObject(new CHTMLText("TO "+ dr["S_DESC"].ToString()));
                }
                else
                {
                    cell.addObject(new CHTMLText("BY " +dr["S_DESC"].ToString()));
                }
                row.addObject(cell);
                if (dr["J_DRCR"].ToString()== "CR")
                {
                    cell = new CHTMLTableCell(alignment.HEADING);
                    cell.setHorizontalAlign(alignment.RIGHT);
                    cell.addObject(new CHTMLText( dr["J_AMOUNT"].ToString()));
                    row.addObject(cell);
                    cell = new CHTMLTableCell(alignment.RIGHT);
                    cell.addObject(new CHTMLText("   "));
                    row.addObject(cell);
                    

                }
                else 
                {
                    cell = new CHTMLTableCell(alignment.HEADING);
                    cell.addObject(new CHTMLText("   "));
                    row.addObject(cell);
                    cell = new CHTMLTableCell(alignment.RIGHT);
                    cell.setHorizontalAlign(alignment.RIGHT);
                    cell.addObject(new CHTMLText(dr["J_AMOUNT"].ToString()));
                    row.addObject(cell);
                   
                }


                table.addObject(row);

            }

            ds.addObject(table);
            string rs = ds.toHTML();

            FileStream fs = new FileStream(@"C:\temp\a.html", FileMode.Create);
            StreamWriter st = new StreamWriter(fs);
            st.Write(rs);
            st.Close();



            webBrowser1.Navigate(new Uri(@"file://c:\temp\a.html"));
            webBrowser1.Refresh();


        }
#else

         private void Report2(DataTable dt)
        {

            CHTMLDocument ds = new CHTMLDocument();
            CHTMLText txt = new CHTMLText("  Ledger  ");

            txt.setItalic(true);
            CHTMLHorizontalRule hr = new CHTMLHorizontalRule();
            CHTMLInput input = new CHTMLInput();
            //
            //
            //
            CHTMLTable table = new CHTMLTable();
            table.setBorder(1);
            table.setCaption(new CHTMLText("  Ledger Of   " +  _acc_string  ));

            CHTMLTableRow row = null;
            row = new CHTMLTableRow();

            CHTMLTableCell cell = null;

            cell = new CHTMLTableCell(alignment.HEADING);
            cell.addObject(new CHTMLText("    Date    "));
            row.addObject(cell);

            cell = new CHTMLTableCell(alignment.HEADING);
            cell.addObject(new CHTMLText("   Account Name   "));
            row.addObject(cell);

            cell = new CHTMLTableCell(alignment.HEADING);
            cell.addObject(new CHTMLText("    DR   "));
            row.addObject(cell);

            cell = new CHTMLTableCell(alignment.HEADING);
            cell.addObject(new CHTMLText("    CR   "));
            row.addObject(cell);


            row.backgroundColor = "red";
            table.addObject(row);


            double crTotal = 0.0;
            double drTotal = 0.0;

            foreach (DataRow dr in dt.Rows)
            {
                row = new CHTMLTableRow();
                cell = new CHTMLTableCell(alignment.HEADING);
                cell.addObject(new CHTMLText(dr["J_DATE"].ToString()));
                row.addObject(cell);
                cell = new CHTMLTableCell(alignment.HEADING);
                if (dr["J_DRCR"].ToString() == "CR")
                {
                    cell.addObject(new CHTMLText("  By  "+ dr["S_DESC"].ToString()));
                }
                else
                {
                    cell.addObject(new CHTMLText("  To " +dr["S_DESC"].ToString()));
                }
                row.addObject(cell);
                if (dr["J_DRCR"].ToString()== "DR")
                {
                    cell = new CHTMLTableCell(alignment.HEADING);
                    cell.setHorizontalAlign(alignment.RIGHT);
                    cell.addObject(new CHTMLText( dr["J_AMOUNT"].ToString()));
                    row.addObject(cell);
                    cell = new CHTMLTableCell(alignment.RIGHT);
                    cell.addObject(new CHTMLText("   "));
                    row.addObject(cell);
                    drTotal += Convert.ToDouble(dr["J_AMOUNT"]);

                }
                else 
                {
                    cell = new CHTMLTableCell(alignment.HEADING);
                    cell.addObject(new CHTMLText("   "));
                    row.addObject(cell);
                    cell = new CHTMLTableCell(alignment.RIGHT);
                    cell.setHorizontalAlign(alignment.RIGHT);
                    cell.addObject(new CHTMLText(dr["J_AMOUNT"].ToString()));
                    row.addObject(cell);
                    crTotal += Convert.ToDouble(dr["J_AMOUNT"]);

                   
                }


                table.addObject(row);

            }

            double balance = drTotal - crTotal;
            double GrandTotal = Math.Max(drTotal, crTotal);
            
            row = new CHTMLTableRow();
            cell = new CHTMLTableCell(alignment.HEADING);
            cell.addObject(new CHTMLText("    "));
            row.addObject(cell);
            cell = new CHTMLTableCell(alignment.HEADING);

            if (balance > 0)
            {
                cell.addObject(new CHTMLText("  By balance c/d  "));
                row.addObject(cell);
                cell = new CHTMLTableCell(alignment.HEADING);
                cell.addObject(new CHTMLText("    "));
                row.addObject(cell);
                cell = new CHTMLTableCell(alignment.HEADING);
                cell.addObject(new CHTMLText(Math.Abs(balance).ToString()));
                row.addObject(cell);
                table.addObject(row);

            }
            else if (balance < 0)
            {
                cell.addObject(new CHTMLText(" To balance c/d "));
                row.addObject(cell);
                cell = new CHTMLTableCell(alignment.HEADING);
                cell.addObject(new CHTMLText(Math.Abs(balance).ToString()));
                row.addObject(cell);
                cell = new CHTMLTableCell(alignment.HEADING);
                cell.addObject(new CHTMLText("    "));
                row.addObject(cell);
                table.addObject(row);
            }
            

               row = new CHTMLTableRow();
               cell = new CHTMLTableCell(alignment.HEADING);
               cell.addObject(new CHTMLText("    "));
               row.addObject(cell);
               cell = new CHTMLTableCell(alignment.HEADING);
               cell.addObject(new CHTMLText("   Total   "));
               row.addObject(cell);
            cell = new CHTMLTableCell(alignment.HEADING);
            cell.addObject(new CHTMLText(GrandTotal.ToString()));
            row.addObject(cell);
            
            cell = new CHTMLTableCell(alignment.HEADING);
            cell.addObject(new CHTMLText(GrandTotal.ToString()));
            row.addObject(cell);
            table.addObject(row);


            row = new CHTMLTableRow();
            cell = new CHTMLTableCell(alignment.HEADING);
            cell.addObject(new CHTMLText("    "));
            row.addObject(cell);
            cell = new CHTMLTableCell(alignment.HEADING);

            if (balance < 0)
            {
                cell.addObject(new CHTMLText("By balance b/d"));
                row.addObject(cell);
                cell = new CHTMLTableCell(alignment.HEADING);
                cell.addObject(new CHTMLText("    "));
                row.addObject(cell);
                cell = new CHTMLTableCell(alignment.HEADING);
                cell.addObject(new CHTMLText(Math.Abs(balance).ToString()));
                row.addObject(cell);
                table.addObject(row);

            }
            else if (balance > 0)
            {
                cell.addObject(new CHTMLText("To balance b/d"));
                row.addObject(cell);
                cell = new CHTMLTableCell(alignment.HEADING);
                cell.addObject(new CHTMLText(Math.Abs(balance).ToString()));
                row.addObject(cell);
                cell = new CHTMLTableCell(alignment.HEADING);
                cell.addObject(new CHTMLText("    "));
                row.addObject(cell);
                table.addObject(row);
            }
            


            ds.addObject(table);
            string rs = ds.toHTML();

            FileStream fs = new FileStream(@"C:\temp\a.html", FileMode.Create);
            StreamWriter st = new StreamWriter(fs);
            st.Write(rs);
            st.Close();



            webBrowser1.Navigate(new Uri(@"file://c:\temp\a.html"));
            webBrowser1.Refresh();


        }
#endif
    }
}
