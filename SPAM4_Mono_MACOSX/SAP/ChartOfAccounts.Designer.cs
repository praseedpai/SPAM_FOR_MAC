namespace SAP
{
    partial class ChartOfAccounts
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AccTypeCombo = new System.Windows.Forms.ComboBox();
            this.DRCRCombo = new System.Windows.Forms.ComboBox();
            this.AccDestxt = new System.Windows.Forms.TextBox();
            this.OPBALTXT = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.AccCodetxt = new System.Windows.Forms.TextBox();
            this.popupbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Account Type Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Opening Balance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dr/Cr";
            // 
            // AccTypeCombo
            // 
            this.AccTypeCombo.FormattingEnabled = true;
            this.AccTypeCombo.Location = new System.Drawing.Point(210, 95);
            this.AccTypeCombo.Name = "AccTypeCombo";
            this.AccTypeCombo.Size = new System.Drawing.Size(159, 21);
            this.AccTypeCombo.TabIndex = 6;
            this.AccTypeCombo.SelectedIndexChanged += new System.EventHandler(this.AccTypeCombo_SelectedIndexChanged);
            // 
            // DRCRCombo
            // 
            this.DRCRCombo.FormattingEnabled = true;
            this.DRCRCombo.Location = new System.Drawing.Point(210, 167);
            this.DRCRCombo.Name = "DRCRCombo";
            this.DRCRCombo.Size = new System.Drawing.Size(87, 21);
            this.DRCRCombo.TabIndex = 7;
            // 
            // AccDestxt
            // 
            this.AccDestxt.Location = new System.Drawing.Point(210, 62);
            this.AccDestxt.Name = "AccDestxt";
            this.AccDestxt.Size = new System.Drawing.Size(159, 20);
            this.AccDestxt.TabIndex = 8;
            // 
            // OPBALTXT
            // 
            this.OPBALTXT.Location = new System.Drawing.Point(210, 133);
            this.OPBALTXT.Name = "OPBALTXT";
            this.OPBALTXT.Size = new System.Drawing.Size(87, 20);
            this.OPBALTXT.TabIndex = 9;
            this.OPBALTXT.TextChanged += new System.EventHandler(this.OPBALTXT_TextChanged);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(435, 55);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 10;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(435, 74);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(75, 23);
            this.updatebtn.TabIndex = 11;
            this.updatebtn.Text = "UPDATE";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(435, 93);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 12;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.Location = new System.Drawing.Point(435, 112);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(75, 23);
            this.clearbtn.TabIndex = 13;
            this.clearbtn.Text = "CLEAR";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // AccCodetxt
            // 
            this.AccCodetxt.Location = new System.Drawing.Point(210, 30);
            this.AccCodetxt.Name = "AccCodetxt";
            this.AccCodetxt.Size = new System.Drawing.Size(87, 20);
            this.AccCodetxt.TabIndex = 14;
            // 
            // popupbtn
            // 
            this.popupbtn.Location = new System.Drawing.Point(315, 28);
            this.popupbtn.Name = "popupbtn";
            this.popupbtn.Size = new System.Drawing.Size(54, 23);
            this.popupbtn.TabIndex = 15;
            this.popupbtn.Text = "C";
            this.popupbtn.UseVisualStyleBackColor = true;
            this.popupbtn.Click += new System.EventHandler(this.popupbtn_Click);
            // 
            // ChartOfAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(522, 245);
            this.Controls.Add(this.popupbtn);
            this.Controls.Add(this.AccCodetxt);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.OPBALTXT);
            this.Controls.Add(this.AccDestxt);
            this.Controls.Add(this.DRCRCombo);
            this.Controls.Add(this.AccTypeCombo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChartOfAccounts";
            this.Text = " Chart of accounts";
            this.Load += new System.EventHandler(this.ChartOfAccounts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox AccTypeCombo;
        private System.Windows.Forms.ComboBox DRCRCombo;
        private System.Windows.Forms.TextBox AccDestxt;
        private System.Windows.Forms.TextBox OPBALTXT;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.TextBox AccCodetxt;
        private System.Windows.Forms.Button popupbtn;
    }
}