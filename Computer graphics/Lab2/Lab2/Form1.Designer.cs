namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ax1TextBox = new System.Windows.Forms.TextBox();
            this.ax2TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ay1TextBox = new System.Windows.Forms.TextBox();
            this.ay2TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkButton = new System.Windows.Forms.Button();
            this.isIntersectLabel = new System.Windows.Forms.Label();
            this.bx1TextBox = new System.Windows.Forms.TextBox();
            this.bx2TextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.by2TextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.by1TextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SegmentRadioButton = new System.Windows.Forms.RadioButton();
            this.RaysRadioButton = new System.Windows.Forms.RadioButton();
            this.LinesRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ax1TextBox
            // 
            this.ax1TextBox.Location = new System.Drawing.Point(122, 425);
            this.ax1TextBox.Name = "ax1TextBox";
            this.ax1TextBox.Size = new System.Drawing.Size(100, 22);
            this.ax1TextBox.TabIndex = 2;
            this.ax1TextBox.Text = "1";
            // 
            // ax2TextBox
            // 
            this.ax2TextBox.Location = new System.Drawing.Point(122, 456);
            this.ax2TextBox.Name = "ax2TextBox";
            this.ax2TextBox.Size = new System.Drawing.Size(100, 22);
            this.ax2TextBox.TabIndex = 3;
            this.ax2TextBox.Text = "7";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 442);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 530);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "x1 = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "y1 = ";
            // 
            // ay1TextBox
            // 
            this.ay1TextBox.Location = new System.Drawing.Point(267, 425);
            this.ay1TextBox.Name = "ay1TextBox";
            this.ay1TextBox.Size = new System.Drawing.Size(100, 22);
            this.ay1TextBox.TabIndex = 8;
            this.ay1TextBox.Text = "1";
            // 
            // ay2TextBox
            // 
            this.ay2TextBox.Location = new System.Drawing.Point(267, 453);
            this.ay2TextBox.Name = "ay2TextBox";
            this.ay2TextBox.Size = new System.Drawing.Size(100, 22);
            this.ay2TextBox.TabIndex = 9;
            this.ay2TextBox.Text = "7";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 456);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "x2= ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 456);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "y2= ";
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(650, 489);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(100, 27);
            this.checkButton.TabIndex = 3;
            this.checkButton.Text = "Начертить";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.CheckButtonClick);
            // 
            // isIntersectLabel
            // 
            this.isIntersectLabel.AutoSize = true;
            this.isIntersectLabel.Location = new System.Drawing.Point(478, 363);
            this.isIntersectLabel.Name = "isIntersectLabel";
            this.isIntersectLabel.Size = new System.Drawing.Size(0, 17);
            this.isIntersectLabel.TabIndex = 20;
            // 
            // bx1TextBox
            // 
            this.bx1TextBox.Location = new System.Drawing.Point(122, 514);
            this.bx1TextBox.Name = "bx1TextBox";
            this.bx1TextBox.Size = new System.Drawing.Size(100, 22);
            this.bx1TextBox.TabIndex = 12;
            this.bx1TextBox.Text = "2";
            // 
            // bx2TextBox
            // 
            this.bx2TextBox.Location = new System.Drawing.Point(122, 542);
            this.bx2TextBox.Name = "bx2TextBox";
            this.bx2TextBox.Size = new System.Drawing.Size(100, 22);
            this.bx2TextBox.TabIndex = 13;
            this.bx2TextBox.Text = "10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(231, 545);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "y2= ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 542);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "x2= ";
            // 
            // by2TextBox
            // 
            this.by2TextBox.Location = new System.Drawing.Point(267, 542);
            this.by2TextBox.Name = "by2TextBox";
            this.by2TextBox.Size = new System.Drawing.Size(100, 22);
            this.by2TextBox.TabIndex = 17;
            this.by2TextBox.Text = "2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(86, 514);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "x1 = ";
            // 
            // by1TextBox
            // 
            this.by1TextBox.Location = new System.Drawing.Point(267, 514);
            this.by1TextBox.Name = "by1TextBox";
            this.by1TextBox.Size = new System.Drawing.Size(100, 22);
            this.by1TextBox.TabIndex = 16;
            this.by1TextBox.Text = "10";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(231, 517);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "y1 = ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SegmentRadioButton);
            this.groupBox1.Controls.Add(this.RaysRadioButton);
            this.groupBox1.Controls.Add(this.LinesRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(400, 443);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 107);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // SegmentRadioButton
            // 
            this.SegmentRadioButton.AutoSize = true;
            this.SegmentRadioButton.Location = new System.Drawing.Point(11, 73);
            this.SegmentRadioButton.Name = "SegmentRadioButton";
            this.SegmentRadioButton.Size = new System.Drawing.Size(94, 21);
            this.SegmentRadioButton.TabIndex = 2;
            this.SegmentRadioButton.TabStop = true;
            this.SegmentRadioButton.Text = "2 отрезка";
            this.SegmentRadioButton.UseVisualStyleBackColor = true;
            // 
            // RaysRadioButton
            // 
            this.RaysRadioButton.AutoSize = true;
            this.RaysRadioButton.Location = new System.Drawing.Point(11, 46);
            this.RaysRadioButton.Name = "RaysRadioButton";
            this.RaysRadioButton.Size = new System.Drawing.Size(72, 21);
            this.RaysRadioButton.TabIndex = 1;
            this.RaysRadioButton.TabStop = true;
            this.RaysRadioButton.Text = "2 луча";
            this.RaysRadioButton.UseVisualStyleBackColor = true;
            // 
            // LinesRadioButton
            // 
            this.LinesRadioButton.AutoSize = true;
            this.LinesRadioButton.Checked = true;
            this.LinesRadioButton.Location = new System.Drawing.Point(11, 21);
            this.LinesRadioButton.Name = "LinesRadioButton";
            this.LinesRadioButton.Size = new System.Drawing.Size(92, 21);
            this.LinesRadioButton.TabIndex = 0;
            this.LinesRadioButton.TabStop = true;
            this.LinesRadioButton.Text = "2 прямые";
            this.LinesRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 591);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.isIntersectLabel);
            this.Controls.Add(this.bx1TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bx2TextBox);
            this.Controls.Add(this.ay1TextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ay2TextBox);
            this.Controls.Add(this.by2TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.by1TextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ax2TextBox);
            this.Controls.Add(this.ax1TextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ax1TextBox;
        private System.Windows.Forms.TextBox ax2TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ay1TextBox;
        private System.Windows.Forms.TextBox ay2TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.TextBox bx1TextBox;
        private System.Windows.Forms.TextBox bx2TextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox by2TextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox by1TextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label isIntersectLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton SegmentRadioButton;
        private System.Windows.Forms.RadioButton RaysRadioButton;
        private System.Windows.Forms.RadioButton LinesRadioButton;
    }
}

