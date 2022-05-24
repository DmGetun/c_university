namespace labParallel
{
    partial class Fm
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
            this.edDirTemp = new System.Windows.Forms.TextBox();
            this.buCreateFiles = new System.Windows.Forms.Button();
            this.buDeleteFiles = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.edDirTemp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edDirTemp.Location = new System.Drawing.Point(13, 13);
            this.edDirTemp.Name = "textBox1";
            this.edDirTemp.Size = new System.Drawing.Size(578, 20);
            this.edDirTemp.TabIndex = 0;
            // 
            // button1
            // 
            this.buCreateFiles.Location = new System.Drawing.Point(13, 39);
            this.buCreateFiles.Name = "button1";
            this.buCreateFiles.Size = new System.Drawing.Size(247, 23);
            this.buCreateFiles.TabIndex = 1;
            this.buCreateFiles.Text = "Создать n файлов";
            this.buCreateFiles.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.buDeleteFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buDeleteFiles.Location = new System.Drawing.Point(266, 39);
            this.buDeleteFiles.Name = "button2";
            this.buDeleteFiles.Size = new System.Drawing.Size(188, 23);
            this.buDeleteFiles.TabIndex = 2;
            this.buDeleteFiles.Text = "Удалить n файлов";
            this.buDeleteFiles.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(460, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 79);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(578, 331);
            this.textBox2.TabIndex = 4;
            // 
            // Fm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 422);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buDeleteFiles);
            this.Controls.Add(this.buCreateFiles);
            this.Controls.Add(this.edDirTemp);
            this.Name = "Fm";
            this.Text = "labParallel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edDirTemp;
        private System.Windows.Forms.Button buCreateFiles;
        private System.Windows.Forms.Button buDeleteFiles;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
    }
}

