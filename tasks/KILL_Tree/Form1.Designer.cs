namespace KILL_Tree {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.lnr = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nrl = new System.Windows.Forms.ListBox();
            this.rnl = new System.Windows.Forms.ListBox();
            this.wide = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lnr
            // 
            this.lnr.FormattingEnabled = true;
            this.lnr.ItemHeight = 24;
            this.lnr.Location = new System.Drawing.Point(16, 112);
            this.lnr.Margin = new System.Windows.Forms.Padding(4);
            this.lnr.Name = "lnr";
            this.lnr.Size = new System.Drawing.Size(63, 556);
            this.lnr.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(736, 112);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(655, 112);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(49, 50);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(655, 195);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(49, 50);
            this.textBox2.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(736, 195);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 52);
            this.button2.TabIndex = 4;
            this.button2.Text = "contains";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(890, 195);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(554, 52);
            this.label1.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(655, 280);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(49, 50);
            this.textBox3.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(736, 280);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 52);
            this.button3.TabIndex = 7;
            this.button3.Text = "remove";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(890, 280);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(554, 52);
            this.label2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(890, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(554, 52);
            this.label3.TabIndex = 9;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(736, 366);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 52);
            this.button4.TabIndex = 10;
            this.button4.Text = "get count";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(890, 365);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(554, 52);
            this.label4.TabIndex = 11;
            // 
            // nrl
            // 
            this.nrl.FormattingEnabled = true;
            this.nrl.ItemHeight = 24;
            this.nrl.Location = new System.Drawing.Point(106, 112);
            this.nrl.Margin = new System.Windows.Forms.Padding(4);
            this.nrl.Name = "nrl";
            this.nrl.Size = new System.Drawing.Size(63, 556);
            this.nrl.TabIndex = 12;
            // 
            // rnl
            // 
            this.rnl.FormattingEnabled = true;
            this.rnl.ItemHeight = 24;
            this.rnl.Location = new System.Drawing.Point(199, 112);
            this.rnl.Margin = new System.Windows.Forms.Padding(4);
            this.rnl.Name = "rnl";
            this.rnl.Size = new System.Drawing.Size(64, 556);
            this.rnl.TabIndex = 13;
            // 
            // wide
            // 
            this.wide.FormattingEnabled = true;
            this.wide.ItemHeight = 24;
            this.wide.Location = new System.Drawing.Point(296, 112);
            this.wide.Margin = new System.Windows.Forms.Padding(4);
            this.wide.Name = "wide";
            this.wide.Size = new System.Drawing.Size(317, 556);
            this.wide.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(13, 77);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 31);
            this.label5.TabIndex = 15;
            this.label5.Text = "LNR";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(101, 77);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 31);
            this.label6.TabIndex = 16;
            this.label6.Text = "NRL";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(194, 77);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 31);
            this.label7.TabIndex = 17;
            this.label7.Text = "RNL";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(291, 77);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 31);
            this.label8.TabIndex = 18;
            this.label8.Text = "WIDE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 834);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.wide);
            this.Controls.Add(this.rnl);
            this.Controls.Add(this.nrl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lnr);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lnr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox nrl;
        private System.Windows.Forms.ListBox rnl;
        private System.Windows.Forms.ListBox wide;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

