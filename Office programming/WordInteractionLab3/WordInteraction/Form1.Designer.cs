namespace WordInteraction
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
            this.runWordBtn = new System.Windows.Forms.Button();
            this.wordVisibleCheckBox = new System.Windows.Forms.CheckBox();
            this.wordStateLabel = new System.Windows.Forms.Label();
            this.wordWorkPanel = new System.Windows.Forms.Panel();
            this.EditDocBtn = new System.Windows.Forms.Button();
            this.DeleteDocBtn = new System.Windows.Forms.Button();
            this.openBtn = new System.Windows.Forms.Button();
            this.openedDocslistBox = new System.Windows.Forms.ListBox();
            this.createDocBtn = new System.Windows.Forms.Button();
            this.closeWordBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.wordWorkPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // runWordBtn
            // 
            this.runWordBtn.Location = new System.Drawing.Point(694, 38);
            this.runWordBtn.Name = "runWordBtn";
            this.runWordBtn.Size = new System.Drawing.Size(75, 23);
            this.runWordBtn.TabIndex = 0;
            this.runWordBtn.Text = "Run Word";
            this.runWordBtn.UseVisualStyleBackColor = true;
            this.runWordBtn.Click += new System.EventHandler(this.runWordBtn_Click);
            // 
            // wordVisibleCheckBox
            // 
            this.wordVisibleCheckBox.AutoSize = true;
            this.wordVisibleCheckBox.Location = new System.Drawing.Point(676, 103);
            this.wordVisibleCheckBox.Name = "wordVisibleCheckBox";
            this.wordVisibleCheckBox.Size = new System.Drawing.Size(120, 17);
            this.wordVisibleCheckBox.TabIndex = 1;
            this.wordVisibleCheckBox.Text = "word window visible";
            this.wordVisibleCheckBox.UseVisualStyleBackColor = true;
            this.wordVisibleCheckBox.CheckedChanged += new System.EventHandler(this.wordVisibleCheckBox_CheckedChanged);
            // 
            // wordStateLabel
            // 
            this.wordStateLabel.AutoSize = true;
            this.wordStateLabel.Location = new System.Drawing.Point(718, 78);
            this.wordStateLabel.Name = "wordStateLabel";
            this.wordStateLabel.Size = new System.Drawing.Size(35, 13);
            this.wordStateLabel.TabIndex = 2;
            this.wordStateLabel.Text = "label1";
            // 
            // wordWorkPanel
            // 
            this.wordWorkPanel.Controls.Add(this.textBox1);
            this.wordWorkPanel.Controls.Add(this.EditDocBtn);
            this.wordWorkPanel.Controls.Add(this.DeleteDocBtn);
            this.wordWorkPanel.Controls.Add(this.openBtn);
            this.wordWorkPanel.Controls.Add(this.openedDocslistBox);
            this.wordWorkPanel.Controls.Add(this.createDocBtn);
            this.wordWorkPanel.Location = new System.Drawing.Point(12, 12);
            this.wordWorkPanel.Name = "wordWorkPanel";
            this.wordWorkPanel.Size = new System.Drawing.Size(569, 295);
            this.wordWorkPanel.TabIndex = 3;
            // 
            // EditDocBtn
            // 
            this.EditDocBtn.Location = new System.Drawing.Point(88, 231);
            this.EditDocBtn.Name = "EditDocBtn";
            this.EditDocBtn.Size = new System.Drawing.Size(100, 23);
            this.EditDocBtn.TabIndex = 8;
            this.EditDocBtn.Text = "add";
            this.EditDocBtn.UseVisualStyleBackColor = true;
            this.EditDocBtn.Click += new System.EventHandler(this.EditDocBtn_Click);
            // 
            // DeleteDocBtn
            // 
            this.DeleteDocBtn.Location = new System.Drawing.Point(194, 18);
            this.DeleteDocBtn.Name = "DeleteDocBtn";
            this.DeleteDocBtn.Size = new System.Drawing.Size(82, 23);
            this.DeleteDocBtn.TabIndex = 7;
            this.DeleteDocBtn.Text = "Delete doc";
            this.DeleteDocBtn.UseVisualStyleBackColor = true;
            this.DeleteDocBtn.Click += new System.EventHandler(this.DeleteDocBtn_Click);
            // 
            // openBtn
            // 
            this.openBtn.Location = new System.Drawing.Point(106, 18);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(82, 23);
            this.openBtn.TabIndex = 6;
            this.openBtn.Text = "Open";
            this.openBtn.UseVisualStyleBackColor = true;
            // 
            // openedDocslistBox
            // 
            this.openedDocslistBox.FormattingEnabled = true;
            this.openedDocslistBox.Location = new System.Drawing.Point(421, 26);
            this.openedDocslistBox.Name = "openedDocslistBox";
            this.openedDocslistBox.Size = new System.Drawing.Size(120, 251);
            this.openedDocslistBox.TabIndex = 5;
            // 
            // createDocBtn
            // 
            this.createDocBtn.Location = new System.Drawing.Point(19, 18);
            this.createDocBtn.Name = "createDocBtn";
            this.createDocBtn.Size = new System.Drawing.Size(81, 23);
            this.createDocBtn.TabIndex = 4;
            this.createDocBtn.Text = "Create new doc";
            this.createDocBtn.UseVisualStyleBackColor = true;
            this.createDocBtn.Click += new System.EventHandler(this.createDocBtn_Click);
            // 
            // closeWordBtn
            // 
            this.closeWordBtn.Location = new System.Drawing.Point(694, 162);
            this.closeWordBtn.Name = "closeWordBtn";
            this.closeWordBtn.Size = new System.Drawing.Size(75, 23);
            this.closeWordBtn.TabIndex = 7;
            this.closeWordBtn.Text = "Close Word";
            this.closeWordBtn.UseVisualStyleBackColor = true;
            this.closeWordBtn.Click += new System.EventHandler(this.closeWordBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 114);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(257, 111);
            this.textBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 331);
            this.Controls.Add(this.closeWordBtn);
            this.Controls.Add(this.wordWorkPanel);
            this.Controls.Add(this.wordStateLabel);
            this.Controls.Add(this.wordVisibleCheckBox);
            this.Controls.Add(this.runWordBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.wordWorkPanel.ResumeLayout(false);
            this.wordWorkPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runWordBtn;
        private System.Windows.Forms.CheckBox wordVisibleCheckBox;
        private System.Windows.Forms.Label wordStateLabel;
        private System.Windows.Forms.Panel wordWorkPanel;
        private System.Windows.Forms.Button createDocBtn;
        private System.Windows.Forms.ListBox openedDocslistBox;
        private System.Windows.Forms.Button EditDocBtn;
        private System.Windows.Forms.Button DeleteDocBtn;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.Button closeWordBtn;
        private System.Windows.Forms.TextBox textBox1;
    }
}

