using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SAP
{
    public partial class MainReportForm : Form
    {
        public MainReportForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ReportForm frm = new ReportForm();
            frm.SetReport(1);
            frm.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ReportForm frm = new ReportForm();
            frm.SetReport(2);
            frm.ShowDialog();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ReportForm frm = new ReportForm();
            frm.SetReport(3);
            frm.ShowDialog();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowLedger sl = new ShowLedger();
            sl.ShowDialog();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowJournal sh = new ShowJournal();
            sh.ShowDialog();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowP_L pl = new ShowP_L();
            pl.Show();
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowBalanceSheet bs = new ShowBalanceSheet();
            bs.Show();
        }
    }
}
