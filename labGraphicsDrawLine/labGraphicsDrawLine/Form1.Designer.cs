namespace labGraphicsDrawLine
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buClear = new System.Windows.Forms.Button();
            this.trPenWidth = new System.Windows.Forms.TrackBar();
            this.pxColor4 = new System.Windows.Forms.PictureBox();
            this.pxColor3 = new System.Windows.Forms.PictureBox();
            this.pxColor2 = new System.Windows.Forms.PictureBox();
            this.pxColor1 = new System.Windows.Forms.PictureBox();
            this.pxImage = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trPenWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxColor4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxColor3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxColor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxColor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buClear);
            this.panel1.Controls.Add(this.trPenWidth);
            this.panel1.Controls.Add(this.pxColor4);
            this.panel1.Controls.Add(this.pxColor3);
            this.panel1.Controls.Add(this.pxColor2);
            this.panel1.Controls.Add(this.pxColor1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.buClear.Location = new System.Drawing.Point(3, 150);
            this.buClear.Name = "button1";
            this.buClear.Size = new System.Drawing.Size(194, 23);
            this.buClear.TabIndex = 5;
            this.buClear.Text = "Clear";
            this.buClear.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trPenWidth.Location = new System.Drawing.Point(12, 85);
            this.trPenWidth.Minimum = 1;
            this.trPenWidth.Name = "trackBar1";
            this.trPenWidth.Size = new System.Drawing.Size(182, 45);
            this.trPenWidth.TabIndex = 4;
            this.trPenWidth.Value = 1;
            // 
            // pxColor4
            // 
            this.pxColor4.BackColor = System.Drawing.Color.Blue;
            this.pxColor4.Location = new System.Drawing.Point(146, 12);
            this.pxColor4.Name = "pxColor4";
            this.pxColor4.Size = new System.Drawing.Size(48, 43);
            this.pxColor4.TabIndex = 3;
            this.pxColor4.TabStop = false;
            // 
            // pxColor3
            // 
            this.pxColor3.BackColor = System.Drawing.Color.Red;
            this.pxColor3.Location = new System.Drawing.Point(102, 12);
            this.pxColor3.Name = "pxColor3";
            this.pxColor3.Size = new System.Drawing.Size(38, 43);
            this.pxColor3.TabIndex = 2;
            this.pxColor3.TabStop = false;
            // 
            // pxColor2
            // 
            this.pxColor2.BackColor = System.Drawing.Color.Yellow;
            this.pxColor2.Location = new System.Drawing.Point(54, 12);
            this.pxColor2.Name = "pxColor2";
            this.pxColor2.Size = new System.Drawing.Size(42, 43);
            this.pxColor2.TabIndex = 1;
            this.pxColor2.TabStop = false;
            // 
            // pxColor1
            // 
            this.pxColor1.BackColor = System.Drawing.Color.Lime;
            this.pxColor1.Location = new System.Drawing.Point(3, 12);
            this.pxColor1.Name = "pxColor1";
            this.pxColor1.Size = new System.Drawing.Size(45, 43);
            this.pxColor1.TabIndex = 0;
            this.pxColor1.TabStop = false;
            // 
            // pxImage
            // 
            this.pxImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pxImage.Location = new System.Drawing.Point(200, 0);
            this.pxImage.Name = "pxImage";
            this.pxImage.Size = new System.Drawing.Size(600, 450);
            this.pxImage.TabIndex = 1;
            this.pxImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pxImage);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "labGraphicsDrawLine";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trPenWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxColor4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxColor3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxColor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxColor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buClear;
        private System.Windows.Forms.TrackBar trPenWidth;
        private System.Windows.Forms.PictureBox pxColor4;
        private System.Windows.Forms.PictureBox pxColor3;
        private System.Windows.Forms.PictureBox pxColor2;
        private System.Windows.Forms.PictureBox pxColor1;
        private System.Windows.Forms.PictureBox pxImage;
    }
}

