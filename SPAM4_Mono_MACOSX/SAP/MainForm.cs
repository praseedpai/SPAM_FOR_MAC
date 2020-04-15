using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AccountLayer;
//using Inventory;

namespace SAP
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void chartOfAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChartOfAccounts ca = new ChartOfAccounts();
            ca.ShowDialog();
        }

        private void editAccountTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountType at = new AccountType();
            at.ShowDialog();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void journalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void listGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowP_L pl = new ShowP_L();
            pl.Show();
        }

        private void listChartOfAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowBalanceSheet bs = new ShowBalanceSheet();
            bs.Show();
        }

        private void trialBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm frm = new ReportForm();
            frm.SetReport(2);
            frm.ShowDialog();
        }

        private void ledgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm frm = new ReportForm();
            frm.SetReport(1);
            frm.ShowDialog();
        }

        private void showJournalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void pLAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowJournal sh = new ShowJournal();
            sh.ShowDialog();       
                                
        }

        private void balanceSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLedger sl = new ShowLedger();
            sl.ShowDialog();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JournalAdd add = new JournalAdd();
            add.ShowDialog();
        }

        private void deleteJournalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JournalDelete jd = new JournalDelete();
            jd.ShowDialog();
        }

        private void groupToolStripMenuItem_Click(object sender, EventArgs e)
        {
         //   InvGroup inv = new InvGroup();
         //   inv.Show();
        }

        private void unitToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  UnitForm uf = new UnitForm();
           // uf.Show();
        }

        private void partyToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  AddParty ap = new AddParty();
          //  ap.Show();
        }

        private void itemsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          //  InvItems it = new InvItems();
          //  it.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // Invoice pv = new Invoice();
           // pv.Show();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm frm = new ReportForm();
            frm.SetReport(7);
            frm.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void partyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReportForm frm = new ReportForm();
            frm.SetReport(5);
            frm.ShowDialog();
        }

        private void unitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReportForm frm = new ReportForm();
            frm.SetReport(6);
            frm.ShowDialog();
        }

        private void printScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm frm = new ReportForm();
            frm.SetReport(3);
            frm.ShowDialog();
        }
    }
}
