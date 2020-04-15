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
    public partial class AddSap : Form
    {
        public AddSap()
        {
            InitializeComponent();
        }

        private void AddSap_Load(object sender, EventArgs e)
        {
            DataTable dt = SubGroup.ViewSubGroup();
            DataGridViewComboBoxColumn cb = new DataGridViewComboBoxColumn();

            cb.DataSource = dt;
            cb.HeaderText = "Account Name";
            cb.DisplayMember = "S_DESC";

           JournalGridView1.Columns.Add(cb);

           DataTable mytable = new DataTable();
           DataColumn mycolumn = new DataColumn();
           mycolumn.DataType = System.Type.GetType("System.String");
           mycolumn.ReadOnly = false;
           mycolumn.Unique = true;
           mycolumn.ColumnName = "Account";

           mytable.Columns.Add(mycolumn);

           DataRow dr = mytable.NewRow();
           dr["Account"] = "DR";
           mytable.Rows.Add(dr);
           mytable.AcceptChanges();

           dr = mytable.NewRow();
           dr["Account"] = "CR";
           mytable.Rows.Add(dr);
           mytable.AcceptChanges();

           cb = new DataGridViewComboBoxColumn();
           cb.DisplayMember = "Account";
           cb.DataSource = mytable;
           cb.HeaderText = "Debit/Credit";

           JournalGridView1.Columns.Add(cb);

           DataGridViewTextBoxColumn tc = new DataGridViewTextBoxColumn();
           tc.HeaderText = "Amount";
           JournalGridView1.Columns.Add(tc);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void JournalGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hti;
            hti = JournalGridView1.HitTest(e.X, e.Y);

            if (hti == null)
            {
                return;
            }

            switch (hti.Type)
            {
                case System.Windows.Forms.DataGridViewHitTestType.RowHeader:
                    {
                        int rownum = hti.RowIndex;
                        DataGridViewRow dr = JournalGridView1.Rows[rownum];

                        try
                        {
                            JournalGridView1.Rows.Remove(dr);
                        }
                        catch (Exception er)
                        {
                            er.ToString();
                        }
                    }
                    break;
            }
        }
    }
}
