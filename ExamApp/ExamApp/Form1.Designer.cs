namespace ExamApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lvFolders = new System.Windows.Forms.ListView();
            this.tsm = new System.Windows.Forms.ToolStrip();
            this.tbDir = new System.Windows.Forms.ToolStripTextBox();
            this.buBack = new System.Windows.Forms.ToolStripButton();
            this.buForward = new System.Windows.Forms.ToolStripButton();
            this.buDirSelect = new System.Windows.Forms.ToolStripButton();
            this.lvBrowser = new System.Windows.Forms.ListView();
            this.lvDrive = new System.Windows.Forms.ListView();
            this.contextMenuMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.tsm.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvFolders
            // 
            this.lvFolders.HideSelection = false;
            this.lvFolders.Location = new System.Drawing.Point(219, 28);
            this.lvFolders.Name = "lvFolders";
            this.lvFolders.Size = new System.Drawing.Size(581, 422);
            this.lvFolders.TabIndex = 0;
            this.lvFolders.UseCompatibleStateImageBehavior = false;
            // 
            // tsm
            // 
            this.tsm.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tsm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbDir,
            this.buBack,
            this.buForward,
            this.buDirSelect});
            this.tsm.Location = new System.Drawing.Point(0, 0);
            this.tsm.Name = "tsm";
            this.tsm.Size = new System.Drawing.Size(800, 25);
            this.tsm.TabIndex = 1;
            this.tsm.Text = "toolStrip1";
            // 
            // tbDir
            // 
            this.tbDir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbDir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbDir.Name = "tbDir";
            this.tbDir.Size = new System.Drawing.Size(100, 25);
            // 
            // buBack
            // 
            this.buBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buBack.Image = ((System.Drawing.Image)(resources.GetObject("buBack.Image")));
            this.buBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buBack.Name = "buBack";
            this.buBack.Size = new System.Drawing.Size(23, 22);
            this.buBack.Text = "◀";
            // 
            // buForward
            // 
            this.buForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buForward.Image = ((System.Drawing.Image)(resources.GetObject("buForward.Image")));
            this.buForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buForward.Name = "buForward";
            this.buForward.Size = new System.Drawing.Size(23, 22);
            this.buForward.Text = "▶";
            // 
            // buDirSelect
            // 
            this.buDirSelect.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buDirSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buDirSelect.Image = ((System.Drawing.Image)(resources.GetObject("buDirSelect.Image")));
            this.buDirSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buDirSelect.Name = "buDirSelect";
            this.buDirSelect.Size = new System.Drawing.Size(23, 22);
            this.buDirSelect.Text = "⬆";
            // 
            // lvBrowser
            // 
            this.lvBrowser.HideSelection = false;
            this.lvBrowser.Location = new System.Drawing.Point(0, 28);
            this.lvBrowser.Name = "lvBrowser";
            this.lvBrowser.Size = new System.Drawing.Size(213, 245);
            this.lvBrowser.TabIndex = 2;
            this.lvBrowser.UseCompatibleStateImageBehavior = false;
            // 
            // lvDrive
            // 
            this.lvDrive.HideSelection = false;
            this.lvDrive.Location = new System.Drawing.Point(0, 279);
            this.lvDrive.Name = "lvDrive";
            this.lvDrive.Size = new System.Drawing.Size(213, 171);
            this.lvDrive.TabIndex = 3;
            this.lvDrive.UseCompatibleStateImageBehavior = false;
            // 
            // contextMenuMain
            // 
            this.contextMenuMain.Name = "contextMenuMain";
            this.contextMenuMain.Size = new System.Drawing.Size(61, 4);
            // 
            // tbInfo
            // 
            this.tbInfo.Location = new System.Drawing.Point(294, 76);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Size = new System.Drawing.Size(237, 264);
            this.tbInfo.TabIndex = 4;
            this.tbInfo.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.lvDrive);
            this.Controls.Add(this.lvBrowser);
            this.Controls.Add(this.tsm);
            this.Controls.Add(this.lvFolders);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tsm.ResumeLayout(false);
            this.tsm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvFolders;
        private System.Windows.Forms.ToolStrip tsm;
        private System.Windows.Forms.ToolStripTextBox tbDir;
        private System.Windows.Forms.ListView lvBrowser;
        private System.Windows.Forms.ListView lvDrive;
        private System.Windows.Forms.ToolStripButton buBack;
        private System.Windows.Forms.ToolStripButton buForward;
        private System.Windows.Forms.ContextMenuStrip contextMenuMain;
        private System.Windows.Forms.ToolStripButton buDirSelect;
        private System.Windows.Forms.TextBox tbInfo;
    }
}

