namespace WordLab6
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
            this.nextButton = new System.Windows.Forms.Button();
            this.PrevButton = new System.Windows.Forms.Button();
            this.InDocButton = new System.Windows.Forms.Button();
            this.imgFromFileButton = new System.Windows.Forms.Button();
            this.ImFromBuffer = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.appendButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.descriptTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(360, 440);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(86, 33);
            this.nextButton.TabIndex = 0;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // PrevButton
            // 
            this.PrevButton.Location = new System.Drawing.Point(268, 440);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(86, 33);
            this.PrevButton.TabIndex = 1;
            this.PrevButton.Text = "Prev";
            this.PrevButton.UseVisualStyleBackColor = true;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // InDocButton
            // 
            this.InDocButton.Location = new System.Drawing.Point(268, 479);
            this.InDocButton.Name = "InDocButton";
            this.InDocButton.Size = new System.Drawing.Size(179, 35);
            this.InDocButton.TabIndex = 2;
            this.InDocButton.Text = "Into Document";
            this.InDocButton.UseVisualStyleBackColor = true;
            this.InDocButton.Click += new System.EventHandler(this.InDocButton_Click);
            // 
            // imgFromFileButton
            // 
            this.imgFromFileButton.Location = new System.Drawing.Point(42, 440);
            this.imgFromFileButton.Name = "imgFromFileButton";
            this.imgFromFileButton.Size = new System.Drawing.Size(138, 33);
            this.imgFromFileButton.TabIndex = 3;
            this.imgFromFileButton.Text = "Image from File";
            this.imgFromFileButton.UseVisualStyleBackColor = true;
            this.imgFromFileButton.Click += new System.EventHandler(this.imgFromFileButton_Click);
            // 
            // ImFromBuffer
            // 
            this.ImFromBuffer.Location = new System.Drawing.Point(42, 479);
            this.ImFromBuffer.Name = "ImFromBuffer";
            this.ImFromBuffer.Size = new System.Drawing.Size(138, 35);
            this.ImFromBuffer.TabIndex = 4;
            this.ImFromBuffer.Text = "Image from Buffer";
            this.ImFromBuffer.UseVisualStyleBackColor = true;
            this.ImFromBuffer.Click += new System.EventHandler(this.ImFromBuffer_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(536, 440);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 33);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // appendButton
            // 
            this.appendButton.Location = new System.Drawing.Point(617, 440);
            this.appendButton.Name = "appendButton";
            this.appendButton.Size = new System.Drawing.Size(75, 33);
            this.appendButton.TabIndex = 6;
            this.appendButton.Text = "Append";
            this.appendButton.UseVisualStyleBackColor = true;
            this.appendButton.Click += new System.EventHandler(this.appendButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(42, 252);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(650, 22);
            this.nameTextBox.TabIndex = 7;
            // 
            // descriptTextBox
            // 
            this.descriptTextBox.Location = new System.Drawing.Point(42, 309);
            this.descriptTextBox.Multiline = true;
            this.descriptTextBox.Name = "descriptTextBox";
            this.descriptTextBox.Size = new System.Drawing.Size(650, 100);
            this.descriptTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Description";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(42, 44);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(276, 178);
            this.pictureBox.TabIndex = 12;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 545);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descriptTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.appendButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ImFromBuffer);
            this.Controls.Add(this.imgFromFileButton);
            this.Controls.Add(this.InDocButton);
            this.Controls.Add(this.PrevButton);
            this.Controls.Add(this.nextButton);
            this.Name = "Form1";
            this.Text = "Word inter lab 6";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button PrevButton;
        private System.Windows.Forms.Button InDocButton;
        private System.Windows.Forms.Button imgFromFileButton;
        private System.Windows.Forms.Button ImFromBuffer;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button appendButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox descriptTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

