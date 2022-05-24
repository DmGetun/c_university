namespace labBrowser
{
    partial class fm
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
            this.buGo = new System.Windows.Forms.Button();
            this.edURL = new System.Windows.Forms.TextBox();
            this.wb = new System.Windows.Forms.WebBrowser();
            this.buBack = new System.Windows.Forms.Button();
            this.buForward = new System.Windows.Forms.Button();
            this.buReload = new System.Windows.Forms.Button();
            this.buStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buGo
            // 
            this.buGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buGo.Location = new System.Drawing.Point(444, 0);
            this.buGo.Name = "buGo";
            this.buGo.Size = new System.Drawing.Size(75, 23);
            this.buGo.TabIndex = 1;
            this.buGo.Text = "Go";
            this.buGo.UseVisualStyleBackColor = true;
            // 
            // edURL
            // 
            this.edURL.Location = new System.Drawing.Point(142, 3);
            this.edURL.Name = "edURL";
            this.edURL.Size = new System.Drawing.Size(296, 20);
            this.edURL.TabIndex = 2;
            this.edURL.Text = "https://ya.ru/";
            // 
            // wb
            // 
            this.wb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wb.Location = new System.Drawing.Point(-6, 29);
            this.wb.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb.Name = "wb";
            this.wb.Size = new System.Drawing.Size(644, 280);
            this.wb.TabIndex = 3;
            // 
            // buBack
            // 
            this.buBack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buBack.Location = new System.Drawing.Point(57, 315);
            this.buBack.Name = "buBack";
            this.buBack.Size = new System.Drawing.Size(75, 23);
            this.buBack.TabIndex = 4;
            this.buBack.Text = "<< Back";
            this.buBack.UseVisualStyleBackColor = true;
            // 
            // buForward
            // 
            this.buForward.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buForward.Location = new System.Drawing.Point(182, 314);
            this.buForward.Name = "buForward";
            this.buForward.Size = new System.Drawing.Size(75, 23);
            this.buForward.TabIndex = 5;
            this.buForward.Text = "Forward >>";
            this.buForward.UseVisualStyleBackColor = true;
            // 
            // buReload
            // 
            this.buReload.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buReload.Location = new System.Drawing.Point(341, 315);
            this.buReload.Name = "buReload";
            this.buReload.Size = new System.Drawing.Size(75, 23);
            this.buReload.TabIndex = 6;
            this.buReload.Text = "Reload";
            this.buReload.UseVisualStyleBackColor = true;
            // 
            // buStop
            // 
            this.buStop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buStop.Location = new System.Drawing.Point(443, 316);
            this.buStop.Name = "buStop";
            this.buStop.Size = new System.Drawing.Size(75, 23);
            this.buStop.TabIndex = 7;
            this.buStop.Text = "Stop";
            this.buStop.UseVisualStyleBackColor = true;
            // 
            // fm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buStop);
            this.Controls.Add(this.buReload);
            this.Controls.Add(this.buForward);
            this.Controls.Add(this.buBack);
            this.Controls.Add(this.wb);
            this.Controls.Add(this.edURL);
            this.Controls.Add(this.buGo);
            this.Name = "fm";
            this.Text = "labWebBrowser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buGo;
        private System.Windows.Forms.TextBox edURL;
        private System.Windows.Forms.WebBrowser wb;
        private System.Windows.Forms.Button buBack;
        private System.Windows.Forms.Button buForward;
        private System.Windows.Forms.Button buReload;
        private System.Windows.Forms.Button buStop;
    }
}

