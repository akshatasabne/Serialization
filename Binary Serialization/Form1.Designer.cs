namespace Binary_Serialization
{
    partial class Form1
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
            this.labelid = new System.Windows.Forms.Label();
            this.labelname = new System.Windows.Forms.Label();
            this.labprice = new System.Windows.Forms.Label();
            this.textid = new System.Windows.Forms.TextBox();
            this.textname = new System.Windows.Forms.TextBox();
            this.textprice = new System.Windows.Forms.TextBox();
            this.butwrite = new System.Windows.Forms.Button();
            this.butread = new System.Windows.Forms.Button();
            this.xwrite = new System.Windows.Forms.Button();
            this.xread = new System.Windows.Forms.Button();
            this.Sopapwrite = new System.Windows.Forms.Button();
            this.sread = new System.Windows.Forms.Button();
            this.jwrite = new System.Windows.Forms.Button();
            this.jread = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(62, 41);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(67, 16);
            this.labelid.TabIndex = 0;
            this.labelid.Text = "Product Id";
            this.labelid.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Location = new System.Drawing.Point(62, 97);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(93, 16);
            this.labelname.TabIndex = 1;
            this.labelname.Text = "Product Name";
            // 
            // labprice
            // 
            this.labprice.AutoSize = true;
            this.labprice.Location = new System.Drawing.Point(62, 168);
            this.labprice.Name = "labprice";
            this.labprice.Size = new System.Drawing.Size(87, 16);
            this.labprice.TabIndex = 2;
            this.labprice.Text = "Product Price";
            // 
            // textid
            // 
            this.textid.Location = new System.Drawing.Point(172, 41);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(119, 22);
            this.textid.TabIndex = 3;
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(172, 94);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(119, 22);
            this.textname.TabIndex = 4;
            // 
            // textprice
            // 
            this.textprice.Location = new System.Drawing.Point(172, 162);
            this.textprice.Name = "textprice";
            this.textprice.Size = new System.Drawing.Size(119, 22);
            this.textprice.TabIndex = 5;
            this.textprice.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // butwrite
            // 
            this.butwrite.Location = new System.Drawing.Point(418, 41);
            this.butwrite.Name = "butwrite";
            this.butwrite.Size = new System.Drawing.Size(93, 23);
            this.butwrite.TabIndex = 6;
            this.butwrite.Text = "BinaryWrite";
            this.butwrite.UseVisualStyleBackColor = true;
            this.butwrite.Click += new System.EventHandler(this.butwrite_Click);
            // 
            // butread
            // 
            this.butread.Location = new System.Drawing.Point(550, 41);
            this.butread.Name = "butread";
            this.butread.Size = new System.Drawing.Size(98, 23);
            this.butread.TabIndex = 7;
            this.butread.Text = "Binary Read";
            this.butread.UseVisualStyleBackColor = true;
            this.butread.Click += new System.EventHandler(this.butread_Click);
            // 
            // xwrite
            // 
            this.xwrite.Location = new System.Drawing.Point(418, 90);
            this.xwrite.Name = "xwrite";
            this.xwrite.Size = new System.Drawing.Size(93, 23);
            this.xwrite.TabIndex = 8;
            this.xwrite.Text = "XMLWrite";
            this.xwrite.UseVisualStyleBackColor = true;
            this.xwrite.Click += new System.EventHandler(this.xwrite_Click);
            // 
            // xread
            // 
            this.xread.Location = new System.Drawing.Point(550, 90);
            this.xread.Name = "xread";
            this.xread.Size = new System.Drawing.Size(98, 23);
            this.xread.TabIndex = 9;
            this.xread.Text = "XMLRead";
            this.xread.UseVisualStyleBackColor = true;
            this.xread.Click += new System.EventHandler(this.xread_Click);
            // 
            // Sopapwrite
            // 
            this.Sopapwrite.Location = new System.Drawing.Point(418, 144);
            this.Sopapwrite.Name = "Sopapwrite";
            this.Sopapwrite.Size = new System.Drawing.Size(93, 23);
            this.Sopapwrite.TabIndex = 10;
            this.Sopapwrite.Text = "SOAPWrite";
            this.Sopapwrite.UseVisualStyleBackColor = true;
            this.Sopapwrite.Click += new System.EventHandler(this.button5_Click);
            // 
            // sread
            // 
            this.sread.Location = new System.Drawing.Point(550, 144);
            this.sread.Name = "sread";
            this.sread.Size = new System.Drawing.Size(98, 23);
            this.sread.TabIndex = 11;
            this.sread.Text = "SOAPRead";
            this.sread.UseVisualStyleBackColor = true;
            this.sread.Click += new System.EventHandler(this.sread_Click);
            // 
            // jwrite
            // 
            this.jwrite.Location = new System.Drawing.Point(418, 194);
            this.jwrite.Name = "jwrite";
            this.jwrite.Size = new System.Drawing.Size(93, 23);
            this.jwrite.TabIndex = 12;
            this.jwrite.Text = "JSONWrite";
            this.jwrite.UseVisualStyleBackColor = true;
            this.jwrite.Click += new System.EventHandler(this.jwrite_Click);
            // 
            // jread
            // 
            this.jread.Location = new System.Drawing.Point(550, 194);
            this.jread.Name = "jread";
            this.jread.Size = new System.Drawing.Size(108, 23);
            this.jread.TabIndex = 13;
            this.jread.Text = "JSONRead";
            this.jread.UseVisualStyleBackColor = true;
            this.jread.Click += new System.EventHandler(this.jread_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.jread);
            this.Controls.Add(this.jwrite);
            this.Controls.Add(this.sread);
            this.Controls.Add(this.Sopapwrite);
            this.Controls.Add(this.xread);
            this.Controls.Add(this.xwrite);
            this.Controls.Add(this.butread);
            this.Controls.Add(this.butwrite);
            this.Controls.Add(this.textprice);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.textid);
            this.Controls.Add(this.labprice);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.labelid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labprice;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textprice;
        private System.Windows.Forms.Button butwrite;
        private System.Windows.Forms.Button butread;
        private System.Windows.Forms.Button xwrite;
        private System.Windows.Forms.Button xread;
        private System.Windows.Forms.Button Sopapwrite;
        private System.Windows.Forms.Button sread;
        private System.Windows.Forms.Button jwrite;
        private System.Windows.Forms.Button jread;
    }
}

