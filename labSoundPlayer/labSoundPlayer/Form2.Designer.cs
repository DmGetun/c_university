namespace labSoundPlayer
{
    partial class Form2
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
            this.buPlay = new System.Windows.Forms.Button();
            this.buStop = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.buPlay.Location = new System.Drawing.Point(65, 54);
            this.buPlay.Name = "button1";
            this.buPlay.Size = new System.Drawing.Size(75, 23);
            this.buPlay.TabIndex = 0;
            this.buPlay.Text = "Play";
            this.buPlay.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.buStop.Location = new System.Drawing.Point(274, 54);
            this.buStop.Name = "button2";
            this.buStop.Size = new System.Drawing.Size(75, 23);
            this.buStop.TabIndex = 1;
            this.buStop.Text = "Stop";
            this.buStop.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(168, 54);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Looping";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(65, 117);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Beep";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buStop);
            this.Controls.Add(this.buPlay);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buPlay;
        private System.Windows.Forms.Button buStop;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}