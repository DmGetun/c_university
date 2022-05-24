namespace labImageSelectInGrid
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.trCols = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trRows = new System.Windows.Forms.TrackBar();
            this.pxImage = new System.Windows.Forms.PictureBox();
            this.pxImage2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trCols)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxImage2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.trCols);
            this.groupBox2.Location = new System.Drawing.Point(3, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cols";
            // 
            // trCols
            // 
            this.trCols.Location = new System.Drawing.Point(23, 35);
            this.trCols.Name = "trCols";
            this.trCols.Size = new System.Drawing.Size(104, 45);
            this.trCols.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trRows);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 73);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rows";
            // 
            // trRows
            // 
            this.trRows.Location = new System.Drawing.Point(41, 19);
            this.trRows.Name = "trRows";
            this.trRows.Size = new System.Drawing.Size(104, 45);
            this.trRows.TabIndex = 0;
            // 
            // pxImage
            // 
            this.pxImage.Location = new System.Drawing.Point(-23, -46);
            this.pxImage.Name = "pxImage";
            this.pxImage.Size = new System.Drawing.Size(100, 50);
            this.pxImage.TabIndex = 1;
            this.pxImage.TabStop = false;
            // 
            // pxImage2
            // 
            this.pxImage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pxImage2.Location = new System.Drawing.Point(200, 0);
            this.pxImage2.Name = "pxImage2";
            this.pxImage2.Size = new System.Drawing.Size(600, 450);
            this.pxImage2.TabIndex = 2;
            this.pxImage2.TabStop = false;
            // 
            // Fm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pxImage2);
            this.Controls.Add(this.pxImage);
            this.Controls.Add(this.panel1);
            this.Name = "Fm";
            this.Text = "labImageSelectInGrid";
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trCols)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxImage2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar trCols;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar trRows;
        private System.Windows.Forms.PictureBox pxImage;
        private System.Windows.Forms.PictureBox pxImage2;
    }
}

