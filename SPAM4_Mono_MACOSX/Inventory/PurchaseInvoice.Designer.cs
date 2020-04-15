namespace Inventory
{
    partial class Invoice
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Clickbtn = new System.Windows.Forms.Button();
            this.invotypecmb = new System.Windows.Forms.ComboBox();
            this.addtxt = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.datepicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.reftxt = new System.Windows.Forms.TextBox();
            this.Crtxt = new System.Windows.Forms.TextBox();
            this.invotxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.delbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.gttxt = new System.Windows.Forms.TextBox();
            this.tottxt = new System.Windows.Forms.TextBox();
            this.termtxt = new System.Windows.Forms.TextBox();
            this.frgttxt = new System.Windows.Forms.TextBox();
            this.distxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.itemdatagridview = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemdatagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.Clickbtn);
            this.groupBox1.Controls.Add(this.invotypecmb);
            this.groupBox1.Controls.Add(this.addtxt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.datepicker);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.reftxt);
            this.groupBox1.Controls.Add(this.Crtxt);
            this.groupBox1.Controls.Add(this.invotxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(50, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(540, 153);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Clickbtn
            // 
            this.Clickbtn.Location = new System.Drawing.Point(255, 86);
            this.Clickbtn.Name = "Clickbtn";
            this.Clickbtn.Size = new System.Drawing.Size(47, 23);
            this.Clickbtn.TabIndex = 15;
            this.Clickbtn.Text = "C";
            this.Clickbtn.UseVisualStyleBackColor = true;
            this.Clickbtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // invotypecmb
            // 
            this.invotypecmb.FormattingEnabled = true;
            this.invotypecmb.Location = new System.Drawing.Point(142, 10);
            this.invotypecmb.Name = "invotypecmb";
            this.invotypecmb.Size = new System.Drawing.Size(141, 24);
            this.invotypecmb.TabIndex = 14;
            this.invotypecmb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // addtxt
            // 
            this.addtxt.Location = new System.Drawing.Point(413, 86);
            this.addtxt.Name = "addtxt";
            this.addtxt.Size = new System.Drawing.Size(108, 60);
            this.addtxt.TabIndex = 13;
            this.addtxt.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(326, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(326, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Shipping ";
            // 
            // datepicker
            // 
            this.datepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepicker.Location = new System.Drawing.Point(413, 48);
            this.datepicker.Name = "datepicker";
            this.datepicker.Size = new System.Drawing.Size(107, 22);
            this.datepicker.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date";
            // 
            // reftxt
            // 
            this.reftxt.Location = new System.Drawing.Point(142, 123);
            this.reftxt.Name = "reftxt";
            this.reftxt.Size = new System.Drawing.Size(146, 22);
            this.reftxt.TabIndex = 7;
            // 
            // Crtxt
            // 
            this.Crtxt.Location = new System.Drawing.Point(142, 86);
            this.Crtxt.Name = "Crtxt";
            this.Crtxt.Size = new System.Drawing.Size(107, 22);
            this.Crtxt.TabIndex = 6;
            // 
            // invotxt
            // 
            this.invotxt.Location = new System.Drawing.Point(142, 48);
            this.invotxt.Name = "invotxt";
            this.invotxt.Size = new System.Drawing.Size(146, 22);
            this.invotxt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Reference No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Creditor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Invoice No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(280, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = " Invoice";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.delbtn);
            this.groupBox2.Controls.Add(this.addbtn);
            this.groupBox2.Controls.Add(this.gttxt);
            this.groupBox2.Controls.Add(this.tottxt);
            this.groupBox2.Controls.Add(this.termtxt);
            this.groupBox2.Controls.Add(this.frgttxt);
            this.groupBox2.Controls.Add(this.distxt);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(50, 383);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(540, 155);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // delbtn
            // 
            this.delbtn.Location = new System.Drawing.Point(451, 66);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(75, 23);
            this.delbtn.TabIndex = 11;
            this.delbtn.Text = "Delete";
            this.delbtn.UseVisualStyleBackColor = true;
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(370, 66);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(75, 23);
            this.addbtn.TabIndex = 10;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // gttxt
            // 
            this.gttxt.Location = new System.Drawing.Point(117, 86);
            this.gttxt.Name = "gttxt";
            this.gttxt.Size = new System.Drawing.Size(132, 22);
            this.gttxt.TabIndex = 9;
            // 
            // tottxt
            // 
            this.tottxt.Location = new System.Drawing.Point(402, 18);
            this.tottxt.Name = "tottxt";
            this.tottxt.Size = new System.Drawing.Size(132, 22);
            this.tottxt.TabIndex = 8;
            // 
            // termtxt
            // 
            this.termtxt.Location = new System.Drawing.Point(117, 118);
            this.termtxt.Multiline = true;
            this.termtxt.Name = "termtxt";
            this.termtxt.Size = new System.Drawing.Size(132, 20);
            this.termtxt.TabIndex = 7;
            this.termtxt.TextChanged += new System.EventHandler(this.termtxt_TextChanged);
            // 
            // frgttxt
            // 
            this.frgttxt.Location = new System.Drawing.Point(117, 46);
            this.frgttxt.Name = "frgttxt";
            this.frgttxt.Size = new System.Drawing.Size(132, 22);
            this.frgttxt.TabIndex = 6;
            // 
            // distxt
            // 
            this.distxt.Location = new System.Drawing.Point(117, 15);
            this.distxt.Name = "distxt";
            this.distxt.Size = new System.Drawing.Size(132, 22);
            this.distxt.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(348, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 16);
            this.label12.TabIndex = 4;
            this.label12.Text = "Total";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "Grand Total";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Freight";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Credit Terms";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Discount";
            // 
            // itemdatagridview
            // 
            this.itemdatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemdatagridview.Location = new System.Drawing.Point(50, 154);
            this.itemdatagridview.Name = "itemdatagridview";
            this.itemdatagridview.Size = new System.Drawing.Size(540, 238);
            this.itemdatagridview.TabIndex = 12;
            this.itemdatagridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemdatagridview_CellContentClick);
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(648, 578);
            this.Controls.Add(this.itemdatagridview);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Invoice";
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.PurchaseInvoice_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemdatagridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker datepicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox reftxt;
        private System.Windows.Forms.TextBox Crtxt;
        private System.Windows.Forms.TextBox invotxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox addtxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox gttxt;
        private System.Windows.Forms.TextBox tottxt;
        private System.Windows.Forms.TextBox termtxt;
        private System.Windows.Forms.TextBox frgttxt;
        private System.Windows.Forms.TextBox distxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.ComboBox invotypecmb;
        private System.Windows.Forms.DataGridView itemdatagridview;
        private System.Windows.Forms.Button Clickbtn;
    }
}