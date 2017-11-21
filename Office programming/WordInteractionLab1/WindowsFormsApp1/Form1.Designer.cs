namespace WindowsFormsApp1
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
            this.createDocumentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // runWordBtn
            // 
            this.runWordBtn.Location = new System.Drawing.Point(77, 200);
            this.runWordBtn.Name = "runWordBtn";
            this.runWordBtn.Size = new System.Drawing.Size(148, 49);
            this.runWordBtn.TabIndex = 0;
            this.runWordBtn.Text = "Запустить Word";
            this.runWordBtn.UseVisualStyleBackColor = true;
            this.runWordBtn.Click += new System.EventHandler(this.runWordBtn_Click);
            // 
            // createDocumentButton
            // 
            this.createDocumentButton.Location = new System.Drawing.Point(77, 108);
            this.createDocumentButton.Name = "createDocumentButton";
            this.createDocumentButton.Size = new System.Drawing.Size(148, 50);
            this.createDocumentButton.TabIndex = 1;
            this.createDocumentButton.Text = "Создать документ Word";
            this.createDocumentButton.UseVisualStyleBackColor = true;
            this.createDocumentButton.Click += new System.EventHandler(this.createDocumentButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.createDocumentButton);
            this.Controls.Add(this.runWordBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button runWordBtn;
        private System.Windows.Forms.Button createDocumentButton;
    }
}

