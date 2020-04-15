namespace SAP
{
    partial class ShowBalanceSheet
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.showbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clstocktxt = new System.Windows.Forms.TextBox();
            this.pltxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(0, 69);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(588, 332);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // showbtn
            // 
            this.showbtn.Location = new System.Drawing.Point(500, 40);
            this.showbtn.Name = "showbtn";
            this.showbtn.Size = new System.Drawing.Size(75, 23);
            this.showbtn.TabIndex = 1;
            this.showbtn.Text = "Show";
            this.showbtn.UseVisualStyleBackColor = true;
            this.showbtn.Click += new System.EventHandler(this.showbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Closing Stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Profit and Loss brought down ";
            // 
            // clstocktxt
            // 
            this.clstocktxt.Location = new System.Drawing.Point(103, 6);
            this.clstocktxt.Name = "clstocktxt";
            this.clstocktxt.Size = new System.Drawing.Size(113, 20);
            this.clstocktxt.TabIndex = 4;
            // 
            // pltxt
            // 
            this.pltxt.Location = new System.Drawing.Point(166, 37);
            this.pltxt.Name = "pltxt";
            this.pltxt.Size = new System.Drawing.Size(113, 20);
            this.pltxt.TabIndex = 5;
            // 
            // ShowBalanceSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(587, 405);
            this.Controls.Add(this.pltxt);
            this.Controls.Add(this.clstocktxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showbtn);
            this.Controls.Add(this.webBrowser1);
            this.Name = "ShowBalanceSheet";
            this.Text = "BalanceSheet";
            this.Load += new System.EventHandler(this.ShowBalanceSheet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button showbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox clstocktxt;
        private System.Windows.Forms.TextBox pltxt;
    }
}