namespace SAP
{
    partial class ShowLedger
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
            this.acctxt = new System.Windows.Forms.TextBox();
            this.Choosebtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.Showbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Code";
            // 
            // acctxt
            // 
            this.acctxt.Location = new System.Drawing.Point(102, 6);
            this.acctxt.Name = "acctxt";
            this.acctxt.Size = new System.Drawing.Size(100, 20);
            this.acctxt.TabIndex = 1;
            // 
            // Choosebtn
            // 
            this.Choosebtn.Location = new System.Drawing.Point(219, 6);
            this.Choosebtn.Name = "Choosebtn";
            this.Choosebtn.Size = new System.Drawing.Size(28, 23);
            this.Choosebtn.TabIndex = 2;
            this.Choosebtn.Text = "C";
            this.Choosebtn.UseVisualStyleBackColor = true;
            this.Choosebtn.Click += new System.EventHandler(this.Choosebtn_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(2, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 224);
            this.panel1.TabIndex = 3;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(2, 50);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(515, 261);
            this.webBrowser1.TabIndex = 0;
            // 
            // Showbtn
            // 
            this.Showbtn.Location = new System.Drawing.Point(389, 9);
            this.Showbtn.Name = "Showbtn";
            this.Showbtn.Size = new System.Drawing.Size(75, 31);
            this.Showbtn.TabIndex = 4;
            this.Showbtn.Text = "Show";
            this.Showbtn.UseVisualStyleBackColor = true;
            this.Showbtn.Click += new System.EventHandler(this.Showbtn_Click);
            // 
            // ShowLedger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(514, 311);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.Showbtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Choosebtn);
            this.Controls.Add(this.acctxt);
            this.Controls.Add(this.label1);
            this.Name = "ShowLedger";
            this.Text = "ShowLedger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox acctxt;
        private System.Windows.Forms.Button Choosebtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button Showbtn;
    }
}