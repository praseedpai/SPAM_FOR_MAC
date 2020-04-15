namespace Inventory
{
    partial class InvAddForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.purchaselbl = new System.Windows.Forms.LinkLabel();
            this.subgrouplbl = new System.Windows.Forms.LinkLabel();
            this.grouplbl = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.purchaselbl);
            this.groupBox1.Controls.Add(this.subgrouplbl);
            this.groupBox1.Controls.Add(this.grouplbl);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(49, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(196, 226);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Delete Update";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(51, 101);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(35, 16);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Unit";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // purchaselbl
            // 
            this.purchaselbl.AutoSize = true;
            this.purchaselbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaselbl.LinkColor = System.Drawing.Color.Black;
            this.purchaselbl.Location = new System.Drawing.Point(51, 186);
            this.purchaselbl.Name = "purchaselbl";
            this.purchaselbl.Size = new System.Drawing.Size(44, 16);
            this.purchaselbl.TabIndex = 2;
            this.purchaselbl.TabStop = true;
            this.purchaselbl.Text = "Party";
            this.purchaselbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.purchaselbl_LinkClicked);
            // 
            // subgrouplbl
            // 
            this.subgrouplbl.AutoSize = true;
            this.subgrouplbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subgrouplbl.LinkColor = System.Drawing.Color.Black;
            this.subgrouplbl.Location = new System.Drawing.Point(51, 146);
            this.subgrouplbl.Name = "subgrouplbl";
            this.subgrouplbl.Size = new System.Drawing.Size(45, 16);
            this.subgrouplbl.TabIndex = 1;
            this.subgrouplbl.TabStop = true;
            this.subgrouplbl.Text = "Items";
            this.subgrouplbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.subgrouplbl_LinkClicked);
            // 
            // grouplbl
            // 
            this.grouplbl.AutoSize = true;
            this.grouplbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grouplbl.LinkColor = System.Drawing.Color.Black;
            this.grouplbl.Location = new System.Drawing.Point(51, 64);
            this.grouplbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.grouplbl.Name = "grouplbl";
            this.grouplbl.Size = new System.Drawing.Size(50, 16);
            this.grouplbl.TabIndex = 0;
            this.grouplbl.TabStop = true;
            this.grouplbl.Text = "Group";
            this.grouplbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.grouplbl_LinkClicked);
            // 
            // InvAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(319, 275);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InvAddForm";
            this.Text = "InventoryMainForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel grouplbl;
        private System.Windows.Forms.LinkLabel purchaselbl;
        private System.Windows.Forms.LinkLabel subgrouplbl;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
    }
}