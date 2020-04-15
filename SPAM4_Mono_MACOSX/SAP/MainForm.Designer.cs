namespace SAP
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAccountTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartOfAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteJournalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.journalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesReturnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ledgerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trialBalanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pLAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balanceSheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listChartOfAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showJournalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.partyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.unitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.journalToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(528, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editAccountTypeToolStripMenuItem,
            this.chartOfAccountsToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.fileToolStripMenuItem.Text = " Accounts";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // editAccountTypeToolStripMenuItem
            // 
            this.editAccountTypeToolStripMenuItem.Name = "editAccountTypeToolStripMenuItem";
            this.editAccountTypeToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.editAccountTypeToolStripMenuItem.Text = "&Edit Account Type";
            this.editAccountTypeToolStripMenuItem.Click += new System.EventHandler(this.editAccountTypeToolStripMenuItem_Click);
            // 
            // chartOfAccountsToolStripMenuItem
            // 
            this.chartOfAccountsToolStripMenuItem.Name = "chartOfAccountsToolStripMenuItem";
            this.chartOfAccountsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.chartOfAccountsToolStripMenuItem.Text = "&Chart Of Accounts";
            this.chartOfAccountsToolStripMenuItem.Click += new System.EventHandler(this.chartOfAccountsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteJournalToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.exitToolStripMenuItem.Text = "Journal";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.addToolStripMenuItem.Text = "Add Journal";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // deleteJournalToolStripMenuItem
            // 
            this.deleteJournalToolStripMenuItem.Name = "deleteJournalToolStripMenuItem";
            this.deleteJournalToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.deleteJournalToolStripMenuItem.Text = "Delete Journal";
            this.deleteJournalToolStripMenuItem.Click += new System.EventHandler(this.deleteJournalToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // journalToolStripMenuItem
            // 
            this.journalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.itemsToolStripMenuItem,
            this.salesReturnToolStripMenuItem});
            this.journalToolStripMenuItem.Name = "journalToolStripMenuItem";
            this.journalToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.journalToolStripMenuItem.Text = "Stock";
            this.journalToolStripMenuItem.Click += new System.EventHandler(this.journalToolStripMenuItem_Click);
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupToolStripMenuItem,
            this.unitToolStripMenuItem,
            this.partyToolStripMenuItem,
            this.itemsToolStripMenuItem1});
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.aToolStripMenuItem.Text = "Add";
            this.aToolStripMenuItem.Click += new System.EventHandler(this.aToolStripMenuItem_Click);
            // 
            // groupToolStripMenuItem
            // 
            this.groupToolStripMenuItem.Name = "groupToolStripMenuItem";
            this.groupToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.groupToolStripMenuItem.Text = "Group";
            this.groupToolStripMenuItem.Click += new System.EventHandler(this.groupToolStripMenuItem_Click);
            // 
            // unitToolStripMenuItem
            // 
            this.unitToolStripMenuItem.Name = "unitToolStripMenuItem";
            this.unitToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.unitToolStripMenuItem.Text = "Unit";
            this.unitToolStripMenuItem.Click += new System.EventHandler(this.unitToolStripMenuItem_Click);
            // 
            // partyToolStripMenuItem
            // 
            this.partyToolStripMenuItem.Name = "partyToolStripMenuItem";
            this.partyToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.partyToolStripMenuItem.Text = "Party";
            this.partyToolStripMenuItem.Click += new System.EventHandler(this.partyToolStripMenuItem_Click);
            // 
            // itemsToolStripMenuItem1
            // 
            this.itemsToolStripMenuItem1.Name = "itemsToolStripMenuItem1";
            this.itemsToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.itemsToolStripMenuItem1.Text = "Items";
            this.itemsToolStripMenuItem1.Click += new System.EventHandler(this.itemsToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.editToolStripMenuItem.Text = " Invoice";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.deleteToolStripMenuItem.Text = "Sales Invoice";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // itemsToolStripMenuItem
            // 
            this.itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            this.itemsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.itemsToolStripMenuItem.Text = "Purchase Return";
            // 
            // salesReturnToolStripMenuItem
            // 
            this.salesReturnToolStripMenuItem.Name = "salesReturnToolStripMenuItem";
            this.salesReturnToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.salesReturnToolStripMenuItem.Text = "Sales Return";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ledgerToolStripMenuItem,
            this.trialBalanceToolStripMenuItem,
            this.pLAccountsToolStripMenuItem,
            this.balanceSheetToolStripMenuItem,
            this.printScheduleToolStripMenuItem,
            this.listGroupToolStripMenuItem,
            this.listChartOfAccountsToolStripMenuItem,
            this.showJournalToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.reportsToolStripMenuItem.Text = "FA Reports";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // ledgerToolStripMenuItem
            // 
            this.ledgerToolStripMenuItem.Name = "ledgerToolStripMenuItem";
            this.ledgerToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.ledgerToolStripMenuItem.Text = "List Group";
            this.ledgerToolStripMenuItem.Click += new System.EventHandler(this.ledgerToolStripMenuItem_Click);
            // 
            // trialBalanceToolStripMenuItem
            // 
            this.trialBalanceToolStripMenuItem.Name = "trialBalanceToolStripMenuItem";
            this.trialBalanceToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.trialBalanceToolStripMenuItem.Text = "List Chart Of Accounts";
            this.trialBalanceToolStripMenuItem.Click += new System.EventHandler(this.trialBalanceToolStripMenuItem_Click);
            // 
            // pLAccountsToolStripMenuItem
            // 
            this.pLAccountsToolStripMenuItem.Name = "pLAccountsToolStripMenuItem";
            this.pLAccountsToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.pLAccountsToolStripMenuItem.Text = "Show Journal";
            this.pLAccountsToolStripMenuItem.Click += new System.EventHandler(this.pLAccountsToolStripMenuItem_Click);
            // 
            // balanceSheetToolStripMenuItem
            // 
            this.balanceSheetToolStripMenuItem.Name = "balanceSheetToolStripMenuItem";
            this.balanceSheetToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.balanceSheetToolStripMenuItem.Text = "Ledger";
            this.balanceSheetToolStripMenuItem.Click += new System.EventHandler(this.balanceSheetToolStripMenuItem_Click);
            // 
            // printScheduleToolStripMenuItem
            // 
            this.printScheduleToolStripMenuItem.Name = "printScheduleToolStripMenuItem";
            this.printScheduleToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.printScheduleToolStripMenuItem.Text = "Trail Balance";
            this.printScheduleToolStripMenuItem.Click += new System.EventHandler(this.printScheduleToolStripMenuItem_Click);
            // 
            // listGroupToolStripMenuItem
            // 
            this.listGroupToolStripMenuItem.Name = "listGroupToolStripMenuItem";
            this.listGroupToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.listGroupToolStripMenuItem.Text = "Profit & Loss";
            this.listGroupToolStripMenuItem.Click += new System.EventHandler(this.listGroupToolStripMenuItem_Click);
            // 
            // listChartOfAccountsToolStripMenuItem
            // 
            this.listChartOfAccountsToolStripMenuItem.Name = "listChartOfAccountsToolStripMenuItem";
            this.listChartOfAccountsToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.listChartOfAccountsToolStripMenuItem.Text = "Balance Sheet";
            this.listChartOfAccountsToolStripMenuItem.Click += new System.EventHandler(this.listChartOfAccountsToolStripMenuItem_Click);
            // 
            // showJournalToolStripMenuItem
            // 
            this.showJournalToolStripMenuItem.Name = "showJournalToolStripMenuItem";
            this.showJournalToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.showJournalToolStripMenuItem.Text = "Print Shedule";
            this.showJournalToolStripMenuItem.Click += new System.EventHandler(this.showJournalToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.partyToolStripMenuItem1,
            this.unitToolStripMenuItem1});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.helpToolStripMenuItem.Text = "Inventory Reports";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "Items";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(49, 20);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // partyToolStripMenuItem1
            // 
            this.partyToolStripMenuItem1.Name = "partyToolStripMenuItem1";
            this.partyToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.partyToolStripMenuItem1.Text = "Party";
            this.partyToolStripMenuItem1.Click += new System.EventHandler(this.partyToolStripMenuItem1_Click);
            // 
            // unitToolStripMenuItem1
            // 
            this.unitToolStripMenuItem1.Name = "unitToolStripMenuItem1";
            this.unitToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.unitToolStripMenuItem1.Text = "Unit";
            this.unitToolStripMenuItem1.Click += new System.EventHandler(this.unitToolStripMenuItem1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(528, 245);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Financial Accounting";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAccountTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartOfAccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem journalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ledgerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trialBalanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pLAccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balanceSheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listChartOfAccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showJournalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteJournalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salesReturnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem partyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem unitToolStripMenuItem1;
    }
}