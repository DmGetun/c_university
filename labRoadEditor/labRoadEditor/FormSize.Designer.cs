namespace labRoadEditor
{
    partial class FormSize
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
            this.TBWidth = new System.Windows.Forms.TextBox();
            this.TBHeight = new System.Windows.Forms.TextBox();
            this.buOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Высота";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ширина";
            // 
            // TBWidth
            // 
            this.TBWidth.Location = new System.Drawing.Point(64, 13);
            this.TBWidth.Name = "TBWidth";
            this.TBWidth.Size = new System.Drawing.Size(100, 20);
            this.TBWidth.TabIndex = 2;
            // 
            // TBHeight
            // 
            this.TBHeight.Location = new System.Drawing.Point(64, 39);
            this.TBHeight.Name = "TBHeight";
            this.TBHeight.Size = new System.Drawing.Size(100, 20);
            this.TBHeight.TabIndex = 3;
            // 
            // buOk
            // 
            this.buOk.Location = new System.Drawing.Point(46, 65);
            this.buOk.Name = "buOk";
            this.buOk.Size = new System.Drawing.Size(75, 23);
            this.buOk.TabIndex = 4;
            this.buOk.Text = "Ok";
            this.buOk.UseVisualStyleBackColor = true;
            // 
            // FormSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 97);
            this.Controls.Add(this.buOk);
            this.Controls.Add(this.TBHeight);
            this.Controls.Add(this.TBWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSize";
            this.Text = "FormSize";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBWidth;
        private System.Windows.Forms.TextBox TBHeight;
        private System.Windows.Forms.Button buOk;
    }
}