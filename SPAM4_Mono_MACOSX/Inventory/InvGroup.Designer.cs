namespace Inventory
{
    partial class InvGroup
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
            this.popupbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.desctxt = new System.Windows.Forms.TextBox();
            this.codetxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.popupbtn);
            this.groupBox1.Controls.Add(this.deletebtn);
            this.groupBox1.Controls.Add(this.updatebtn);
            this.groupBox1.Controls.Add(this.addbtn);
            this.groupBox1.Controls.Add(this.desctxt);
            this.groupBox1.Controls.Add(this.codetxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(52, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(424, 239);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // popupbtn
            // 
            this.popupbtn.Location = new System.Drawing.Point(340, 68);
            this.popupbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.popupbtn.Name = "popupbtn";
            this.popupbtn.Size = new System.Drawing.Size(57, 28);
            this.popupbtn.TabIndex = 1;
            this.popupbtn.Text = "C";
            this.popupbtn.UseVisualStyleBackColor = true;
            this.popupbtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(285, 183);
            this.deletebtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(112, 28);
            this.deletebtn.TabIndex = 8;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(164, 183);
            this.updatebtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(112, 28);
            this.updatebtn.TabIndex = 7;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(42, 183);
            this.addbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(112, 28);
            this.addbtn.TabIndex = 6;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // desctxt
            // 
            this.desctxt.Location = new System.Drawing.Point(180, 124);
            this.desctxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.desctxt.Name = "desctxt";
            this.desctxt.Size = new System.Drawing.Size(193, 22);
            this.desctxt.TabIndex = 4;
            this.desctxt.TextChanged += new System.EventHandler(this.desctxt_TextChanged);
            // 
            // codetxt
            // 
            this.codetxt.Location = new System.Drawing.Point(180, 70);
            this.codetxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.codetxt.Name = "codetxt";
            this.codetxt.Size = new System.Drawing.Size(130, 22);
            this.codetxt.TabIndex = 3;
            this.codetxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.codetxt.MouseLeave += new System.EventHandler(this.codetxt_MouseLeave);
            this.codetxt.Leave += new System.EventHandler(this.codetxt_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Group Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Group Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(106, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Add Delete Update Group";
            // 
            // InvGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(534, 327);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "InvGroup";
            this.Text = "From to enter the group";
            this.Load += new System.EventHandler(this.InvGroup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.TextBox desctxt;
        private System.Windows.Forms.TextBox codetxt;
        private System.Windows.Forms.Button popupbtn;
        private System.Windows.Forms.Label label3;
    }
}

