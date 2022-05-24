namespace labSQLite
{
    partial class FmNotesAdd
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
            this.edNotesCaption = new System.Windows.Forms.TextBox();
            this.edNotesPriority = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.edNotesPriority)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caption";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Priority";
            // 
            // edNotesCaption
            // 
            this.edNotesCaption.Location = new System.Drawing.Point(55, 13);
            this.edNotesCaption.Multiline = true;
            this.edNotesCaption.Name = "edNotesCaption";
            this.edNotesCaption.Size = new System.Drawing.Size(285, 89);
            this.edNotesCaption.TabIndex = 2;
            // 
            // edNotesPriority
            // 
            this.edNotesPriority.Location = new System.Drawing.Point(57, 126);
            this.edNotesPriority.Name = "edNotesPriority";
            this.edNotesPriority.Size = new System.Drawing.Size(77, 20);
            this.edNotesPriority.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ок";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FmNotesAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 218);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.edNotesPriority);
            this.Controls.Add(this.edNotesCaption);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FmNotesAdd";
            this.Text = "Добавить заметки";
            ((System.ComponentModel.ISupportInitialize)(this.edNotesPriority)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox edNotesCaption;
        public System.Windows.Forms.NumericUpDown edNotesPriority;
    }
}