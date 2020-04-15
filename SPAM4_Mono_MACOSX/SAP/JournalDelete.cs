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
    public partial class JournalDelete : Form
    {
        public JournalDelete()
        {
            InitializeComponent();
        }

        private void NarrTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void journalidtxt_Leave(object sender, EventArgs e)
        {
            string jid = journalidtxt.Text;
            if (!(JournalPoster.IsValidJournal(jid)))
            {
                MessageBox.Show("Invalid Journal");
                return;
            }
            Journal j = JournalPoster.GetJournalFromId(jid);
            dateTimePicker1.Text = j.jdate;
            NarrTxt.Text = j.narration;
            DataTable dt = JournalPoster.JournalEntryToDataTable(j.rs);
            this.JournalGridView.DataSource = dt;
            this.JournalGridView.Refresh();
            this.JournalGridView.ReadOnly = true;
            PostBtn.Enabled = true;
        }

        private void JournalDelete_Load(object sender, EventArgs e)
        {
            PostBtn.Enabled = false;
        }

        private void PostBtn_Click(object sender, EventArgs e)
        {
            string jid = journalidtxt.Text;
            if (!(JournalPoster.DeleteJournal(jid)))
            {
                MessageBox.Show("Fail to delete Journal");
                return;
            }

        }

        private void PostBtn_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
