﻿namespace MV_Dağılımı
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
			this.label8 = new System.Windows.Forms.Label();
			this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
			this.label9 = new System.Windows.Forms.Label();
			this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
			this.label10 = new System.Windows.Forms.Label();
			this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(1062, 5);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(91, 53);
			this.button1.TabIndex = 0;
			this.button1.Text = "Hesapla";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(173, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Toplam seçmen";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(145, 24);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(161, 22);
			this.textBox1.TabIndex = 2;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(359, 5);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "Katılım oranı";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(362, 25);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(61, 22);
			this.numericUpDown1.TabIndex = 4;
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(486, 5);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 16);
			this.label3.TabIndex = 5;
			this.label3.Text = "Geçerli oy";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(492, 27);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(0, 16);
			this.label4.TabIndex = 6;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(606, 24);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(92, 22);
			this.textBox2.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(594, 5);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(123, 16);
			this.label5.TabIndex = 7;
			this.label5.Text = "Toplam vekil sayısı";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(111, 98);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(33, 16);
			this.label6.TabIndex = 9;
			this.label6.Text = "AKP";
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.Location = new System.Drawing.Point(102, 117);
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(61, 22);
			this.numericUpDown2.TabIndex = 10;
			// 
			// numericUpDown3
			// 
			this.numericUpDown3.Location = new System.Drawing.Point(245, 117);
			this.numericUpDown3.Name = "numericUpDown3";
			this.numericUpDown3.Size = new System.Drawing.Size(61, 22);
			this.numericUpDown3.TabIndex = 12;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(254, 98);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(37, 16);
			this.label7.TabIndex = 11;
			this.label7.Text = "MHP";
			// 
			// numericUpDown4
			// 
			this.numericUpDown4.Location = new System.Drawing.Point(394, 117);
			this.numericUpDown4.Name = "numericUpDown4";
			this.numericUpDown4.Size = new System.Drawing.Size(61, 22);
			this.numericUpDown4.TabIndex = 14;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(403, 98);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(35, 16);
			this.label8.TabIndex = 13;
			this.label8.Text = "CHP";
			// 
			// numericUpDown5
			// 
			this.numericUpDown5.Location = new System.Drawing.Point(535, 130);
			this.numericUpDown5.Name = "numericUpDown5";
			this.numericUpDown5.Size = new System.Drawing.Size(61, 22);
			this.numericUpDown5.TabIndex = 16;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(544, 98);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(31, 16);
			this.label9.TabIndex = 15;
			this.label9.Text = "İYİP";
			// 
			// numericUpDown6
			// 
			this.numericUpDown6.Location = new System.Drawing.Point(675, 117);
			this.numericUpDown6.Name = "numericUpDown6";
			this.numericUpDown6.Size = new System.Drawing.Size(61, 22);
			this.numericUpDown6.TabIndex = 18;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(684, 98);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(34, 16);
			this.label10.TabIndex = 17;
			this.label10.Text = "YSP";
			// 
			// numericUpDown7
			// 
			this.numericUpDown7.Location = new System.Drawing.Point(810, 117);
			this.numericUpDown7.Name = "numericUpDown7";
			this.numericUpDown7.Size = new System.Drawing.Size(61, 22);
			this.numericUpDown7.TabIndex = 20;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(819, 98);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(40, 16);
			this.label11.TabIndex = 19;
			this.label11.Text = "Diğer";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(913, 119);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(0, 16);
			this.label12.TabIndex = 21;
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 16;
			this.listBox1.Location = new System.Drawing.Point(1175, 85);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(120, 84);
			this.listBox1.TabIndex = 22;
			this.listBox1.Visible = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1324, 616);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.numericUpDown7);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.numericUpDown6);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.numericUpDown5);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.numericUpDown4);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.numericUpDown3);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.numericUpDown2);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDown7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox listBox1;
    }
}

