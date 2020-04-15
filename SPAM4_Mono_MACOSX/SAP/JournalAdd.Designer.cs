namespace SAP
{
    partial class JournalAdd
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PostBtn = new System.Windows.Forms.Button();
            this.NarrTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.datelabel = new System.Windows.Forms.Label();
            this.journalidtxt = new System.Windows.Forms.TextBox();
            this.Journalidlabel = new System.Windows.Forms.Label();
            this.JournalGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JournalGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.PostBtn);
            this.groupBox1.Controls.Add(this.NarrTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.datelabel);
            this.groupBox1.Controls.Add(this.journalidtxt);
            this.groupBox1.Controls.Add(this.Journalidlabel);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // PostBtn
            // 
            this.PostBtn.Location = new System.Drawing.Point(260, 49);
            this.PostBtn.Name = "PostBtn";
            this.PostBtn.Size = new System.Drawing.Size(75, 33);
            this.PostBtn.TabIndex = 4;
            this.PostBtn.Text = "Post";
            this.PostBtn.UseVisualStyleBackColor = true;
            this.PostBtn.Click += new System.EventHandler(this.PostBtn_Click);
            // 
            // NarrTxt
            // 
            this.NarrTxt.Location = new System.Drawing.Point(68, 49);
            this.NarrTxt.Multiline = true;
            this.NarrTxt.Name = "NarrTxt";
            this.NarrTxt.Size = new System.Drawing.Size(177, 33);
            this.NarrTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Narration";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(245, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(90, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // datelabel
            // 
            this.datelabel.AutoSize = true;
            this.datelabel.Location = new System.Drawing.Point(196, 19);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(30, 13);
            this.datelabel.TabIndex = 2;
            this.datelabel.Text = "Date";
            // 
            // journalidtxt
            // 
            this.journalidtxt.Location = new System.Drawing.Point(80, 16);
            this.journalidtxt.Name = "journalidtxt";
            this.journalidtxt.Size = new System.Drawing.Size(100, 20);
            this.journalidtxt.TabIndex = 1;
            // 
            // Journalidlabel
            // 
            this.Journalidlabel.AutoSize = true;
            this.Journalidlabel.Location = new System.Drawing.Point(12, 16);
            this.Journalidlabel.Name = "Journalidlabel";
            this.Journalidlabel.Size = new System.Drawing.Size(53, 13);
            this.Journalidlabel.TabIndex = 0;
            this.Journalidlabel.Text = "Journal Id";
            // 
            // JournalGridView
            // 
            this.JournalGridView.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.JournalGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.JournalGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.JournalGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.JournalGridView.GridColor = System.Drawing.Color.MistyRose;
            this.JournalGridView.Location = new System.Drawing.Point(-3, 94);
            this.JournalGridView.Name = "JournalGridView";
            this.JournalGridView.Size = new System.Drawing.Size(345, 240);
            this.JournalGridView.TabIndex = 5;
            this.JournalGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.JournalGridView_MouseDoubleClick);
            // 
            // JournalAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(340, 333);
            this.Controls.Add(this.JournalGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "JournalAdd";
            this.Text = "JournalAdd";
            this.Load += new System.EventHandler(this.JournalAdd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JournalGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.TextBox journalidtxt;
        private System.Windows.Forms.Label Journalidlabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox NarrTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView JournalGridView;
       
        private System.Windows.Forms.BindingSource fASubGroupBindingSource;
       
        private System.Windows.Forms.BindingSource fASubGroupBindingSource1;
        private System.Windows.Forms.Button PostBtn;
    }
}