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
    public partial class ShowJournal : Form
    {
        public ShowJournal()
        {
            InitializeComponent();
        }

        private void ShowJournalbtn_Click(object sender, EventArgs e)
        {
           string jid = Journaltxt.Text;

            Journal j = AccountLayer.JournalPoster.GetJournalFromId(jid);
           if (j == null || j.rs.Count == 0)
           {
               MessageBox.Show("Journal doesnot exist");
               return;
           }

           DataTable dt = JournalPoster.JournalEntryToDataTable(j.rs);
            
           this.dataGridView1.DataSource = dt;
           dataGridView1.Refresh();
           dataGridView1.ReadOnly = true;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
