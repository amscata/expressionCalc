namespace expressionCalc
{
    partial class frmExpCalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExpCalc));
            this.OK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.expText = new System.Windows.Forms.TextBox();
            this.answer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lnkAbout = new System.Windows.Forms.LinkLabel();
            this.pnlAbout = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.SystemColors.Control;
            this.OK.Enabled = false;
            this.OK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK.Location = new System.Drawing.Point(133, 97);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(209, 34);
            this.OK.TabIndex = 0;
            this.OK.Text = "Calculate Expression";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Mathematical Expression";
            // 
            // expText
            // 
            this.expText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.expText.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expText.Location = new System.Drawing.Point(14, 60);
            this.expText.Multiline = true;
            this.expText.Name = "expText";
            this.expText.Size = new System.Drawing.Size(447, 31);
            this.expText.TabIndex = 2;
            this.expText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.expText.TextChanged += new System.EventHandler(this.expression_TextChanged);
            // 
            // answer
            // 
            this.answer.BackColor = System.Drawing.SystemColors.Control;
            this.answer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.answer.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer.ForeColor = System.Drawing.Color.RoyalBlue;
            this.answer.Location = new System.Drawing.Point(78, 35);
            this.answer.Name = "answer";
            this.answer.ReadOnly = true;
            this.answer.Size = new System.Drawing.Size(383, 21);
            this.answer.TabIndex = 8;
            this.answer.Text = "0.0";
            this.answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(15, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Answer";
            // 
            // lnkAbout
            // 
            this.lnkAbout.AutoSize = true;
            this.lnkAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkAbout.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkAbout.LinkColor = System.Drawing.Color.Navy;
            this.lnkAbout.Location = new System.Drawing.Point(11, 166);
            this.lnkAbout.Name = "lnkAbout";
            this.lnkAbout.Size = new System.Drawing.Size(43, 16);
            this.lnkAbout.TabIndex = 11;
            this.lnkAbout.TabStop = true;
            this.lnkAbout.Text = "About";
            this.lnkAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAbout_LinkClicked);
            // 
            // pnlAbout
            // 
            this.pnlAbout.BackColor = System.Drawing.Color.White;
            this.pnlAbout.Controls.Add(this.btnBack);
            this.pnlAbout.Controls.Add(this.label8);
            this.pnlAbout.Controls.Add(this.label7);
            this.pnlAbout.Controls.Add(this.label5);
            this.pnlAbout.Controls.Add(this.label4);
            this.pnlAbout.Controls.Add(this.label3);
            this.pnlAbout.Controls.Add(this.pictureBox1);
            this.pnlAbout.Location = new System.Drawing.Point(0, 0);
            this.pnlAbout.Name = "pnlAbout";
            this.pnlAbout.Size = new System.Drawing.Size(475, 190);
            this.pnlAbout.TabIndex = 12;
            this.pnlAbout.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(407, 10);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(60, 26);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(440, 39);
            this.label8.TabIndex = 6;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(459, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Author : Amith Chinthaka <amscata@gmail.com> ©All rights reserved (2011 - 2013)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(101, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(356, 26);
            this.label5.TabIndex = 3;
            this.label5.Text = "expressionCalc ™ is a simple calculator, which can calculate mathematical\r\nexpres" +
                "sions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(101, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Use it, you feel easy...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "expressionCalc™  v1.1.1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::expressionCalc.Properties.Resources.expCalc;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(13, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmExpCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(474, 192);
            this.Controls.Add(this.pnlAbout);
            this.Controls.Add(this.lnkAbout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.expText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OK);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmExpCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "expressionCalc™";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlAbout.ResumeLayout(false);
            this.pnlAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox expText;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lnkAbout;
        private System.Windows.Forms.Panel pnlAbout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBack;
    }
}

