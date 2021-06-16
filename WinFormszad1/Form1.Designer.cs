
namespace WinFormszad1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bKB = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxKB = new System.Windows.Forms.ComboBox();
            this.textBoxWKB = new System.Windows.Forms.TextBox();
            this.textBoxKB = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxBN = new System.Windows.Forms.ComboBox();
            this.bBN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxWBN = new System.Windows.Forms.TextBox();
            this.textBoxBN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxMNK = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBoxNK = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.bNK = new System.Windows.Forms.Button();
            this.textBoxWNK = new System.Windows.Forms.TextBox();
            this.textBoxNK = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBoxOKO = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxMKO = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBoxKO = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.bKO = new System.Windows.Forms.Button();
            this.textBoxWKO = new System.Windows.Forms.TextBox();
            this.textBoxKO = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kwota netto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kwota brutto:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bKB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxKB);
            this.groupBox1.Controls.Add(this.textBoxWKB);
            this.groupBox1.Controls.Add(this.textBoxKB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(34, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 149);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kwota na brutto ";
            // 
            // bKB
            // 
            this.bKB.Location = new System.Drawing.Point(99, 101);
            this.bKB.Name = "bKB";
            this.bKB.Size = new System.Drawing.Size(75, 23);
            this.bKB.TabIndex = 6;
            this.bKB.Text = "Wylicz";
            this.bKB.UseVisualStyleBackColor = true;
            this.bKB.Click += new System.EventHandler(this.bKB_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vat:";
            // 
            // comboBoxKB
            // 
            this.comboBoxKB.FormattingEnabled = true;
            this.comboBoxKB.Items.AddRange(new object[] {
            "23%",
            "8%",
            "7%",
            "5%",
            "0%"});
            this.comboBoxKB.Location = new System.Drawing.Point(235, 29);
            this.comboBoxKB.Name = "comboBoxKB";
            this.comboBoxKB.Size = new System.Drawing.Size(52, 23);
            this.comboBoxKB.TabIndex = 4;
            this.comboBoxKB.SelectedIndexChanged += new System.EventHandler(this.comboBoxKB_SelectedIndexChanged);
            // 
            // textBoxWKB
            // 
            this.textBoxWKB.Location = new System.Drawing.Point(89, 72);
            this.textBoxWKB.Name = "textBoxWKB";
            this.textBoxWKB.ReadOnly = true;
            this.textBoxWKB.Size = new System.Drawing.Size(140, 23);
            this.textBoxWKB.TabIndex = 3;
            // 
            // textBoxKB
            // 
            this.textBoxKB.Location = new System.Drawing.Point(87, 30);
            this.textBoxKB.Name = "textBoxKB";
            this.textBoxKB.Size = new System.Drawing.Size(100, 23);
            this.textBoxKB.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxBN);
            this.groupBox2.Controls.Add(this.bBN);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxWBN);
            this.groupBox2.Controls.Add(this.textBoxBN);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(418, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 149);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Brutto na netto";
            // 
            // comboBoxBN
            // 
            this.comboBoxBN.FormattingEnabled = true;
            this.comboBoxBN.Items.AddRange(new object[] {
            "23%",
            "8%",
            "7%",
            "5%",
            "0%"});
            this.comboBoxBN.Location = new System.Drawing.Point(235, 29);
            this.comboBoxBN.Name = "comboBoxBN";
            this.comboBoxBN.Size = new System.Drawing.Size(52, 23);
            this.comboBoxBN.TabIndex = 7;
            // 
            // bBN
            // 
            this.bBN.Location = new System.Drawing.Point(99, 101);
            this.bBN.Name = "bBN";
            this.bBN.Size = new System.Drawing.Size(75, 23);
            this.bBN.TabIndex = 6;
            this.bBN.Text = "Wylicz";
            this.bBN.UseVisualStyleBackColor = true;
            this.bBN.Click += new System.EventHandler(this.bBN_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Vat:";
            // 
            // textBoxWBN
            // 
            this.textBoxWBN.Location = new System.Drawing.Point(89, 72);
            this.textBoxWBN.Name = "textBoxWBN";
            this.textBoxWBN.ReadOnly = true;
            this.textBoxWBN.Size = new System.Drawing.Size(140, 23);
            this.textBoxWBN.TabIndex = 3;
            // 
            // textBoxBN
            // 
            this.textBoxBN.Location = new System.Drawing.Point(87, 30);
            this.textBoxBN.Name = "textBoxBN";
            this.textBoxBN.Size = new System.Drawing.Size(100, 23);
            this.textBoxBN.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Kwota netto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kwota brutto:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxMNK);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.comboBoxNK);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.bNK);
            this.groupBox3.Controls.Add(this.textBoxWNK);
            this.groupBox3.Controls.Add(this.textBoxNK);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(34, 221);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(293, 191);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Netto na kwotę końcową ";
            // 
            // comboBoxMNK
            // 
            this.comboBoxMNK.FormattingEnabled = true;
            this.comboBoxMNK.Items.AddRange(new object[] {
            "23%",
            "8%",
            "7%",
            "5%",
            "0%"});
            this.comboBoxMNK.Location = new System.Drawing.Point(188, 84);
            this.comboBoxMNK.Name = "comboBoxMNK";
            this.comboBoxMNK.Size = new System.Drawing.Size(52, 23);
            this.comboBoxMNK.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(145, 89);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 15);
            this.label15.TabIndex = 14;
            this.label15.Text = "Marża:";
            // 
            // comboBoxNK
            // 
            this.comboBoxNK.FormattingEnabled = true;
            this.comboBoxNK.Items.AddRange(new object[] {
            "23%",
            "8%",
            "7%",
            "5%",
            "0%"});
            this.comboBoxNK.Location = new System.Drawing.Point(49, 85);
            this.comboBoxNK.Name = "comboBoxNK";
            this.comboBoxNK.Size = new System.Drawing.Size(52, 23);
            this.comboBoxNK.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 15);
            this.label13.TabIndex = 10;
            this.label13.Text = "Vat:";
            // 
            // bNK
            // 
            this.bNK.Location = new System.Drawing.Point(97, 160);
            this.bNK.Name = "bNK";
            this.bNK.Size = new System.Drawing.Size(75, 23);
            this.bNK.TabIndex = 6;
            this.bNK.Text = "Wylicz";
            this.bNK.UseVisualStyleBackColor = true;
            this.bNK.Click += new System.EventHandler(this.bNK_Click);
            // 
            // textBoxWNK
            // 
            this.textBoxWNK.Location = new System.Drawing.Point(97, 128);
            this.textBoxWNK.Name = "textBoxWNK";
            this.textBoxWNK.ReadOnly = true;
            this.textBoxWNK.Size = new System.Drawing.Size(140, 23);
            this.textBoxWNK.TabIndex = 3;
            // 
            // textBoxNK
            // 
            this.textBoxNK.Location = new System.Drawing.Point(87, 30);
            this.textBoxNK.Name = "textBoxNK";
            this.textBoxNK.Size = new System.Drawing.Size(100, 23);
            this.textBoxNK.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Kwota Końcowa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Kwota netto:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBoxOKO);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.comboBoxMKO);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.comboBoxKO);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.bKO);
            this.groupBox4.Controls.Add(this.textBoxWKO);
            this.groupBox4.Controls.Add(this.textBoxKO);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(418, 221);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(370, 191);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kwota po odsetkach";
            // 
            // comboBoxOKO
            // 
            this.comboBoxOKO.FormattingEnabled = true;
            this.comboBoxOKO.Items.AddRange(new object[] {
            "0%",
            "1%",
            "2%"});
            this.comboBoxOKO.Location = new System.Drawing.Point(296, 85);
            this.comboBoxOKO.Name = "comboBoxOKO";
            this.comboBoxOKO.Size = new System.Drawing.Size(52, 23);
            this.comboBoxOKO.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(130, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Marża:";
            // 
            // comboBoxMKO
            // 
            this.comboBoxMKO.FormattingEnabled = true;
            this.comboBoxMKO.Items.AddRange(new object[] {
            "23%",
            "8%",
            "7%",
            "5%",
            "0%"});
            this.comboBoxMKO.Location = new System.Drawing.Point(177, 85);
            this.comboBoxMKO.Name = "comboBoxMKO";
            this.comboBoxMKO.Size = new System.Drawing.Size(52, 23);
            this.comboBoxMKO.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(248, 90);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 15);
            this.label14.TabIndex = 12;
            this.label14.Text = "Odsetki:";
            // 
            // comboBoxKO
            // 
            this.comboBoxKO.FormattingEnabled = true;
            this.comboBoxKO.Items.AddRange(new object[] {
            "23%",
            "8%",
            "7%",
            "5%",
            "0%"});
            this.comboBoxKO.Location = new System.Drawing.Point(47, 84);
            this.comboBoxKO.Name = "comboBoxKO";
            this.comboBoxKO.Size = new System.Drawing.Size(52, 23);
            this.comboBoxKO.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "Vat:";
            // 
            // bKO
            // 
            this.bKO.Location = new System.Drawing.Point(130, 160);
            this.bKO.Name = "bKO";
            this.bKO.Size = new System.Drawing.Size(75, 23);
            this.bKO.TabIndex = 6;
            this.bKO.Text = "Wylicz";
            this.bKO.UseVisualStyleBackColor = true;
            this.bKO.Click += new System.EventHandler(this.bKO_Click);
            // 
            // textBoxWKO
            // 
            this.textBoxWKO.Location = new System.Drawing.Point(168, 131);
            this.textBoxWKO.Name = "textBoxWKO";
            this.textBoxWKO.ReadOnly = true;
            this.textBoxWKO.Size = new System.Drawing.Size(140, 23);
            this.textBoxWKO.TabIndex = 3;
            // 
            // textBoxKO
            // 
            this.textBoxKO.Location = new System.Drawing.Point(87, 30);
            this.textBoxKO.Name = "textBoxKO";
            this.textBoxKO.Size = new System.Drawing.Size(100, 23);
            this.textBoxKO.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(168, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "Kwota końcowa po odsetkach ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Kwota netto:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bKB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxKB;
        private System.Windows.Forms.TextBox textBoxWKB;
        private System.Windows.Forms.TextBox textBoxKB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxBN;
        private System.Windows.Forms.Button bBN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxWBN;
        private System.Windows.Forms.TextBox textBoxBN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxMNK;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBoxNK;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button bNK;
        private System.Windows.Forms.TextBox textBoxWNK;
        private System.Windows.Forms.TextBox textBoxNK;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBoxMKO;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBoxKO;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button bKO;
        private System.Windows.Forms.TextBox textBoxWKO;
        private System.Windows.Forms.TextBox textBoxKO;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxOKO;
        private System.Windows.Forms.Label label7;
    }
}

