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
    public partial class ShowBalanceSheet : Form
    {
        public ShowBalanceSheet()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

#if false
        private void Report()
        {


            double closingstock = Convert.ToDouble(clstocktxt.Text);
            double pft = Convert.ToDouble(pltxt.Text);
            double crTotal = 0;
            double drTotal = 0;
            bool flag1 = false;
            bool flag2 = false;
            bool equal = false;

            CHTMLDocument ds = new CHTMLDocument();
            CHTMLText txt = new CHTMLText(" BalanceSheet  ");

            txt.setItalic(true);
            CHTMLHorizontalRule hr = new CHTMLHorizontalRule();
            CHTMLInput input = new CHTMLInput();
            //
            //
            //
            CHTMLTable table = new CHTMLTable();
            table.setBorder(1);
            table.setCaption(new CHTMLText(" BalanceSheet "));

            CHTMLTableRow row = null;
            row = new CHTMLTableRow();
            CHTMLTableCell cell = null;
            cell = new CHTMLTableCell(alignment.HEADING);
            cell.addObject(new CHTMLText("Liabilities "));
            row.addObject(cell);
            cell = new CHTMLTableCell(alignment.HEADING);
            cell.addObject(new CHTMLText("  Account Rs "));
            row.addObject(cell);

            cell = new CHTMLTableCell(alignment.HEADING);

            cell.addObject(new CHTMLText(" Assets "));
            row.addObject(cell);
            cell = new CHTMLTableCell(alignment.HEADING);
            cell.addObject(new CHTMLText("  Account Rs "));
            row.addObject(cell);
            table.addObject(row);
            row = null;

            if (pft > 0)
            {
                row = new CHTMLTableRow();
                cell = new CHTMLTableCell(alignment.RIGHT);
                cell.addObject(new CHTMLText(" Profit "));
                row.addObject(cell);
                cell = new CHTMLTableCell(alignment.RIGHT);
                cell.setHorizontalAlign(alignment.RIGHT);
                cell.addObject(new CHTMLText((pft).ToString()));
                row.addObject(cell);

                cell = new CHTMLTableCell(alignment.RIGHT);
                cell.addObject(new CHTMLText());
                row.addObject(cell);
                cell = new CHTMLTableCell(alignment.RIGHT);
                cell.addObject(new CHTMLText());
                row.addObject(cell);
                table.addObject(row);
                row = null;
                drTotal += (pft);
            }
            else if(pft < 0)
            {
                row = new CHTMLTableRow();

                cell = new CHTMLTableCell(alignment.RIGHT);
                cell.addObject(new CHTMLText());
                row.addObject(cell);
                cell = new CHTMLTableCell(alignment.RIGHT);
                cell.addObject(new CHTMLText());
                row.addObject(cell);
                cell = new CHTMLTableCell(alignment.RIGHT);
                cell.addObject(new CHTMLText("Loss "));
                row.addObject(cell);
                cell = new CHTMLTableCell(alignment.RIGHT);
                cell.setHorizontalAlign(alignment.RIGHT);
                cell.addObject(new CHTMLText((-pft).ToString()));
                row.addObject(cell);

                table.addObject(row);
                row = null;
                crTotal += -pft;
            }
            

           // row.backgroundColor = "red";
            //table.addObject(row);
            DataTable dt = Balancesheet.ShowBalance2();
            DataTable dt1 = Balancesheet.ShowBalance1();
            
            int drow = dt.Rows.Count;
            int crow = dt1.Rows.Count;
            int max = Math.Max(drow, crow);
            equal = (drow == crow) ? true : false;
            int i = 0;

            while (i < max)
            {
                row = new CHTMLTableRow();

                if (crow < max)
                {
                    if (i == crow)
                    {
                        flag1 = true; ;
                    }
                }
                if (drow < max)
                {
                    if (i == drow)
                    {
                        flag2 = true;
                    }
                }

                               

                if (flag1 == true && equal == false)
                {

                    cell = new CHTMLTableCell(alignment.RIGHT);
                    cell.addObject(new CHTMLText());
                    row.addObject(cell);
                    cell = new CHTMLTableCell(alignment.RIGHT);
                    cell.setHorizontalAlign(alignment.RIGHT);
                    cell.addObject(new CHTMLText());
                    row.addObject(cell);
                }

                if (i < crow)
                {
                    DataRow dr = dt1.Rows[i];

                    double amnt = double.Parse(dr["Total"].ToString());



                    cell = new CHTMLTableCell(alignment.RIGHT);
                    cell.addObject(new CHTMLText(dr["S_DESC"].ToString()));
                    row.addObject(cell);

                    if (amnt < 0)
                    {
                        cell = new CHTMLTableCell(alignment.RIGHT);
                        cell.setHorizontalAlign(alignment.RIGHT);
                        cell.addObject(new CHTMLText((-amnt).ToString()));
                        //row.addObject(cell);


                        cell = new CHTMLTableCell(alignment.RIGHT);
                        cell.addObject(new CHTMLText());
                        row.addObject(cell);
                        cell = new CHTMLTableCell(alignment.RIGHT);
                        cell.addObject(new CHTMLText());
                        row.addObject(cell);

                        crTotal += -amnt;

                    }
                    else
                    {
                        cell = new CHTMLTableCell(alignment.RIGHT);
                        cell.addObject(new CHTMLText());
                        row.addObject(cell);
                        cell = new CHTMLTableCell(alignment.RIGHT);
                        cell.addObject(new CHTMLText());
                        

                        cell = new CHTMLTableCell(alignment.RIGHT);
                        cell.setHorizontalAlign(alignment.RIGHT);
                        cell.addObject(new CHTMLText((amnt).ToString()));
                        row.addObject(cell);

                        drTotal += (amnt);
                    }
                }
                    if (flag2 == true && equal == false)
                    {
                        cell = new CHTMLTableCell(alignment.RIGHT);
                        cell.addObject(new CHTMLText());
                        row.addObject(cell);
                        cell = new CHTMLTableCell(alignment.RIGHT);
                        cell.addObject(new CHTMLText());
                        row.addObject(cell);
                    }

               
                if (i < drow)
                {
                    DataRow dr = dt.Rows[i];
                    double amnt = double.Parse(dr["Total"].ToString());

                    

                    if (amnt > 0)
                    {
                        cell = new CHTMLTableCell(alignment.RIGHT);
                        cell.addObject(new CHTMLText(dr["S_DESC"].ToString()));
                        row.addObject(cell);
                        cell = new CHTMLTableCell(alignment.RIGHT);
                        cell.setHorizontalAlign(alignment.RIGHT);
                        cell.addObject(new CHTMLText((amnt).ToString()));
                        row.addObject(cell);

                        drTotal += (amnt);
                    }
                    else if(amnt < 0)
                    {
                        /*cell = new CHTMLTableCell(alignment.RIGHT);
                        cell.addObject(new CHTMLText());
                        row.addObject(cell);
                        cell = new CHTMLTableCell(alignment.RIGHT);
                        cell.addObject(new CHTMLText());
                        row.addObject(cell);*/
                        cell = new CHTMLTableCell(alignment.RIGHT);
                        cell.addObject(new CHTMLText(dr["S_DESC"].ToString()));
                        row.addObject(cell);
                        cell = new CHTMLTableCell(alignment.RIGHT);
                        cell.setHorizontalAlign(alignment.RIGHT);
                        cell.addObject(new CHTMLText((amnt).ToString()));
                        row.addObject(cell);

                        crTotal += (amnt);
                    }

                

                
                

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
            cell.addObject(new CHTMLText("Closing stock"));
            row.addObject(cell);
            
            cell = new CHTMLTableCell(alignment.RIGHT);
            cell.addObject(new CHTMLText(closingstock.ToString()));
            row.addObject(cell);
            table.addObject(row);
            drTotal += closingstock;
            
            
            
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

#elif true
        private void Report()
        {


            double closingstock = Convert.ToDouble(clstocktxt.Text);
            double pft = Convert.ToDouble(pltxt.Text);
            double crTotal = 0;
            double drTotal = 0;
            bool flag1 = false;
            bool flag2 = false;
            bool equal = false;

            CHTMLDocument ds = new CHTMLDocument();
            CHTMLText txt = new CHTMLText(" BalanceSheet  ");

            txt.setItalic(true);
            CHTMLHorizontalRule hr = new CHTMLHorizontalRule();
            CHTMLInput input = new CHTMLInput();
            //
            //
            //
            CHTMLTable table = new CHTMLTable();
            table.setBorder(1);
            table.setCaption(new CHTMLText(" BalanceSheet "));

            CHTMLTableRow row = null;
            row = new CHTMLTableRow();
            CHTMLTableCell cell = null;
            cell = new CHTMLTableCell(alignment.HEADING);
            cell.addObject(new CHTMLText("Liabilities "));
            row.addObject(cell);
            cell = new CHTMLTableCell(alignment.HEADING);
            cell.addObject(new CHTMLText("  Account Rs "));
            row.addObject(cell);

            cell = new CHTMLTableCell(alignment.HEADING);

            cell.addObject(new CHTMLText(" Assets "));
            row.addObject(cell);
            cell = new CHTMLTableCell(alignment.HEADING);
            cell.addObject(new CHTMLText("  Account Rs "));
            row.addObject(cell);
            table.addObject(row);
            row = null;

            if (pft > 0)
            {
                row = new CHTMLTableRow();
                cell = new CHTMLTableCell(alignment.RIGHT);
                cell.addObject(new CHTMLText(" Profit "));
                row.addObject(cell);
                cell = new CHTMLTableCell(alignment.RIGHT);
                cell.setHorizontalAlign(alignment.RIGHT);
                cell.addObject(new CHTMLText((pft).ToString()));
                row.addObject(cell);

                cell = new CHTMLTableCell(alignment.RIGHT);
                cell.addObject(new CHTMLText("  "));
                row.addObject(cell);
                cell = new CHTMLTableCell(alignment.RIGHT);
                cell.addObject(new CHTMLText("  "));
                row.addObject(cell);
                table.addObject(row);
                row = null;
                crTotal += (pft);
            }
            else if (pft < 0)
            {
                row = new CHTMLTableRow();

                cell = new CHTMLTableCell(alignment.RIGHT);
                cell.addObject(new CHTMLText("  "));
                row.addObject(cell);
                cell = new CHTMLTableCell(alignment.RIGHT);
                cell.addObject(new CHTMLText("  "));
                row.addObject(cell);
                cell = new CHTMLTableCell(alignment.RIGHT);
                cell.addObject(new CHTMLText("Loss "));
                row.addObject(cell);
                cell = new CHTMLTableCell(alignment.RIGHT);
                cell.setHorizontalAlign(alignment.RIGHT);
                cell.addObject(new CHTMLText((-pft).ToString()));
                row.addObject(cell);

                table.addObject(row);
                row = null;
                drTotal += -pft;
            }


            // row.backgroundColor = "red";
            //table.addObject(row);
            DataTable dt = Balancesheet.ShowBalance2();
            DataTable dt1 = Balancesheet.ShowBalance1();

            int drow = dt.Rows.Count;
            int crow = dt1.Rows.Count;
            int max = Math.Max(drow, crow);
            equal = (drow == crow) ? true : false;
            int i = 0;

            while (i < max)
            {
                row = new CHTMLTableRow();

                if (crow < max)
                {
                    if (i == crow)
                    {
                        flag1 = true; ;
                    }
                }
                if (drow < max)
                {
                    if (i == drow)
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

                if (i < crow)
                {
                    DataRow dr = dt1.Rows[i];

                    double amnt = double.Parse(dr["Total"].ToString());
                                     

                    if (amnt < 0)
                    {
                        cell = new CHTMLTableCell(alignment.RIGHT);
                        cell.addObject(new CHTMLText(dr["S_DESC"].ToString()));
                        row.addObject(cell);
                        cell = new CHTMLTableCell(alignment.RIGHT);
                        cell.setHorizontalAlign(alignment.RIGHT);
                        cell.addObject(new CHTMLText((-amnt).ToString()));
                        row.addObject(cell);
                        
                        cell = new CHTMLTableCell(alignment.RIGHT);
                        cell.addObject(new CHTMLText("  "));
                        row.addObject(cell);
                        cell = new CHTMLTableCell(alignment.RIGHT);
                        cell.addObject(new CHTMLText("  "));
                        row.addObject(cell);

                        crTotal += -amnt;

                    }
                    else
                    {
                        
                        cell = new CHTMLTableCell(alignment.RIGHT);
                        cell.addObject(new CHTMLText( "   " ));
                        row.addObject(cell);
                        cell = new CHTMLTableCell(alignment.RIGHT);
                        cell.addObject(new CHTMLText("  "));
                        row.addObject(cell);
                        cell = new CHTMLTableCell(alignment.RIGHT);
                        cell.addObject(new CHTMLText(dr["S_DESC"].ToString()));
                        row.addObject(cell);
                        cell = new CHTMLTableCell(alignment.RIGHT);
                        cell.setHorizontalAlign(alignment.RIGHT);
                        cell.addObject(new CHTMLText((amnt).ToString()));
                        row.addObject(cell);
                        table.addObject(row);
                        row = new CHTMLTableRow(); 

                        drTotal += (amnt);
                    }
                }
                if (flag2 == true && equal == false)
                {
                    cell = new CHTMLTableCell(alignment.RIGHT);
                    cell.addObject(new CHTMLText("  " ));
                    row.addObject(cell);
                    cell = new CHTMLTableCell(alignment.RIGHT);
                    cell.addObject(new CHTMLText(" "));
                    row.addObject(cell);
                }


                if (i < drow)
                {
                    DataRow dr = dt.Rows[i];
                    double amnt = double.Parse(dr["Total"].ToString());



                    if (amnt > 0)
                    {
                        cell = new CHTMLTableCell(alignment.RIGHT);
                        cell.addObject(new CHTMLText("  "));
                        row.addObject(cell);
                        cell = new CHTMLTableCell(alignment.RIGHT);
                        cell.addObject(new CHTMLText("  "));
                        row.addObject(cell);
                        cell = new CHTMLTableCell(alignment.RIGHT);
                        cell.addObject(new CHTMLText(dr["S_DESC"].ToString()));
                        row.addObject(cell);
                        cell = new CHTMLTableCell(alignment.RIGHT);
                        cell.setHorizontalAlign(alignment.RIGHT);
                        cell.addObject(new CHTMLText((amnt).ToString()));
                        row.addObject(cell);

                        drTotal += (amnt);
                    }
                    else if (amnt < 0)
                    {
                        
                        cell = new CHTMLTableCell(alignment.RIGHT);
                        cell.addObject(new CHTMLText(dr["S_DESC"].ToString()));
                        row.addObject(cell);
                        cell = new CHTMLTableCell(alignment.RIGHT);
                        cell.setHorizontalAlign(alignment.RIGHT);
                        cell.addObject(new CHTMLText((amnt).ToString()));
                        row.addObject(cell);

                        crTotal += (amnt);
                    }






                }
                table.addObject(row);
                row = null;
                i++;
            }


            row = new CHTMLTableRow();
            cell = new CHTMLTableCell(alignment.RIGHT);
            cell.addObject(new CHTMLText("  "));
            row.addObject(cell);
            cell = new CHTMLTableCell(alignment.RIGHT);
            cell.addObject(new CHTMLText("  "));
            row.addObject(cell);
            cell = new CHTMLTableCell(alignment.RIGHT);
            cell.addObject(new CHTMLText("Closing stock"));
            row.addObject(cell);

            cell = new CHTMLTableCell(alignment.RIGHT);
            cell.setHorizontalAlign(alignment.RIGHT);
            cell.addObject(new CHTMLText(closingstock.ToString()));
            row.addObject(cell);
            table.addObject(row);
            drTotal += closingstock;



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


#else
        
        private void Report()
        {


            double closingstock = Convert.ToDouble(clstocktxt.Text);
            double pft = Convert.ToDouble(pltxt.Text);
            double crTotal = 0;
            double drTotal = 0;
            //bool flag1 = false;
           // bool flag2 = false;
           // bool equal = false;

            CHTMLDocument ds = new CHTMLDocument();
            CHTMLText txt = new CHTMLText(" BalanceSheet  ");

            txt.setItalic(true);
            CHTMLHorizontalRule hr = new CHTMLHorizontalRule();
            CHTMLInput input = new CHTMLInput();
            //
            //
            //
            CHTMLTable table = new CHTMLTable();
            table.setBorder(1);
            table.setCaption(new CHTMLText(" BalanceSheet "));

            CHTMLTableRow row = null;
            row = new CHTMLTableRow();
            CHTMLTableCell cell = null;
            cell = new CHTMLTableCell(alignment.HEADING);
            cell.addObject(new CHTMLText("Liabilities "));
            row.addObject(cell);
            cell = new CHTMLTableCell(alignment.HEADING);
            cell.addObject(new CHTMLText("  Account Rs "));
            row.addObject(cell);
            table.addObject(row);

            
            row = null;

            if (pft > 0)
            {
                row = new CHTMLTableRow();
                cell = new CHTMLTableCell(alignment.RIGHT);
                cell.addObject(new CHTMLText(" Profit "));
                row.addObject(cell);
                cell = new CHTMLTableCell(alignment.RIGHT);
                cell.setHorizontalAlign(alignment.RIGHT);
                cell.addObject(new CHTMLText((pft).ToString()));
                row.addObject(cell);
                                
                table.addObject(row);
                row = null;
                crTotal += (pft);
            }
            else if (pft < 0)
            {
                row = new CHTMLTableRow();

               
                cell = new CHTMLTableCell(alignment.RIGHT);
                cell.addObject(new CHTMLText("Loss "));
                row.addObject(cell);
                cell = new CHTMLTableCell(alignment.RIGHT);
                cell.setHorizontalAlign(alignment.RIGHT);
                cell.addObject(new CHTMLText((-pft).ToString()));
                row.addObject(cell);

                table.addObject(row);
                row = null;
                drTotal += -pft;
            }


            // row.backgroundColor = "red";
            //table.addObject(row);
            DataTable dt = Balancesheet.ShowBalance2();
            DataTable dt1 = Balancesheet.ShowBalance1();

            int drow = dt.Rows.Count;
            int crow = dt1.Rows.Count;
            //int max = Math.Max(drow, crow);
            //equal = (drow == crow) ? true : false;
            int i = 0;
            int k = 0;

                                        

                while(i < crow)
                {

                    row = new CHTMLTableRow();
                    DataRow dr = dt1.Rows[i];

                    double amnt = double.Parse(dr["Total"].ToString());
                    cell = new CHTMLTableCell(alignment.RIGHT);
                    cell.addObject(new CHTMLText(dr["S_DESC"].ToString()));
                    row.addObject(cell);

                   if(amnt < 0)
                   {
                       crTotal += -amnt;

                      
                   }
                   else
                   {
                       drTotal += (amnt);

                      
                   }

                       
                        cell = new CHTMLTableCell(alignment.RIGHT);
                        cell.setHorizontalAlign(alignment.RIGHT);
                        cell.addObject(new CHTMLText((-amnt).ToString()));
                        row.addObject(cell);
                        table.addObject(row);
                        row = null;
                    i++;
                                                                
                  }
            row = new CHTMLTableRow();
            cell = new CHTMLTableCell(alignment.RIGHT);
            cell.addObject(new CHTMLText("  Total  "));
            row.addObject(cell);

            cell = new CHTMLTableCell(alignment.RIGHT);
            cell.setHorizontalAlign(alignment.RIGHT);
            cell.addObject(new CHTMLText(crTotal.ToString()));
            row.addObject(cell);
            table.addObject(row);
            row = null;

            for (int j = 0; j < 10; j++)
            {
                row = new CHTMLTableRow();
                cell = new CHTMLTableCell(alignment.RIGHT);
                cell.addObject(new CHTMLText("  "));
                row.addObject(cell);
                table.addObject(row);
                row = null;

                j++;
            }
            
            row = new CHTMLTableRow();
            cell = new CHTMLTableCell(alignment.HEADING);
            cell.addObject(new CHTMLText(" Assets "));
            row.addObject(cell);
            cell = new CHTMLTableCell(alignment.HEADING);
            cell.addObject(new CHTMLText("  Account Rs "));
            row.addObject(cell);
            table.addObject(row);
            row = null;

            while (k < drow)
            {
                 row = new CHTMLTableRow();
                 DataRow dr = dt.Rows[k];
                 double amnt = double.Parse(dr["Total"].ToString());
                
                 if (amnt > 0)
                 {
                        drTotal += (amnt);
                 }
                 else
                 {
                        crTotal += (amnt);
                 }
                        
                 cell = new CHTMLTableCell(alignment.RIGHT);
                 cell.addObject(new CHTMLText(dr["S_DESC"].ToString()));
                 row.addObject(cell);
                 cell = new CHTMLTableCell(alignment.RIGHT);
                 cell.setHorizontalAlign(alignment.RIGHT);
                 cell.addObject(new CHTMLText((amnt).ToString()));
                 row.addObject(cell);
                   
                table.addObject(row);
                row = null;
                k++;
            }


            row = new CHTMLTableRow();
            cell = new CHTMLTableCell(alignment.RIGHT);
            cell.addObject(new CHTMLText("Closing stock"));
            row.addObject(cell);

            cell = new CHTMLTableCell(alignment.RIGHT);
            cell.setHorizontalAlign(alignment.RIGHT);
            cell.addObject(new CHTMLText(closingstock.ToString()));
            row.addObject(cell);
            table.addObject(row);
            drTotal += closingstock;



            row = new CHTMLTableRow();
            cell = new CHTMLTableCell(alignment.RIGHT);
            cell.addObject(new CHTMLText("  Total  "));
            row.addObject(cell);


            cell = new CHTMLTableCell(alignment.RIGHT);
            cell.setHorizontalAlign(alignment.RIGHT);
            cell.addObject(new CHTMLText(drTotal.ToString()));
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

#endif



        private void ShowBalanceSheet_Load(object sender, EventArgs e)
        {
            
        }

        private void showbtn_Click(object sender, EventArgs e)
        {
            Report();
        }
    }
}
