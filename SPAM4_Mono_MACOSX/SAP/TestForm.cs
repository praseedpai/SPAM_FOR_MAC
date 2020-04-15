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
using HTMLRenderKit;
using System.IO;


namespace SAP
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
#if false
            PopUpBox b = new PopUpBox();
            ArrayList arr = new ArrayList();
            arr.Add("one");
            arr.Add("two");
            arr.Add("three");
            arr.Add("four");
            arr.Add("five");
            arr.Add("six");
            b.SetArrayList(arr);
           ArrayList st =  b.Show();

           if (st == null)
           {
               MessageBox.Show("No item selected");
               return;
           }

#else
           
            DataTable dts = Group.ListGroup();

           ArrayList arr = GetSelectedItem.ItemSelect(dts, new int[] { 1 }, new int[] { 1});

           if (arr != null)
           {
               MessageBox.Show(arr[0].ToString());
           }

#endif


        }

        private void TestForm_Load(object sender, EventArgs e)
        {
           

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           // System.Configuration.Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(System.Configuration.ConfigurationUserLevel.None);

           // string prst = config.AppSettings.Settings["FAConnectionString"].Value;
            //  config.Save(ConfigurationSaveMode.Modified);
            //  ConfigurationManager.RefreshSection("appSettings");  


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
            
             cell =  new CHTMLTableCell(alignment.HEADING);
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
                  rst = i*16;
                 cell.addObject(new CHTMLText(rst.ToString()));
                 row.addObject(cell);

                 table.addObject(row); 
 
             }

             ds.addObject(table); 
 
           // CHTMLLink htmllink = new CHTMLLink();
           // htmllink.setHREF("http://www.google.com");
          //  htmllink.addObject(new CHTMLText("Google"));   
          //  ds.addObject(txt);
           // ds.addObject(hr);
          //  ds.addObject(table);
          
          //  ds.addObject(input);
          //  ds.addObject(new CHTMLLineBreak());  
           // ds.addObject(htmllink); 
           
            string rs = ds.toHTML();

            FileStream fs = new FileStream(@"C:\temp\a.html", FileMode.Create);
            StreamWriter st = new StreamWriter(fs); 
            st.Write(rs);
            st.Close();


            
            webBrowser1.Navigate(new Uri(@"file://c:\temp\a.html"));
            webBrowser1.Refresh(); 

   
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int x = JournalPoster.NextJournal();
            MessageBox.Show(x.ToString());
        }
    }
}
