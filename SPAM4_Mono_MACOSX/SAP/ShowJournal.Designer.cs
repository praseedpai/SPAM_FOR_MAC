﻿namespace SAP
{
    partial class ShowJournal
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
            this.Journaltxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ShowJournalbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Journal Id";
            // 
            // Journaltxt
            // 
            this.Journaltxt.Location = new System.Drawing.Point(96, 19);
            this.Journaltxt.Name = "Journaltxt";
            this.Journaltxt.Size = new System.Drawing.Size(77, 20);
            this.Journaltxt.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 208);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ShowJournalbtn
            // 
            this.ShowJournalbtn.Location = new System.Drawing.Point(263, 14);
            this.ShowJournalbtn.Name = "ShowJournalbtn";
            this.ShowJournalbtn.Size = new System.Drawing.Size(61, 29);
            this.ShowJournalbtn.TabIndex = 3;
            this.ShowJournalbtn.Text = "Show";
            this.ShowJournalbtn.UseVisualStyleBackColor = true;
            this.ShowJournalbtn.Click += new System.EventHandler(this.ShowJournalbtn_Click);
            // 
            // ShowJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(343, 266);
            this.Controls.Add(this.ShowJournalbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Journaltxt);
            this.Controls.Add(this.label1);
            this.Name = "ShowJournal";
            this.Text = "ShowJournal";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Journaltxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ShowJournalbtn;
    }
}