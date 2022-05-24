namespace labGenPassword
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
            this.edPassword = new System.Windows.Forms.TextBox();
            this.buPassword = new System.Windows.Forms.Button();
            this.ckLower = new System.Windows.Forms.CheckBox();
            this.ckUpp = new System.Windows.Forms.CheckBox();
            this.ckNumber = new System.Windows.Forms.CheckBox();
            this.ckSpec = new System.Windows.Forms.CheckBox();
            this.edLength = new System.Windows.Forms.NumericUpDown();
            this.laLenght = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.edLength)).BeginInit();
            this.SuspendLayout();
            // 
            // edPassword
            // 
            this.edPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edPassword.Location = new System.Drawing.Point(155, 12);
            this.edPassword.Name = "edPassword";
            this.edPassword.ReadOnly = true;
            this.edPassword.Size = new System.Drawing.Size(360, 68);
            this.edPassword.TabIndex = 0;
            this.edPassword.Text = "<Password>\r\n";
            // 
            // buPassword
            // 
            this.buPassword.Location = new System.Drawing.Point(155, 109);
            this.buPassword.Name = "buPassword";
            this.buPassword.Size = new System.Drawing.Size(360, 72);
            this.buPassword.TabIndex = 1;
            this.buPassword.Text = "Генерировать";
            this.buPassword.UseVisualStyleBackColor = true;
            // 
            // ckLower
            // 
            this.ckLower.AutoSize = true;
            this.ckLower.Location = new System.Drawing.Point(116, 208);
            this.ckLower.Name = "ckLower";
            this.ckLower.Size = new System.Drawing.Size(174, 17);
            this.ckLower.TabIndex = 2;
            this.ckLower.Text = "Символы в нижнем регистре";
            this.ckLower.UseVisualStyleBackColor = true;
            // 
            // ckUpp
            // 
            this.ckUpp.AutoSize = true;
            this.ckUpp.Location = new System.Drawing.Point(116, 242);
            this.ckUpp.Name = "ckUpp";
            this.ckUpp.Size = new System.Drawing.Size(177, 17);
            this.ckUpp.TabIndex = 3;
            this.ckUpp.Text = "Символы в верхнем регистре";
            this.ckUpp.UseVisualStyleBackColor = true;
            // 
            // ckNumber
            // 
            this.ckNumber.AutoSize = true;
            this.ckNumber.Location = new System.Drawing.Point(116, 277);
            this.ckNumber.Name = "ckNumber";
            this.ckNumber.Size = new System.Drawing.Size(62, 17);
            this.ckNumber.TabIndex = 4;
            this.ckNumber.Text = "Цифры";
            this.ckNumber.UseVisualStyleBackColor = true;
            // 
            // ckSpec
            // 
            this.ckSpec.AutoSize = true;
            this.ckSpec.Location = new System.Drawing.Point(116, 315);
            this.ckSpec.Name = "ckSpec";
            this.ckSpec.Size = new System.Drawing.Size(144, 17);
            this.ckSpec.TabIndex = 5;
            this.ckSpec.Text = "Специальные символы";
            this.ckSpec.UseVisualStyleBackColor = true;
            // 
            // edLength
            // 
            this.edLength.Location = new System.Drawing.Point(198, 355);
            this.edLength.Name = "edLength";
            this.edLength.Size = new System.Drawing.Size(120, 20);
            this.edLength.TabIndex = 6;
            this.edLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edLength.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // laLenght
            // 
            this.laLenght.AutoSize = true;
            this.laLenght.Location = new System.Drawing.Point(113, 357);
            this.laLenght.Name = "laLenght";
            this.laLenght.Size = new System.Drawing.Size(79, 13);
            this.laLenght.TabIndex = 7;
            this.laLenght.Text = "Длина пароля";
            // 
            // Fm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.laLenght);
            this.Controls.Add(this.edLength);
            this.Controls.Add(this.ckSpec);
            this.Controls.Add(this.ckNumber);
            this.Controls.Add(this.ckUpp);
            this.Controls.Add(this.ckLower);
            this.Controls.Add(this.buPassword);
            this.Controls.Add(this.edPassword);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "Fm";
            this.Text = "labGenPassword";
            this.TransparencyKey = System.Drawing.Color.White;
            ((System.ComponentModel.ISupportInitialize)(this.edLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edPassword;
        private System.Windows.Forms.Button buPassword;
        private System.Windows.Forms.CheckBox ckLower;
        private System.Windows.Forms.CheckBox ckUpp;
        private System.Windows.Forms.CheckBox ckNumber;
        private System.Windows.Forms.CheckBox ckSpec;
        private System.Windows.Forms.NumericUpDown edLength;
        private System.Windows.Forms.Label laLenght;
    }
}

