using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HTMLRenderKit;
using AccountLayer;


namespace SAP
{
    public partial class ReportForm : Form
    {
        private int _reportid = -1;
        public ReportForm()
        {
            InitializeComponent();
        }

        public void SetReport(int reportid)
        {
            _reportid = reportid;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Report1()
        {

            CHTMLDocument ds = new CHTMLDocument();
            CHTMLText txt = new CHTMLText("Financial Accounting Group");

            txt.setItalic(true);
            CHTMLHorizontalRule hr = new CHTMLHorizontalRule();
            CHTMLInput input = new CHTMLInput();
            //
            //
            //
            CHTMLTable table = new CHTMLTable();
            table.setBorder(1);
            table.setCaption(new CHTMLText(" GROUP "));

            CHTMLTableRow row = null;
            row = new CHTMLTableRow();

            CHTMLTableCell cell = null;

            cell = new CHTMLTableCell(alignment.HEADING);
            cell.addObject(new CHTMLText(" Group Code "));
            row.addObject(cell);

            cell = new CHTMLTableCell(alignment.HEADING);
            cell.addObject(new CHTMLText(" Group Name "));
            row.addObject(cell);

            
            row.backgroundColor = "red";
            table.addObject(row);
            DataTable dt = Group.ListGroup();
            foreach(DataRow dr in dt.Rows)
             {
                row = new CHTMLTableRow();
                cell = new CHTMLTableCell(alignment.HEADING);
                cell.addObject(new CHTMLText(dr["A_CODE"].ToString()));
                row.addObject(cell);
                cell = new CHTMLTableCell(alignment.HEADING);
                
                cell.addObject(new CHTMLText(dr["A_DESC"].ToString()));
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




        private void Report2()
        {

            CHTMLDocument ds = new CHTMLDocument();
            CHTMLText txt = new CHTMLText("Chart Of Accounts");

            txt.setItalic(true);
            CHTMLHorizontalRule hr = new CHTMLHorizontalRule();
            CHTMLInput input = new CHTMLInput();
            //
            //
            //
            CHTMLTable table = new CHTMLTable();
            table.setBorder(1);
            table.setCaption(new CHTMLText("CHART OF ACCOUNTS"));

            CHTMLTableRow row = null;
            
            CHTMLTableCell cell = null;
                        
            table.addObject(row);

            DataTable dt1 = Group.ListGroup();
            foreach (DataRow dr1 in dt1.Rows)
            {
                string code = dr1["A_CODE"].ToString();
                row = new CHTMLTableRow();
                cell = new CHTMLTableCell(alignment.HEADING);
                cell.addObject(new CHTMLText(code));
                row.addObject(cell);
                cell = new CHTMLTableCell(alignment.HEADING);

                cell.addObject(new CHTMLText(dr1["A_DESC"].ToString()));
                row.addObject(cell);
                
                cell = new CHTMLTableCell(alignment.HEADING);
                cell.addObject(new CHTMLText());
                row.addObject(cell);
                table.addObject(row);

                DataTable dt = SubGroup.GetSubGroupByGroup(code);
                foreach (DataRow dr in dt.Rows)
                {
                    row = new CHTMLTableRow();
                    cell = new CHTMLTableCell(alignment.HEADING);
                    cell.addObject(new CHTMLText());
                    row.addObject(cell);

                    cell = new CHTMLTableCell(alignment.HEADING);
                    cell.addObject(new CHTMLText(dr["S_CODE"].ToString()));
                    row.addObject(cell);
                    cell = new CHTMLTableCell(alignment.HEADING);

                    cell.addObject(new CHTMLText(dr["S_DESC"].ToString()));
                    row.addObject(cell);


                    table.addObject(row);

               }
                row = new CHTMLTableRow();
                cell = new CHTMLTableCell(alignment.HEADING);
                cell.addObject(new CHTMLText());

                row.addObject(cell);
                table.addObject(row);

                row = new CHTMLTableRow();
                cell = new CHTMLTableCell(alignment.HEADING);
                cell.addObject(new CHTMLText());
                row.addObject(cell);
                table.addObject(row);
                row = new CHTMLTableRow();
                cell = new CHTMLTableCell(alignment.HEADING);
                cell.addObject(new CHTMLText());

                row.addObject(cell);
                table.addObject(row);

                row = new CHTMLTableRow();
                cell = new CHTMLTableCell(alignment.HEADING);
                cell.addObject(new CHTMLText());
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


        private void Report3()
        {

            CHTMLDocument ds = new CHTMLDocument();
            CHTMLText txt = new CHTMLText("Trial Balance");

            txt.setItalic(true);
            CHTMLHorizontalRule hr = new CHTMLHorizontalRule();
            CHTMLInput input = new CHTMLInput();
            //
            //
            //
            CHTMLTable table = new CHTMLTable();
            table.setBorder(1);
            table.setCaption(new CHTMLText("TRIAL BALANCE"));

            CHTMLTableRow row = null;
            row = new CHTMLTableRow();

            CHTMLTableCell cell = null;

            cell = new CHTMLTableCell(alignment.HEADING);
            cell.addObject(new CHTMLText("  Account "));
            row.addObject(cell);

            cell = new CHTMLTableCell(alignment.HEADING);
            cell.addObject(new CHTMLText("  DR "));
            row.addObject(cell);

            cell = new CHTMLTableCell(alignment.HEADING);
            cell.addObject(new CHTMLText("  CR "));
            row.addObject(cell);


            row.backgroundColor = "red";
            table.addObject(row);
            DataTable dt = TrialBalance.TrialTable();
            double crTotal = 0;
            double drTotal = 0;
            foreach (DataRow dr in dt.Rows)
            {
                row = new CHTMLTableRow();
                cell = new CHTMLTableCell(alignment.RIGHT);
                cell.addObject(new CHTMLText(dr["S_DESC"].ToString()));
                row.addObject(cell);
                cell = new CHTMLTableCell(alignment.RIGHT);

                double amnt = double.Parse(dr["Total"].ToString());
                if (amnt >= 0)
                {
                    cell.setHorizontalAlign(alignment.RIGHT);
                    cell.addObject(new CHTMLText(amnt.ToString()));
                    row.addObject(cell);
                    cell = new CHTMLTableCell(alignment.RIGHT);
                    cell.addObject(new CHTMLText("   "));
                    row.addObject(cell);
                    drTotal += amnt;
                    
                }
                else if (amnt < 0)
                {
                    amnt = -amnt;
                    cell.addObject(new CHTMLText("   "));
                    row.addObject(cell);
                    cell = new CHTMLTableCell(alignment.RIGHT);
                    cell.setHorizontalAlign(alignment.RIGHT);
                    cell.addObject(new CHTMLText(amnt.ToString()));
                    row.addObject(cell);
                    crTotal += amnt;
                }

                table.addObject(row);

            }
            row = new CHTMLTableRow();
            cell = new CHTMLTableCell(alignment.HEADING);
            cell.addObject(new CHTMLText("Total"));
            row.addObject(cell);

            
            cell = new CHTMLTableCell(alignment.HEADING);
            cell.addObject(new CHTMLText(drTotal.ToString()));
            row.addObject(cell);
            
            cell = new CHTMLTableCell(alignment.HEADING);
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


        private void Report4()
        {
#if false
            CHTMLDocument ds = new CHTMLDocument();
            CHTMLText txt = new CHTMLText("Items");

            txt.setItalic(true);
            CHTMLHorizontalRule hr = new CHTMLHorizontalRule();
            CHTMLInput input = new CHTMLInput();
            //
            //
            //
            CHTMLTable table = new CHTMLTable();
            table.setBorder(1);
            table.setCaption(new CHTMLText("Items"));

            CHTMLTableRow row = null;
            row = new CHTMLTableRow();

            CHTMLTableCell cell = null;

            cell = new CHTMLTableCell(alignment.HEADING);
            cell.addObject(new CHTMLText(" Sl No "));
            row.addObject(cell);

            cell = new CHTMLTableCell(alignment.HEADING);
            cell.addObject(new CHTMLText("  Name of products "));
            row.addObject(cell);

            cell = new CHTMLTableCell(alignment.HEADING);
            cell.addObject(new CHTMLText("  Vendor "));
            row.addObject(cell);


            cell = new CHTMLTableCell(alignment.HEADING);
            cell.addObject(new CHTMLText("  Unit "));
            row.addObject(cell);

            cell = new CHTMLTableCell(alignment.HEADING);
            cell.addObject(new CHTMLText("  Rate "));
            row.addObject(cell);

            cell = new CHTMLTableCell(alignment.HEADING);
            cell.addObject(new CHTMLText("  Quanity "));
            row.addObject(cell);

            cell = new CHTMLTableCell(alignment.HEADING);
            cell.addObject(new CHTMLText(" stock value "));
            row.addObject(cell);

            row.backgroundColor = "red";
            table.addObject(row);
            DataTable dt = InventoryLayer.Group.ListGroup();
            int j = 0;
            foreach (DataRow dr in dt.Rows)
            {
                j++;
                string code = dr["gcode"].ToString();
                row = new CHTMLTableRow();
                cell = new CHTMLTableCell(alignment.HEADING);
                cell.addObject(new CHTMLText(j.ToString() ));
                row.addObject(cell);

                cell = new CHTMLTableCell(alignment.HEADING);
                cell.addObject(new CHTMLText(dr["gname"].ToString()));
                row.addObject(cell);

                cell = new CHTMLTableCell(alignment.HEADING);
                cell.addObject(new CHTMLText());
                row.addObject(cell);

                cell = new CHTMLTableCell(alignment.HEADING);
                cell.addObject(new CHTMLText());
                row.addObject(cell);

                cell = new CHTMLTableCell(alignment.HEADING);
                cell.addObject(new CHTMLText());
                row.addObject(cell);

                cell = new CHTMLTableCell(alignment.HEADING);
                cell.addObject(new CHTMLText());
                row.addObject(cell);

                cell = new CHTMLTableCell(alignment.HEADING);
                cell.addObject(new CHTMLText());
                row.addObject(cell);


                table.addObject(row);

              
                
                DataTable dt1 = InventoryLayer.Items.GetItemByGroup(code);
                int i = 1;

                foreach (DataRow dr1 in dt1.Rows)
                {
                    
                    row = new CHTMLTableRow();
                    cell = new CHTMLTableCell(alignment.HEADING);
                    cell.addObject(new CHTMLText(j+"."+i.ToString() ));
                    row.addObject(cell);

                    cell = new CHTMLTableCell(alignment.HEADING);
                    cell.addObject(new CHTMLText(dr1["itemdesc"].ToString()));
                    row.addObject(cell);

                    cell = new CHTMLTableCell(alignment.HEADING);
                    cell.addObject(new CHTMLText(dr1["vendor"].ToString()));
                    row.addObject(cell);

                    cell = new CHTMLTableCell(alignment.HEADING);
                    cell.addObject(new CHTMLText(dr1["unit"].ToString()));
                    row.addObject(cell);

                    cell = new CHTMLTableCell(alignment.HEADING);
                    cell.addObject(new CHTMLText(dr1["rate"].ToString()));
                    row.addObject(cell);

                    cell = new CHTMLTableCell(alignment.HEADING);
                    cell.addObject(new CHTMLText(dr1["qty"].ToString()));
                    row.addObject(cell);

                    cell = new CHTMLTableCell(alignment.HEADING);
                    cell.addObject(new CHTMLText(dr1["stockvalue"].ToString()));
                    row.addObject(cell);

                    table.addObject(row);
                    i++;
                }

             }

            ds.addObject(table);
            string rs = ds.toHTML();

            FileStream fs = new FileStream(@"C:\temp\a.html", FileMode.Create);
            StreamWriter st = new StreamWriter(fs);
            st.Write(rs);
            st.Close();



            webBrowser1.Navigate(new Uri(@"file://c:\temp\a.html"));
            webBrowser1.Refresh();
#endif

        }

        private void Report5()
        {
#if false
            CHTMLDocument ds = new CHTMLDocument();
            CHTMLText txt = new CHTMLText("Party");

            txt.setItalic(true);
            CHTMLHorizontalRule hr = new CHTMLHorizontalRule();
            CHTMLInput input = new CHTMLInput();
            //
            //
            //
            CHTMLTable table = new CHTMLTable();
            table.setBorder(1);
            table.setCaption(new CHTMLText(" Party "));

            CHTMLTableRow row = null;
            row = new CHTMLTableRow();

            CHTMLTableCell cell = null;

            cell = new CHTMLTableCell(alignment.HEADING);
            cell.addObject(new CHTMLText("  Code "));
            row.addObject(cell);

            cell = new CHTMLTableCell(alignment.HEADING);
            cell.addObject(new CHTMLText("  Name "));
            row.addObject(cell);


            row.backgroundColor = "red";
            table.addObject(row);
            DataTable dt = InventoryLayer.Party.ListParty();
            foreach (DataRow dr in dt.Rows)
            {
                row = new CHTMLTableRow();
                cell = new CHTMLTableCell(alignment.HEADING);
                cell.addObject(new CHTMLText(dr["PCODE"].ToString()));
                row.addObject(cell);
                cell = new CHTMLTableCell(alignment.HEADING);

                cell.addObject(new CHTMLText(dr["Pname"].ToString()));
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

#endif
        }

        private void Report6()
        {
#if false
            CHTMLDocument ds = new CHTMLDocument();
            CHTMLText txt = new CHTMLText("Unit");

            txt.setItalic(true);
            CHTMLHorizontalRule hr = new CHTMLHorizontalRule();
            CHTMLInput input = new CHTMLInput();
            //
            //
            //
            CHTMLTable table = new CHTMLTable();
            table.setBorder(1);
            table.setCaption(new CHTMLText(" Unit "));

            CHTMLTableRow row = null;
            row = new CHTMLTableRow();

            CHTMLTableCell cell = null;

            cell = new CHTMLTableCell(alignment.HEADING);
            cell.addObject(new CHTMLText("  Code "));
            row.addObject(cell);

            cell = new CHTMLTableCell(alignment.HEADING);
            cell.addObject(new CHTMLText("  Name "));
            row.addObject(cell);


            row.backgroundColor = "red";
            table.addObject(row);
            DataTable dt = InventoryLayer.Unit.ListUnit();
            foreach (DataRow dr in dt.Rows)
            {
                row = new CHTMLTableRow();
                cell = new CHTMLTableCell(alignment.HEADING);
                cell.addObject(new CHTMLText(dr["UCODE"].ToString()));
                row.addObject(cell);
                cell = new CHTMLTableCell(alignment.HEADING);

                cell.addObject(new CHTMLText(dr["uname"].ToString()));
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

#endif
        }

        private void Report7()
        {
#if false
            CHTMLDocument ds = new CHTMLDocument();
            CHTMLText txt = new CHTMLText("Items");

            txt.setItalic(true);
            CHTMLHorizontalRule hr = new CHTMLHorizontalRule();
            CHTMLInput input = new CHTMLInput();
            //
            //
            //
            CHTMLTable table = new CHTMLTable();
            table.setBorder(1);
            table.setCaption(new CHTMLText("Items"));

            CHTMLTableRow row = null;
            row = new CHTMLTableRow();
            
            CHTMLTableCell cell = null;
            
            
            cell = new CHTMLTableCell(alignment.HEADING);
            cell.addObject(new CHTMLText(" Sl No "));
            row.addObject(cell);

            cell = new CHTMLTableCell(alignment.HEADING);
            cell.addObject(new CHTMLText("  Name of products "));
            row.addObject(cell);
                       
            table.addObject(row);

            row = new CHTMLTableRow();
            cell = new CHTMLTableCell(alignment.HEADING);
            cell.addObject(new CHTMLText());

            row.addObject(cell);
            table.addObject(row);

            row = new CHTMLTableRow();
            cell = new CHTMLTableCell(alignment.HEADING);
            cell.addObject(new CHTMLText());
            row.addObject(cell);
            table.addObject(row);

            
            DataTable dt = InventoryLayer.Group.ListGroup();
            int j = 0;
            foreach (DataRow dr in dt.Rows)
            {
                j++;
                string code = dr["gcode"].ToString();
                row = new CHTMLTableRow();
                cell = new CHTMLTableCell(alignment.HEADING);
                cell.addObject(new CHTMLText(j.ToString()));
                row.addObject(cell);

                cell = new CHTMLTableCell(alignment.HEADING);
                cell.addObject(new CHTMLText(dr["gname"].ToString()));
                row.addObject(cell);
                                
                table.addObject(row);



                DataTable dt1 = InventoryLayer.Items.GetItemByGroup(code);
                int i = 1;

                foreach (DataRow dr1 in dt1.Rows)
                {
                    
              
                    row = new CHTMLTableRow();
                    cell = new CHTMLTableCell(alignment.HEADING);
                    cell.addObject(new CHTMLText());
                    row.addObject(cell);
                    cell = new CHTMLTableCell(alignment.HEADING);
                    cell.addObject(new CHTMLText(j + "." + i.ToString()));
                    row.addObject(cell);

                    cell = new CHTMLTableCell(alignment.HEADING);
                    cell.addObject(new CHTMLText(dr1["itemdesc"].ToString()));
                    row.addObject(cell);


                    table.addObject(row);
                    i++;
                }

                row = new CHTMLTableRow();
                cell = new CHTMLTableCell(alignment.HEADING);
                cell.addObject(new CHTMLText());
                row.addObject(cell);
                table.addObject(row);
                row = new CHTMLTableRow();
                cell = new CHTMLTableCell(alignment.HEADING);
                cell.addObject(new CHTMLText());
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
#endif

        }
       
        private void Report100()
        {

            CHTMLDocument ds = new CHTMLDocument();
            CHTMLText txt = new CHTMLText("I AM A fool");

            txt.setItalic(true);
            CHTMLHorizontalRule hr = new CHTMLHorizontalRule();
            CHTMLInput input = new CHTMLInput();
            //
            //
            //
            CHTMLTable table = new CHTMLTable();
            table.setBorder(1);
            table.setCaption(new CHTMLText("HOO"));

            CHTMLTableRow row = null;
            row = new CHTMLTableRow();

            CHTMLTableCell cell = null;

            cell = new CHTMLTableCell(alignment.HEADING);
            cell.addObject(new CHTMLText(" MULTIPLICAND "));
            row.addObject(cell);

            cell = new CHTMLTableCell(alignment.HEADING);
            cell.addObject(new CHTMLText(" MULTIPLIER "));
            row.addObject(cell);

            cell = new CHTMLTableCell(alignment.HEADING);
            cell.addObject(new CHTMLText(" PRODUCT "));
            row.addObject(cell);
            row.backgroundColor = "red";
            table.addObject(row);

            for (int i = 0; i < 100; ++i)
            {
                row = new CHTMLTableRow();
                cell = new CHTMLTableCell(alignment.HEADING);
                cell.addObject(new CHTMLText(i.ToString()));
                row.addObject(cell);
                cell = new CHTMLTableCell(alignment.HEADING);
                int rst = 16;
                cell.addObject(new CHTMLText(rst.ToString()));
                row.addObject(cell);

                cell = new CHTMLTableCell(alignment.HEADING);
                rst = i * 16;
                cell.addObject(new CHTMLText(rst.ToString()));
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



        private void ReportForm_Load(object sender, EventArgs e)
        {
            if (_reportid == 1)
            {
                Report1();
                return;
            }
            else if (_reportid == 2)
            {
                Report2();
                return;
            }
            else if (_reportid == 3)
            {
                Report3();
                return;
            }

            else if (_reportid == 7)
            {
                Report7();
                return;
            }
            else if (_reportid == 5)
            {
                Report5();
                return;
            }

            else if (_reportid == 6)
            {
                Report6();
                return;
            }
        }
    }
}
