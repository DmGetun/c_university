namespace labSQLite
{
    partial class FmUsersAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nuAge = new System.Windows.Forms.NumericUpDown();
            this.edFIO = new System.Windows.Forms.TextBox();
            this.edMail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nuAge)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Полное имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Возраст";
            // 
            // nuAge
            // 
            this.nuAge.Location = new System.Drawing.Point(67, 132);
            this.nuAge.Name = "nuAge";
            this.nuAge.Size = new System.Drawing.Size(120, 20);
            this.nuAge.TabIndex = 3;
            // 
            // edFIO
            // 
            this.edFIO.Location = new System.Drawing.Point(88, 13);
            this.edFIO.Multiline = true;
            this.edFIO.Name = "edFIO";
            this.edFIO.Size = new System.Drawing.Size(220, 56);
            this.edFIO.TabIndex = 4;
            // 
            // edMail
            // 
            this.edMail.Location = new System.Drawing.Point(88, 87);
            this.edMail.Name = "edMail";
            this.edMail.Size = new System.Drawing.Size(220, 20);
            this.edMail.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ок";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FmUsersAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 226);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.edMail);
            this.Controls.Add(this.edFIO);
            this.Controls.Add(this.nuAge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FmUsersAdd";
            this.Text = "Добавить пользователя";
            ((System.ComponentModel.ISupportInitialize)(this.nuAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.NumericUpDown nuAge;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox edFIO;
        public System.Windows.Forms.TextBox edMail;
    }
}