namespace SAP
{
    partial class AccountType
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
            this.AccTypeNametxt = new System.Windows.Forms.TextBox();
            this.AccClassCombo = new System.Windows.Forms.ComboBox();
            this.CBALtxt = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.UPdatebtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.AccTypeCodetxt = new System.Windows.Forms.TextBox();
            this.PopupBtn = new System.Windows.Forms.Button();
            this.Resetbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Type Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Account Type Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Account Class";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Current Balance";
            // 
            // AccTypeNametxt
            // 
            this.AccTypeNametxt.Location = new System.Drawing.Point(230, 106);
            this.AccTypeNametxt.Name = "AccTypeNametxt";
            this.AccTypeNametxt.Size = new System.Drawing.Size(121, 20);
            this.AccTypeNametxt.TabIndex = 6;
            this.AccTypeNametxt.TextChanged += new System.EventHandler(this.AccTypeNametxt_TextChanged);
            // 
            // AccClassCombo
            // 
            this.AccClassCombo.FormattingEnabled = true;
            this.AccClassCombo.Items.AddRange(new object[] {
            "ASSET",
            "LIABILITY",
            "EXPENSE",
            "INCOME"});
            this.AccClassCombo.Location = new System.Drawing.Point(230, 142);
            this.AccClassCombo.Name = "AccClassCombo";
            this.AccClassCombo.Size = new System.Drawing.Size(121, 21);
            this.AccClassCombo.TabIndex = 7;
            // 
            // CBALtxt
            // 
            this.CBALtxt.Location = new System.Drawing.Point(230, 183);
            this.CBALtxt.Name = "CBALtxt";
            this.CBALtxt.Size = new System.Drawing.Size(121, 20);
            this.CBALtxt.TabIndex = 8;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(435, 96);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 9;
            this.AddBtn.Text = "ADD";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // UPdatebtn
            // 
            this.UPdatebtn.Location = new System.Drawing.Point(435, 116);
            this.UPdatebtn.Name = "UPdatebtn";
            this.UPdatebtn.Size = new System.Drawing.Size(75, 23);
            this.UPdatebtn.TabIndex = 10;
            this.UPdatebtn.Text = "UPDATE";
            this.UPdatebtn.UseVisualStyleBackColor = true;
            this.UPdatebtn.Click += new System.EventHandler(this.UPdatebtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(435, 135);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(75, 23);
            this.deletebtn.TabIndex = 11;
            this.deletebtn.Text = "DELETE";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // AccTypeCodetxt
            // 
            this.AccTypeCodetxt.Location = new System.Drawing.Point(230, 68);
            this.AccTypeCodetxt.Name = "AccTypeCodetxt";
            this.AccTypeCodetxt.Size = new System.Drawing.Size(38, 20);
            this.AccTypeCodetxt.TabIndex = 12;
            this.AccTypeCodetxt.TextChanged += new System.EventHandler(this.AccTypeCodetxt_TextChanged);
            // 
            // PopupBtn
            // 
            this.PopupBtn.Location = new System.Drawing.Point(298, 66);
            this.PopupBtn.Name = "PopupBtn";
            this.PopupBtn.Size = new System.Drawing.Size(23, 23);
            this.PopupBtn.TabIndex = 13;
            this.PopupBtn.Text = "C";
            this.PopupBtn.UseVisualStyleBackColor = true;
            this.PopupBtn.Click += new System.EventHandler(this.PopupBtn_Click);
            // 
            // Resetbtn
            // 
            this.Resetbtn.Location = new System.Drawing.Point(435, 154);
            this.Resetbtn.Name = "Resetbtn";
            this.Resetbtn.Size = new System.Drawing.Size(75, 23);
            this.Resetbtn.TabIndex = 14;
            this.Resetbtn.Text = "RESET";
            this.Resetbtn.UseVisualStyleBackColor = true;
            this.Resetbtn.Click += new System.EventHandler(this.Resetbtn_Click);
            // 
            // AccountType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(522, 245);
            this.Controls.Add(this.Resetbtn);
            this.Controls.Add(this.PopupBtn);
            this.Controls.Add(this.AccTypeCodetxt);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.UPdatebtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.CBALtxt);
            this.Controls.Add(this.AccClassCombo);
            this.Controls.Add(this.AccTypeNametxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AccountType";
            this.Text = "Account Type";
            this.Load += new System.EventHandler(this.AccountType_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AccTypeNametxt;
        private System.Windows.Forms.ComboBox AccClassCombo;
        private System.Windows.Forms.TextBox CBALtxt;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button UPdatebtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.TextBox AccTypeCodetxt;
        private System.Windows.Forms.Button PopupBtn;
        private System.Windows.Forms.Button Resetbtn;
    }
}

