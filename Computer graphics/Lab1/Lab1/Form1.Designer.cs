﻿namespace Lab1
{
    partial class MainForm
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
            this.drawFraphicButton = new System.Windows.Forms.Button();
            this.aTextBox = new System.Windows.Forms.TextBox();
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.aLabel = new System.Windows.Forms.Label();
            this.bLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.xBeginTextBox = new System.Windows.Forms.TextBox();
            this.xEndTextBox = new System.Windows.Forms.TextBox();
            this.gridField = new Lab1.GridField();
            this.SuspendLayout();
            // 
            // drawFraphicButton
            // 
            this.drawFraphicButton.Location = new System.Drawing.Point(12, 484);
            this.drawFraphicButton.Name = "drawFraphicButton";
            this.drawFraphicButton.Size = new System.Drawing.Size(129, 29);
            this.drawFraphicButton.TabIndex = 1;
            this.drawFraphicButton.Text = "Draw Graphics";
            this.drawFraphicButton.UseVisualStyleBackColor = true;
            this.drawFraphicButton.Click += new System.EventHandler(this.DrawFraphicButtonClick);
            // 
            // aTextBox
            // 
            this.aTextBox.Location = new System.Drawing.Point(387, 474);
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(100, 22);
            this.aTextBox.TabIndex = 2;
            this.aTextBox.Text = "5";
            // 
            // bTextBox
            // 
            this.bTextBox.Location = new System.Drawing.Point(387, 502);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(100, 22);
            this.bTextBox.TabIndex = 3;
            this.bTextBox.Text = "6";
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Location = new System.Drawing.Point(349, 477);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(32, 17);
            this.aLabel.TabIndex = 4;
            this.aLabel.Text = "a = ";
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.Location = new System.Drawing.Point(349, 505);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(32, 17);
            this.bLabel.TabIndex = 5;
            this.bLabel.Text = "b = ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(699, 494);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(536, 494);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "t: from";
            // 
            // xBeginTextBox
            // 
            this.xBeginTextBox.Location = new System.Drawing.Point(592, 492);
            this.xBeginTextBox.Name = "xBeginTextBox";
            this.xBeginTextBox.Size = new System.Drawing.Size(100, 22);
            this.xBeginTextBox.TabIndex = 8;
            this.xBeginTextBox.Text = "-10";
            // 
            // xEndTextBox
            // 
            this.xEndTextBox.Location = new System.Drawing.Point(725, 491);
            this.xEndTextBox.Name = "xEndTextBox";
            this.xEndTextBox.Size = new System.Drawing.Size(100, 22);
            this.xEndTextBox.TabIndex = 9;
            this.xEndTextBox.Text = "10";
            // 
            // gridField
            // 
            this.gridField.Funct = null;
            this.gridField.Location = new System.Drawing.Point(8, 12);
            this.gridField.Name = "gridField";
            this.gridField.Size = new System.Drawing.Size(817, 436);
            this.gridField.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 551);
            this.Controls.Add(this.gridField);
            this.Controls.Add(this.xEndTextBox);
            this.Controls.Add(this.xBeginTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.aLabel);
            this.Controls.Add(this.bTextBox);
            this.Controls.Add(this.aTextBox);
            this.Controls.Add(this.drawFraphicButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button drawFraphicButton;
        private System.Windows.Forms.TextBox aTextBox;
        private System.Windows.Forms.TextBox bTextBox;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox xBeginTextBox;
        private System.Windows.Forms.TextBox xEndTextBox;
        private GridField gridField;
    }
}

