namespace labSearchCity
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
            this.edSearch = new System.Windows.Forms.TextBox();
            this.laCount = new System.Windows.Forms.Label();
            this.edRezult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.edSearch.Location = new System.Drawing.Point(12, 33);
            this.edSearch.Name = "textBox1";
            this.edSearch.Size = new System.Drawing.Size(405, 20);
            this.edSearch.TabIndex = 0;
            // 
            // label1
            // 
            this.laCount.AutoSize = true;
            this.laCount.Location = new System.Drawing.Point(13, 75);
            this.laCount.Name = "label1";
            this.laCount.Size = new System.Drawing.Size(35, 13);
            this.laCount.TabIndex = 1;
            this.laCount.Text = "label1";
            // 
            // textBox2
            // 
            this.edRezult.Location = new System.Drawing.Point(16, 108);
            this.edRezult.Multiline = true;
            this.edRezult.Name = "textBox2";
            this.edRezult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.edRezult.Size = new System.Drawing.Size(401, 216);
            this.edRezult.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.edRezult);
            this.Controls.Add(this.laCount);
            this.Controls.Add(this.edSearch);
            this.Name = "Form1";
            this.Text = "labSearchCity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edSearch;
        private System.Windows.Forms.Label laCount;
        private System.Windows.Forms.TextBox edRezult;
    }
}

