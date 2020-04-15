using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Inventory
{
    public partial class InvAddForm : Form
    {
        public InvAddForm()
        {
            InitializeComponent();
        }

        private void grouplbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InvGroup gp = new InvGroup();
            gp.ShowDialog();
        }

        private void subgrouplbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InvItems sbp = new InvItems();
            sbp.ShowDialog();

        }

        private void purchaselbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddParty app = new AddParty();
            app.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UnitForm uf = new UnitForm();
            uf.Show();
        }
    }
}
