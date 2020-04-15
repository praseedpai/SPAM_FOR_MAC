using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HTMLRenderKit;
using AccountLayer;
using System.IO;

namespace SAP
{
    public partial class ShowP_L : Form
    {

       public double diff;


        public ShowP_L()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // DataTable dt = LedgerBalance.LedgerTable(tacc_code);
            Report(); 
        }

        private void Report()
        {
            double opamount = Convert.ToDouble(textBox1.Text);
            double clamount = Convert.ToDouble(textBox2.Text);


            CHTMLDocument ds = new CHTMLDocument();
            CHTMLText txt = new CHTMLText("     Profit And Loss Account     ");

            txt.setItalic(true);
            CHTMLHorizontalRule hr = new CHTMLHorizontalRule();
            CHTMLInput input = new CHTMLInput();
            //
            //
            //
            CHTMLTable table = new CHTMLTable();
            table.setBorder(1);
            table.setCaption(new CHTMLText("  Profit And Loss Account   "));

            CHTMLTableRow row = null;
            row = new CHTMLTableRow();
            CHTMLTableCell cell = null;
            cell = new CHTMLTableCell(alignment.HEADING);
            cell.addObject(new CHTMLText(" Expenses "));
            row.addObject(cell);
            cell = new CHTMLTableCell(alignment.HEADING);
            cell.addObject(new CHTMLText("  Account Rs "));
            row.addObject(cell);

            cell = new CHTMLTableCell(alignment.HEADING);
           
            cell.addObject(new CHTMLText(" Income "));
            row.addObject(cell);
            cell = new CHTMLTableCell(alignment.HEADING);
            cell.addObject(new CHTMLText("  Account Rs "));
            row.addObject(cell);
            table.addObject(row);

            row = new CHTMLTableRow();
            cell = new CHTMLTableCell(alignment.RIGHT);
            cell.addObject(new CHTMLText(" To Opening stock  "));
            row.addObject(cell);
            cell = new CHTMLTableCell(alignment.RIGHT);
            cell.setHorizontalAlign(alignment.RIGHT);
            cell.addObject(new CHTMLText(opamount.ToString()));
            row.addObject(cell);
            cell = new CHTMLTableCell(alignment.RIGHT);
            cell.addObject(new CHTMLText());
            row.addObject(cell);
            cell = new CHTMLTableCell(alignment.RIGHT);
            cell.addObject(new CHTMLText());
            row.addObject(cell);
            
            row.backgroundColor = "red";
            table.addObject(row);
            DataTable dt = PandL.ProfitAndLoss2();
            DataTable dt1 = PandL.ProfitAndLoss1();
            double crTotal = 0;
            double drTotal = 0;
            int crow = dt1.Rows.Count;
            int drow = dt.Rows.Count;
            int max = Math.Max(drow, crow);
            bool flag1 = false;
            bool flag2 =false;

           bool equal = (drow == crow) ? true : false;
            bool drowempty = drow == 0 ? true : false;
            bool crowempty = crow == 0 ? true : false;
            int i = 0;

            while(i < max)
            {
                row = new CHTMLTableRow();
                if (drow < max)
                {
                    if (i == drow)
                    {
                        flag1 = true;
                    }
                }
                if (crow < max)
                {
                    if (i == crow)
                    {
                        flag2 = true;
                    }
                }

                if (flag1 == true && equal == false)
                {

                    cell = new CHTMLTableCell(alignment.RIGHT);
                    cell.addObject(new CHTMLText("  "));
                    row.addObject(cell);
                    cell = new CHTMLTableCell(alignment.RIGHT);
                    cell.setHorizontalAlign(alignment.RIGHT);
                    cell.addObject(new CHTMLText("  "));
                    row.addObject(cell);
                }
                
                if (i < drow && drowempty == false)
                {     
               

                    DataRow dr = dt.Rows[i];
                    double amnt = double.Parse(dr["Total"].ToString());

                   
                        cell = new CHTMLTableCell(alignment.RIGHT);
                        cell.addObject(new CHTMLText("To " + dr["S_DESC"].ToString()));
                        row.addObject(cell);
                        cell = new CHTMLTableCell(alignment.RIGHT);
                        cell.setHorizontalAlign(alignment.RIGHT);
                        cell.addObject(new CHTMLText(amnt.ToString()));
                        row.addObject(cell);

                        drTotal += amnt;
                    
                    
                }
                if (flag2 == true && equal == false)
                {
                    cell = new CHTMLTableCell(alignment.RIGHT);
                    cell.addObject(new CHTMLText("  "));
                    row.addObject(cell);
                    cell = new CHTMLTableCell(alignment.RIGHT);
                    cell.addObject(new CHTMLText(" "));
                    row.addObject(cell);
                }

                if (i < crow && crowempty == false)
                {
                   DataRow dr = dt1.Rows[i];
                    
                   double amnt = double.Parse(dr["Total"].ToString());
                                               
                    cell = new CHTMLTableCell(alignment.RIGHT);
                    cell.addObject(new CHTMLText("By " + dr["S_DESC"].ToString()));
                    row.addObject(cell);
                    cell = new CHTMLTableCell(alignment.RIGHT);
                    amnt = -amnt;

                    cell = new CHTMLTableCell(alignment.RIGHT);
                    cell.setHorizontalAlign(alignment.RIGHT);
                    cell.addObject(new CHTMLText(amnt.ToString()));
                    row.addObject(cell);
                    crTotal += amnt;

                }
                        table.addObject(row);
                        i++;
            }

              

            row = new CHTMLTableRow();
            cell = new CHTMLTableCell(alignment.RIGHT);
            cell.addObject(new CHTMLText());
            row.addObject(cell);
            cell = new CHTMLTableCell(alignment.RIGHT);
            cell.addObject(new CHTMLText());
            row.addObject(cell);
            cell = new CHTMLTableCell(alignment.RIGHT);
            cell.addObject(new CHTMLText("  By Closing stock  "));
            row.addObject(cell);
            cell = new CHTMLTableCell(alignment.RIGHT);
            cell.setHorizontalAlign(alignment.RIGHT);
            cell.addObject(new CHTMLText(clamount.ToString()));
            row.addObject(cell);
            table.addObject(row);

            crTotal += clamount;
            drTotal += opamount;
            
            row = new CHTMLTableRow();
            cell = new CHTMLTableCell(alignment.RIGHT);
            cell.addObject(new CHTMLText(" To profit and loss carried down to balance sheet "));
            row.addObject(cell);

            
            diff = drTotal - crTotal;

            if (drTotal > crTotal)
            {
                
                cell = new CHTMLTableCell(alignment.RIGHT);
                cell.addObject(new CHTMLText());
                row.addObject(cell);
                cell = new CHTMLTableCell(alignment.RIGHT);
                cell.addObject(new CHTMLText());
                row.addObject(cell);
                
                cell = new CHTMLTableCell(alignment.RIGHT);
                cell.setHorizontalAlign(alignment.RIGHT);
                cell.addObject(new CHTMLText((diff).ToString()));
                row.addObject(cell);
                crTotal += diff;
            }
            else
            {
               
               
                cell = new CHTMLTableCell(alignment.RIGHT);
                cell.setHorizontalAlign(alignment.RIGHT);
                cell.addObject(new CHTMLText((-diff).ToString()));
                row.addObject(cell);
                drTotal += (-diff);
            }

            table.addObject(row);

            row = new CHTMLTableRow();
            cell = new CHTMLTableCell(alignment.RIGHT);
            cell.addObject(new CHTMLText("Total"));
            row.addObject(cell);


            cell = new CHTMLTableCell(alignment.RIGHT);
            cell.setHorizontalAlign(alignment.RIGHT);
            cell.addObject(new CHTMLText(drTotal.ToString()));
            row.addObject(cell);

            cell = new CHTMLTableCell(alignment.RIGHT);
            cell.addObject(new CHTMLText());
            row.addObject(cell);

            cell = new CHTMLTableCell(alignment.RIGHT);
            cell.setHorizontalAlign(alignment.RIGHT);
            cell.addObject(new CHTMLText(crTotal.ToString()));
            row.addObject(cell);
            table.addObject(row);
            ds.addObject(table);
            string rs = ds.toHTML();

            FileStream fs = new FileStream(@"C:\temp\a.html", FileMode.Create);
            StreamWriter st = new StreamWriter(fs);
            st.Write(rs);
            st.Close();



            webBrowser1.Navigate(new Uri(@"file://c:\temp\a.html"));
            webBrowser1.Refresh();


        }

    }
}
