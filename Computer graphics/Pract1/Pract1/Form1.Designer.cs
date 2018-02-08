namespace Pract1
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.clearPolygon = new System.Windows.Forms.Button();
            this.drawButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.pointRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(662, 359);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBoxMouseDown);
            // 
            // clearPolygon
            // 
            this.clearPolygon.Location = new System.Drawing.Point(308, 403);
            this.clearPolygon.Name = "clearPolygon";
            this.clearPolygon.Size = new System.Drawing.Size(113, 32);
            this.clearPolygon.TabIndex = 1;
            this.clearPolygon.Text = "Clear Field";
            this.clearPolygon.UseVisualStyleBackColor = true;
            this.clearPolygon.Click += new System.EventHandler(this.ClearPolygonClick);
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(308, 439);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(113, 32);
            this.drawButton.TabIndex = 2;
            this.drawButton.Text = "Draw";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.DrawPolygonButtonClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.pointRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(42, 394);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "controls";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(18, 56);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(113, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "draw polygon";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // pointRadioButton
            // 
            this.pointRadioButton.AutoSize = true;
            this.pointRadioButton.Location = new System.Drawing.Point(18, 29);
            this.pointRadioButton.Name = "pointRadioButton";
            this.pointRadioButton.Size = new System.Drawing.Size(83, 21);
            this.pointRadioButton.TabIndex = 0;
            this.pointRadioButton.TabStop = true;
            this.pointRadioButton.Text = "set point";
            this.pointRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(484, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "State: ";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(539, 403);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(46, 17);
            this.stateLabel.TabIndex = 5;
            this.stateLabel.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 537);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.clearPolygon);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button clearPolygon;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton pointRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label stateLabel;
    }
}

