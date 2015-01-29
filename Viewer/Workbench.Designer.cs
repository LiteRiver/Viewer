namespace Viewer {
    partial class Workbench {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Workbench));
            this.menuWorkbench = new System.Windows.Forms.MenuStrip();
            this.menuTask = new System.Windows.Forms.ToolStripMenuItem();
            this.toolRecordMacro = new System.Windows.Forms.ToolStripMenuItem();
            this.toolPayMacro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStart = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolParseLink = new System.Windows.Forms.ToolStripMenuItem();
            this.statusWorkbench = new System.Windows.Forms.StatusStrip();
            this.statusUrl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripWorkbench = new System.Windows.Forms.ToolStrip();
            this.toolLableAddress = new System.Windows.Forms.ToolStripLabel();
            this.toolButtonNavigate = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutWorkbench = new System.Windows.Forms.TableLayoutPanel();
            this.browser = new System.Windows.Forms.WebBrowser();
            this.statusProgress = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuWorkbench.SuspendLayout();
            this.statusWorkbench.SuspendLayout();
            this.toolStripWorkbench.SuspendLayout();
            this.tableLayoutWorkbench.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuWorkbench
            // 
            this.menuWorkbench.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTask});
            this.menuWorkbench.Location = new System.Drawing.Point(0, 0);
            this.menuWorkbench.Name = "menuWorkbench";
            this.menuWorkbench.Size = new System.Drawing.Size(784, 25);
            this.menuWorkbench.TabIndex = 3;
            this.menuWorkbench.Text = "menuStrip1";
            // 
            // menuTask
            // 
            this.menuTask.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolRecordMacro,
            this.toolPayMacro,
            this.menuStart,
            this.toolStop,
            this.toolParseLink});
            this.menuTask.Name = "menuTask";
            this.menuTask.Size = new System.Drawing.Size(44, 21);
            this.menuTask.Text = "任务";
            // 
            // toolRecordMacro
            // 
            this.toolRecordMacro.Name = "toolRecordMacro";
            this.toolRecordMacro.Size = new System.Drawing.Size(124, 22);
            this.toolRecordMacro.Text = "录制宏";
            this.toolRecordMacro.Click += new System.EventHandler(this.toolRecordMacro_Click);
            // 
            // toolPayMacro
            // 
            this.toolPayMacro.Name = "toolPayMacro";
            this.toolPayMacro.Size = new System.Drawing.Size(124, 22);
            this.toolPayMacro.Text = "播放宏";
            this.toolPayMacro.Click += new System.EventHandler(this.toolPayMacro_Click);
            // 
            // menuStart
            // 
            this.menuStart.Name = "menuStart";
            this.menuStart.Size = new System.Drawing.Size(124, 22);
            this.menuStart.Text = "开始";
            this.menuStart.Click += new System.EventHandler(this.menuStart_Click);
            // 
            // toolStop
            // 
            this.toolStop.Name = "toolStop";
            this.toolStop.Size = new System.Drawing.Size(124, 22);
            this.toolStop.Text = "停止";
            this.toolStop.Click += new System.EventHandler(this.toolStop_Click);
            // 
            // toolParseLink
            // 
            this.toolParseLink.Name = "toolParseLink";
            this.toolParseLink.Size = new System.Drawing.Size(124, 22);
            this.toolParseLink.Text = "解析链接";
            this.toolParseLink.Click += new System.EventHandler(this.toolParseLink_Click);
            // 
            // statusWorkbench
            // 
            this.statusWorkbench.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusUrl,
            this.statusProgress});
            this.statusWorkbench.Location = new System.Drawing.Point(0, 540);
            this.statusWorkbench.Name = "statusWorkbench";
            this.statusWorkbench.Size = new System.Drawing.Size(784, 22);
            this.statusWorkbench.TabIndex = 4;
            this.statusWorkbench.Text = "statusStrip1";
            // 
            // statusUrl
            // 
            this.statusUrl.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.statusUrl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusUrl.Name = "statusUrl";
            this.statusUrl.Size = new System.Drawing.Size(738, 17);
            this.statusUrl.Spring = true;
            this.statusUrl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripWorkbench
            // 
            this.toolStripWorkbench.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripWorkbench.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolLableAddress,
            this.toolButtonNavigate});
            this.toolStripWorkbench.Location = new System.Drawing.Point(0, 0);
            this.toolStripWorkbench.Name = "toolStripWorkbench";
            this.toolStripWorkbench.Size = new System.Drawing.Size(784, 30);
            this.toolStripWorkbench.Stretch = true;
            this.toolStripWorkbench.TabIndex = 5;
            // 
            // toolLableAddress
            // 
            this.toolLableAddress.Name = "toolLableAddress";
            this.toolLableAddress.Size = new System.Drawing.Size(44, 27);
            this.toolLableAddress.Text = "地址：";
            // 
            // toolButtonNavigate
            // 
            this.toolButtonNavigate.BackColor = System.Drawing.SystemColors.Control;
            this.toolButtonNavigate.Image = ((System.Drawing.Image)(resources.GetObject("toolButtonNavigate.Image")));
            this.toolButtonNavigate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolButtonNavigate.Name = "toolButtonNavigate";
            this.toolButtonNavigate.Size = new System.Drawing.Size(52, 27);
            this.toolButtonNavigate.Text = "浏览";
            this.toolButtonNavigate.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolButtonNavigate.Click += new System.EventHandler(this.toolButtonNavigate_Click);
            // 
            // tableLayoutWorkbench
            // 
            this.tableLayoutWorkbench.ColumnCount = 1;
            this.tableLayoutWorkbench.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutWorkbench.Controls.Add(this.browser, 0, 1);
            this.tableLayoutWorkbench.Controls.Add(this.toolStripWorkbench, 0, 0);
            this.tableLayoutWorkbench.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutWorkbench.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutWorkbench.Name = "tableLayoutWorkbench";
            this.tableLayoutWorkbench.RowCount = 2;
            this.tableLayoutWorkbench.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutWorkbench.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutWorkbench.Size = new System.Drawing.Size(784, 515);
            this.tableLayoutWorkbench.TabIndex = 6;
            // 
            // browser
            // 
            this.browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browser.Location = new System.Drawing.Point(3, 33);
            this.browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser.Name = "browser";
            this.browser.ScriptErrorsSuppressed = true;
            this.browser.Size = new System.Drawing.Size(778, 479);
            this.browser.TabIndex = 4;
            this.browser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.browser_DocumentCompleted);
            this.browser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.browser_Navigated);
            this.browser.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.browser_Navigating);
            this.browser.NewWindow += new System.ComponentModel.CancelEventHandler(this.browser_NewWindow);
            // 
            // statusProgress
            // 
            this.statusProgress.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusProgress.Name = "statusProgress";
            this.statusProgress.Size = new System.Drawing.Size(0, 17);
            this.statusProgress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Workbench
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.tableLayoutWorkbench);
            this.Controls.Add(this.statusWorkbench);
            this.Controls.Add(this.menuWorkbench);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Workbench";
            this.Text = "看片";
            this.Load += new System.EventHandler(this.Workbench_Load);
            this.menuWorkbench.ResumeLayout(false);
            this.menuWorkbench.PerformLayout();
            this.statusWorkbench.ResumeLayout(false);
            this.statusWorkbench.PerformLayout();
            this.toolStripWorkbench.ResumeLayout(false);
            this.toolStripWorkbench.PerformLayout();
            this.tableLayoutWorkbench.ResumeLayout(false);
            this.tableLayoutWorkbench.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuWorkbench;
        private System.Windows.Forms.ToolStripMenuItem menuTask;
        private System.Windows.Forms.ToolStripMenuItem menuStart;
        private System.Windows.Forms.StatusStrip statusWorkbench;
        private System.Windows.Forms.ToolStripStatusLabel statusUrl;
        private System.Windows.Forms.ToolStrip toolStripWorkbench;
        private System.Windows.Forms.ToolStripLabel toolLableAddress;
        private System.Windows.Forms.ToolStripButton toolButtonNavigate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutWorkbench;
        private System.Windows.Forms.WebBrowser browser;
        private System.Windows.Forms.ToolStripMenuItem toolRecordMacro;
        private System.Windows.Forms.ToolStripMenuItem toolPayMacro;
        private System.Windows.Forms.ToolStripMenuItem toolStop;
        private System.Windows.Forms.ToolStripMenuItem toolParseLink;
        private System.Windows.Forms.ToolStripStatusLabel statusProgress;


    }
}

