namespace labFileExplorer
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
            this.tsMax = new System.Windows.Forms.ToolStrip();
            this.buBack = new System.Windows.Forms.ToolStripButton();
            this.buForward = new System.Windows.Forms.ToolStripButton();
            this.buUp = new System.Windows.Forms.ToolStripButton();
            this.edDir = new System.Windows.Forms.ToolStripTextBox();
            this.buDirSelect = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.miViewLargeIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.miViewSmallIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.miViewList = new System.Windows.Forms.ToolStripMenuItem();
            this.miViewDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.miViewTile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMin = new System.Windows.Forms.ToolStrip();
            this.tbSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.muDropSize = new System.Windows.Forms.ToolStripDropDownButton();
            this.muItemByte = new System.Windows.Forms.ToolStripMenuItem();
            this.muItemKbyte = new System.Windows.Forms.ToolStripMenuItem();
            this.muItemMbyte = new System.Windows.Forms.ToolStripMenuItem();
            this.muItemGbyte = new System.Windows.Forms.ToolStripMenuItem();
            this.muItemAuto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsFilterExt = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.TSSettings = new System.Windows.Forms.ToolStripDropDownButton();
            this.отображатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muBuDirView = new System.Windows.Forms.ToolStripMenuItem();
            this.muBuFileView = new System.Windows.Forms.ToolStripMenuItem();
            this.muBuAllView = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.скрытыеФайлыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSViewHiddenFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.lv = new System.Windows.Forms.ListView();
            this.contextMenuMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lvFavorite = new System.Windows.Forms.ListView();
            this.buViewFavorite = new System.Windows.Forms.ToolStripButton();
            this.contextMenuFavorite = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsMax.SuspendLayout();
            this.tsMin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMax
            // 
            this.tsMax.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tsMax.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buBack,
            this.buForward,
            this.buUp,
            this.edDir,
            this.buDirSelect,
            this.toolStripDropDownButton1,
            this.buViewFavorite});
            this.tsMax.Location = new System.Drawing.Point(0, 0);
            this.tsMax.Name = "tsMax";
            this.tsMax.Size = new System.Drawing.Size(800, 25);
            this.tsMax.TabIndex = 0;
            this.tsMax.Text = "tsMax";
            // 
            // buBack
            // 
            this.buBack.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buBack.ForeColor = System.Drawing.SystemColors.ControlText;
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
            // buUp
            // 
            this.buUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buUp.Image = ((System.Drawing.Image)(resources.GetObject("buUp.Image")));
            this.buUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buUp.Name = "buUp";
            this.buUp.Size = new System.Drawing.Size(23, 22);
            this.buUp.Text = "▲";
            // 
            // edDir
            // 
            this.edDir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.edDir.Name = "edDir";
            this.edDir.Size = new System.Drawing.Size(450, 25);
            // 
            // buDirSelect
            // 
            this.buDirSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buDirSelect.Image = ((System.Drawing.Image)(resources.GetObject("buDirSelect.Image")));
            this.buDirSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buDirSelect.Name = "buDirSelect";
            this.buDirSelect.Size = new System.Drawing.Size(23, 22);
            this.buDirSelect.Text = "...";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miViewLargeIcon,
            this.miViewSmallIcon,
            this.miViewList,
            this.miViewDetails,
            this.miViewTile});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(40, 22);
            this.toolStripDropDownButton1.Text = "Вид";
            // 
            // miViewLargeIcon
            // 
            this.miViewLargeIcon.Name = "miViewLargeIcon";
            this.miViewLargeIcon.Size = new System.Drawing.Size(131, 22);
            this.miViewLargeIcon.Text = "LargeIcons";
            // 
            // miViewSmallIcon
            // 
            this.miViewSmallIcon.Name = "miViewSmallIcon";
            this.miViewSmallIcon.Size = new System.Drawing.Size(131, 22);
            this.miViewSmallIcon.Text = "SmallIcons";
            // 
            // miViewList
            // 
            this.miViewList.Name = "miViewList";
            this.miViewList.Size = new System.Drawing.Size(131, 22);
            this.miViewList.Text = "List";
            // 
            // miViewDetails
            // 
            this.miViewDetails.Name = "miViewDetails";
            this.miViewDetails.Size = new System.Drawing.Size(131, 22);
            this.miViewDetails.Text = "Details";
            // 
            // miViewTile
            // 
            this.miViewTile.Name = "miViewTile";
            this.miViewTile.Size = new System.Drawing.Size(131, 22);
            this.miViewTile.Text = "Tile";
            // 
            // tsMin
            // 
            this.tsMin.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tsMin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbSearch,
            this.toolStripLabel1,
            this.muDropSize,
            this.tsFilterExt,
            this.toolStripLabel2,
            this.TSSettings});
            this.tsMin.Location = new System.Drawing.Point(0, 25);
            this.tsMin.Name = "tsMin";
            this.tsMin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsMin.Size = new System.Drawing.Size(800, 25);
            this.tsMin.TabIndex = 2;
            this.tsMin.Text = "tsMin";
            // 
            // tbSearch
            // 
            this.tbSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbSearch.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(42, 22);
            this.toolStripLabel1.Text = "Поиск";
            // 
            // muDropSize
            // 
            this.muDropSize.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.muDropSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.muDropSize.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muItemByte,
            this.muItemKbyte,
            this.muItemMbyte,
            this.muItemGbyte,
            this.muItemAuto});
            this.muDropSize.Image = ((System.Drawing.Image)(resources.GetObject("muDropSize.Image")));
            this.muDropSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.muDropSize.Name = "muDropSize";
            this.muDropSize.Size = new System.Drawing.Size(60, 22);
            this.muDropSize.Text = "Размер";
            // 
            // muItemByte
            // 
            this.muItemByte.Name = "muItemByte";
            this.muItemByte.Size = new System.Drawing.Size(110, 22);
            this.muItemByte.Text = "Байт";
            // 
            // muItemKbyte
            // 
            this.muItemKbyte.Name = "muItemKbyte";
            this.muItemKbyte.Size = new System.Drawing.Size(110, 22);
            this.muItemKbyte.Text = "Кбайт";
            // 
            // muItemMbyte
            // 
            this.muItemMbyte.Name = "muItemMbyte";
            this.muItemMbyte.Size = new System.Drawing.Size(110, 22);
            this.muItemMbyte.Text = "Мбайт";
            // 
            // muItemGbyte
            // 
            this.muItemGbyte.Name = "muItemGbyte";
            this.muItemGbyte.Size = new System.Drawing.Size(110, 22);
            this.muItemGbyte.Text = "Гбайт";
            // 
            // muItemAuto
            // 
            this.muItemAuto.Name = "muItemAuto";
            this.muItemAuto.Size = new System.Drawing.Size(110, 22);
            this.muItemAuto.Text = "Авто";
            // 
            // tsFilterExt
            // 
            this.tsFilterExt.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsFilterExt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsFilterExt.Name = "tsFilterExt";
            this.tsFilterExt.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(147, 22);
            this.toolStripLabel2.Text = "Фильтр по расширениям";
            // 
            // TSSettings
            // 
            this.TSSettings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отображатьToolStripMenuItem,
            this.toolStripSeparator1,
            this.скрытыеФайлыToolStripMenuItem});
            this.TSSettings.Image = ((System.Drawing.Image)(resources.GetObject("TSSettings.Image")));
            this.TSSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSSettings.Name = "TSSettings";
            this.TSSettings.Size = new System.Drawing.Size(80, 22);
            this.TSSettings.Text = "Настройки";
            // 
            // отображатьToolStripMenuItem
            // 
            this.отображатьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muBuDirView,
            this.muBuFileView,
            this.muBuAllView});
            this.отображатьToolStripMenuItem.Name = "отображатьToolStripMenuItem";
            this.отображатьToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.отображатьToolStripMenuItem.Text = "Отображать";
            // 
            // muBuDirView
            // 
            this.muBuDirView.Name = "muBuDirView";
            this.muBuDirView.Size = new System.Drawing.Size(141, 22);
            this.muBuDirView.Text = "Директории";
            // 
            // muBuFileView
            // 
            this.muBuFileView.Name = "muBuFileView";
            this.muBuFileView.Size = new System.Drawing.Size(141, 22);
            this.muBuFileView.Text = "Файлы";
            // 
            // muBuAllView
            // 
            this.muBuAllView.Name = "muBuAllView";
            this.muBuAllView.Size = new System.Drawing.Size(141, 22);
            this.muBuAllView.Text = "Все";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // скрытыеФайлыToolStripMenuItem
            // 
            this.скрытыеФайлыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSViewHiddenFiles});
            this.скрытыеФайлыToolStripMenuItem.Name = "скрытыеФайлыToolStripMenuItem";
            this.скрытыеФайлыToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.скрытыеФайлыToolStripMenuItem.Text = "Скрытые файлы";
            // 
            // TSViewHiddenFiles
            // 
            this.TSViewHiddenFiles.Name = "TSViewHiddenFiles";
            this.TSViewHiddenFiles.Size = new System.Drawing.Size(249, 22);
            this.TSViewHiddenFiles.Text = "Не Показывать скрытые файлы";
            // 
            // lv
            // 
            this.lv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv.HideSelection = false;
            this.lv.Location = new System.Drawing.Point(0, 50);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(800, 400);
            this.lv.TabIndex = 3;
            this.lv.UseCompatibleStateImageBehavior = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuMain.Name = "contextMenuStrip1";
            this.contextMenuMain.Size = new System.Drawing.Size(61, 4);
            // 
            // lvFavorite
            // 
            this.lvFavorite.HideSelection = false;
            this.lvFavorite.Location = new System.Drawing.Point(556, 50);
            this.lvFavorite.Name = "lvFavorite";
            this.lvFavorite.Size = new System.Drawing.Size(220, 222);
            this.lvFavorite.TabIndex = 4;
            this.lvFavorite.UseCompatibleStateImageBehavior = false;
            this.lvFavorite.Visible = false;
            // 
            // buViewFavorite
            // 
            this.buViewFavorite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buViewFavorite.Image = ((System.Drawing.Image)(resources.GetObject("buViewFavorite.Image")));
            this.buViewFavorite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buViewFavorite.Name = "buViewFavorite";
            this.buViewFavorite.Size = new System.Drawing.Size(135, 22);
            this.buViewFavorite.Text = "Показать \"Избранное\"";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuFavorite.Name = "contextMenuStrip2";
            this.contextMenuFavorite.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvFavorite);
            this.Controls.Add(this.lv);
            this.Controls.Add(this.tsMin);
            this.Controls.Add(this.tsMax);
            this.Name = "Form1";
            this.Text = "labFileExplorer";
            this.tsMax.ResumeLayout(false);
            this.tsMax.PerformLayout();
            this.tsMin.ResumeLayout(false);
            this.tsMin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMax;
        private System.Windows.Forms.ToolStripButton buBack;
        private System.Windows.Forms.ToolStripButton buForward;
        private System.Windows.Forms.ToolStripButton buUp;
        private System.Windows.Forms.ToolStripTextBox edDir;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripButton buDirSelect;
        private System.Windows.Forms.ToolStripMenuItem miViewLargeIcon;
        private System.Windows.Forms.ToolStripMenuItem miViewSmallIcon;
        private System.Windows.Forms.ToolStripMenuItem miViewList;
        private System.Windows.Forms.ToolStripMenuItem miViewDetails;
        private System.Windows.Forms.ToolStripMenuItem miViewTile;
        private System.Windows.Forms.ToolStrip tsMin;
        private System.Windows.Forms.ToolStripTextBox tbSearch;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ToolStripDropDownButton muDropSize;
        private System.Windows.Forms.ToolStripMenuItem muItemByte;
        private System.Windows.Forms.ToolStripMenuItem muItemKbyte;
        private System.Windows.Forms.ToolStripMenuItem muItemMbyte;
        private System.Windows.Forms.ToolStripMenuItem muItemGbyte;
        private System.Windows.Forms.ToolStripTextBox tsFilterExt;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripDropDownButton TSSettings;
        private System.Windows.Forms.ToolStripMenuItem отображатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muBuDirView;
        private System.Windows.Forms.ToolStripMenuItem muBuFileView;
        private System.Windows.Forms.ToolStripMenuItem muBuAllView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem скрытыеФайлыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSViewHiddenFiles;
        private System.Windows.Forms.ToolStripMenuItem muItemAuto;
        private System.Windows.Forms.ContextMenuStrip contextMenuMain;
        private System.Windows.Forms.ToolStripButton buViewFavorite;
        private System.Windows.Forms.ListView lvFavorite;
        private System.Windows.Forms.ContextMenuStrip contextMenuFavorite;
    }
}

