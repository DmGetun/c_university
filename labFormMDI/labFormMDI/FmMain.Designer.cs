namespace labFormMDI
{
    partial class FmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MIcreateNewForm = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MIWindowsCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.MIWindowsTileHor = new System.Windows.Forms.ToolStripMenuItem();
            this.MIWindowsTileVert = new System.Windows.Forms.ToolStripMenuItem();
            this.MIWindowsArrange = new System.Windows.Forms.ToolStripMenuItem();
            this.MICloseActiveForm = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllFormsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MIAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MIcreateNewForm,
            this.windowsToolStripMenuItem,
            this.MICloseActiveForm,
            this.closeAllFormsToolStripMenuItem,
            this.MIAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(760, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MIcreateNewForm
            // 
            this.MIcreateNewForm.Name = "MIcreateNewForm";
            this.MIcreateNewForm.Size = new System.Drawing.Size(105, 20);
            this.MIcreateNewForm.Text = "CreateNewForm";
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MIWindowsCascade,
            this.MIWindowsTileHor,
            this.MIWindowsTileVert,
            this.MIWindowsArrange});
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // MIWindowsCascade
            // 
            this.MIWindowsCascade.Name = "MIWindowsCascade";
            this.MIWindowsCascade.Size = new System.Drawing.Size(180, 22);
            this.MIWindowsCascade.Text = "Cascade";
            // 
            // MIWindowsTileHor
            // 
            this.MIWindowsTileHor.Name = "MIWindowsTileHor";
            this.MIWindowsTileHor.Size = new System.Drawing.Size(180, 22);
            this.MIWindowsTileHor.Text = "TileHorizontal";
            // 
            // MIWindowsTileVert
            // 
            this.MIWindowsTileVert.Name = "MIWindowsTileVert";
            this.MIWindowsTileVert.Size = new System.Drawing.Size(180, 22);
            this.MIWindowsTileVert.Text = "TileVertical";
            // 
            // MIWindowsArrange
            // 
            this.MIWindowsArrange.Name = "MIWindowsArrange";
            this.MIWindowsArrange.Size = new System.Drawing.Size(180, 22);
            this.MIWindowsArrange.Text = "ArrangeIcons";
            // 
            // closeActiveFormToolStripMenuItem
            // 
            this.MICloseActiveForm.Name = "closeActiveFormToolStripMenuItem";
            this.MICloseActiveForm.Size = new System.Drawing.Size(109, 20);
            this.MICloseActiveForm.Text = "CloseActiveForm";
            // 
            // closeAllFormsToolStripMenuItem
            // 
            this.closeAllFormsToolStripMenuItem.Name = "closeAllFormsToolStripMenuItem";
            this.closeAllFormsToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.closeAllFormsToolStripMenuItem.Text = "CloseAllForms";
            // 
            // aboutToolStripMenuItem
            // 
            this.MIAbout.Name = "aboutToolStripMenuItem";
            this.MIAbout.Size = new System.Drawing.Size(52, 20);
            this.MIAbout.Text = "About";
            // 
            // FmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 393);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FmMain";
            this.Text = "labFormMDI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MIcreateNewForm;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MIWindowsCascade;
        private System.Windows.Forms.ToolStripMenuItem MIWindowsTileHor;
        private System.Windows.Forms.ToolStripMenuItem MIWindowsTileVert;
        private System.Windows.Forms.ToolStripMenuItem MIWindowsArrange;
        private System.Windows.Forms.ToolStripMenuItem MICloseActiveForm;
        private System.Windows.Forms.ToolStripMenuItem closeAllFormsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MIAbout;
    }
}

