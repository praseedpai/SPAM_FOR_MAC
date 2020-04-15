using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AccountLayer;


namespace SAP
{ 
    
    public partial class JournalAdd : Form
    {
        /// <summary>
        /// Ctor
        /// </summary>
        public JournalAdd()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Populating the datagrid and 
        /// retrieving the next journal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void JournalAdd_Load(object sender, EventArgs e)
        {                    
             DataTable dt = SubGroup.ViewSubGroup();
              
             ///////////////////////////////////
            //// Account name 

             DataGridViewComboBoxColumn cw1 = new 
                 DataGridViewComboBoxColumn();

            cw1.DataSource = dt;
            cw1.DisplayMember  = "S_DESC";
            cw1.HeaderText = "ACCOUNT";

            this.JournalGridView.Columns.Add(cw1);


            ///////////////////////////////////////
            ////// debit or Credit
            //////

            DataTable myDataTable = new DataTable();
            DataColumn myDataColumn;
            myDataColumn = new DataColumn();
            myDataColumn.DataType = System.Type.GetType("System.String");
            myDataColumn.ColumnName = "Account";
            myDataColumn.ReadOnly = false;
            myDataColumn.Unique = true;
            myDataTable.Columns.Add(myDataColumn);
            DataRow dr = myDataTable.NewRow();
            dr["Account"] = "DR";
            myDataTable.Rows.Add(dr); 
            myDataTable.AcceptChanges();
            dr = myDataTable.NewRow();
            dr["Account"] = "CR";
            myDataTable.Rows.Add(dr);
            myDataTable.AcceptChanges();
            DataGridViewComboBoxColumn cw = new
                 DataGridViewComboBoxColumn();

            cw.DataSource = myDataTable;
            cw.DisplayMember = "Account";
            cw.HeaderText = "DRCR";
            this.JournalGridView.Columns.Add(cw);

            //////////////////////////////////////
            //// Amount Column
            ////
            DataGridViewTextBoxColumn tx = new DataGridViewTextBoxColumn();
           // DataGridViewTextBoxColumn ct = new DataGridViewTextBoxColumn();
            tx.HeaderText = "Amount";
            this.JournalGridView.Columns.Add(tx);

            ///////////////////////////////////////
            ///// Retrieve next journal id
            /////
            int rst = JournalPoster.NextJournal();
            this.journalidtxt.Text = rst.ToString();
             
        }

        private void PostBtn_Click(object sender, EventArgs e)
        {

            int jnum = Convert.ToInt32(journalidtxt.Text);
            string jd = dateTimePicker1.Text;
            string narr = NarrTxt.Text;
            Journal rst = new Journal();
            rst.jid = jnum.ToString();
            rst.jdate = jd;
            rst.narration = narr;

            List<JournalEntry> st = new List<JournalEntry>();
  
            int rs = this.JournalGridView.Rows.Count;

            for (int i = 0; i < rs-1; ++i)
            {
                DataGridViewRow dr = this.JournalGridView.Rows[i];
                JournalEntry jr = new JournalEntry(); 
                for (int j = 0; j < 3; ++j)
                {

                    DataGridViewCell c = dr.Cells[j];
                    if (c.Value != null)
                    {
                        if (j == 0)
                            jr.jname = c.Value.ToString();
                        else if (j == 1)
                            jr.drcr = c.Value.ToString();
                        else if (j == 2)
                            jr.amount = c.Value.ToString();
 
                    }
                }

                st.Add(jr);

            }

            rst.rs = st;
            if (!JournalPoster.PostForAdd(rst))
            {

                MessageBox.Show("Anomaly in Posting");
                return;
            }
        }

        private void JournalGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hti;
            hti = JournalGridView.HitTest(e.X, e.Y);

            if (hti == null) return;

            switch (hti.Type)
            {
                case System.Windows.Forms.DataGridViewHitTestType.RowHeader:
                    {
                        int rownum = hti.RowIndex;
                        DataGridViewRow dr = JournalGridView.Rows[rownum];

                        try
                        {
                            JournalGridView.Rows.Remove(dr);
                        }
                        catch (Exception ers)
                        {
                            ers.ToString();

                        }

                    }
                    break;
            }
        }
    }
}
