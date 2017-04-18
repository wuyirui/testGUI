namespace testGUI
{
    partial class mainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.YangtseButton = new System.Windows.Forms.Button();
            this.RiverwayButton = new System.Windows.Forms.Button();
            this.ProvinceButton = new System.Windows.Forms.Button();
            this.OutputMsg = new System.Windows.Forms.RichTextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.CheckButton = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.tabControl = new System.Windows.Forms.TabControl();
            this.TodayPage = new System.Windows.Forms.TabPage();
            this.ProgressText = new System.Windows.Forms.Label();
            this.HistoryPage = new System.Windows.Forms.TabPage();
            this.HistoryMessage = new System.Windows.Forms.RichTextBox();
            this.HistoryButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.selectRegion = new System.Windows.Forms.ComboBox();
            this.ToPicker = new System.Windows.Forms.DateTimePicker();
            this.FromPicker = new System.Windows.Forms.DateTimePicker();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.statusStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.TodayPage.SuspendLayout();
            this.HistoryPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // YangtseButton
            // 
            this.YangtseButton.Location = new System.Drawing.Point(311, 60);
            this.YangtseButton.Name = "YangtseButton";
            this.YangtseButton.Size = new System.Drawing.Size(95, 36);
            this.YangtseButton.TabIndex = 1;
            this.YangtseButton.Text = "YangtseRiver";
            this.YangtseButton.UseVisualStyleBackColor = true;
            this.YangtseButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // RiverwayButton
            // 
            this.RiverwayButton.Location = new System.Drawing.Point(311, 102);
            this.RiverwayButton.Name = "RiverwayButton";
            this.RiverwayButton.Size = new System.Drawing.Size(95, 42);
            this.RiverwayButton.TabIndex = 2;
            this.RiverwayButton.Text = "KeyRiverway";
            this.RiverwayButton.UseVisualStyleBackColor = true;
            this.RiverwayButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // ProvinceButton
            // 
            this.ProvinceButton.Location = new System.Drawing.Point(311, 149);
            this.ProvinceButton.Name = "ProvinceButton";
            this.ProvinceButton.Size = new System.Drawing.Size(95, 38);
            this.ProvinceButton.TabIndex = 3;
            this.ProvinceButton.Text = "Province";
            this.ProvinceButton.UseVisualStyleBackColor = true;
            this.ProvinceButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // OutputMsg
            // 
            this.OutputMsg.Location = new System.Drawing.Point(6, 60);
            this.OutputMsg.Name = "OutputMsg";
            this.OutputMsg.ReadOnly = true;
            this.OutputMsg.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.OutputMsg.ShortcutsEnabled = false;
            this.OutputMsg.Size = new System.Drawing.Size(299, 127);
            this.OutputMsg.TabIndex = 4;
            this.OutputMsg.Text = "";
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.progressBar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.progressBar.Location = new System.Drawing.Point(7, 26);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(399, 23);
            this.progressBar.TabIndex = 5;
            // 
            // CheckButton
            // 
            this.CheckButton.Enabled = true;
            this.CheckButton.Interval = 50;
            this.CheckButton.Tick += new System.EventHandler(this.CheckButton_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Hydrology";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 238);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(441, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // clock
            // 
            this.clock.Enabled = true;
            this.clock.Interval = 1000;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.TodayPage);
            this.tabControl.Controls.Add(this.HistoryPage);
            this.tabControl.Location = new System.Drawing.Point(12, 11);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(425, 219);
            this.tabControl.TabIndex = 8;
            // 
            // TodayPage
            // 
            this.TodayPage.Controls.Add(this.ProgressText);
            this.TodayPage.Controls.Add(this.progressBar);
            this.TodayPage.Controls.Add(this.YangtseButton);
            this.TodayPage.Controls.Add(this.RiverwayButton);
            this.TodayPage.Controls.Add(this.OutputMsg);
            this.TodayPage.Controls.Add(this.ProvinceButton);
            this.TodayPage.Location = new System.Drawing.Point(4, 22);
            this.TodayPage.Name = "TodayPage";
            this.TodayPage.Padding = new System.Windows.Forms.Padding(3);
            this.TodayPage.Size = new System.Drawing.Size(417, 193);
            this.TodayPage.TabIndex = 0;
            this.TodayPage.Text = "Today";
            this.TodayPage.UseVisualStyleBackColor = true;
            // 
            // ProgressText
            // 
            this.ProgressText.AutoSize = true;
            this.ProgressText.Location = new System.Drawing.Point(6, 11);
            this.ProgressText.Name = "ProgressText";
            this.ProgressText.Size = new System.Drawing.Size(0, 12);
            this.ProgressText.TabIndex = 6;
            // 
            // HistoryPage
            // 
            this.HistoryPage.Controls.Add(this.HistoryMessage);
            this.HistoryPage.Controls.Add(this.HistoryButton);
            this.HistoryPage.Controls.Add(this.label2);
            this.HistoryPage.Controls.Add(this.label1);
            this.HistoryPage.Controls.Add(this.selectRegion);
            this.HistoryPage.Controls.Add(this.ToPicker);
            this.HistoryPage.Controls.Add(this.FromPicker);
            this.HistoryPage.Location = new System.Drawing.Point(4, 22);
            this.HistoryPage.Name = "HistoryPage";
            this.HistoryPage.Padding = new System.Windows.Forms.Padding(3);
            this.HistoryPage.Size = new System.Drawing.Size(417, 193);
            this.HistoryPage.TabIndex = 1;
            this.HistoryPage.Text = "History";
            this.HistoryPage.UseVisualStyleBackColor = true;
            // 
            // HistoryMessage
            // 
            this.HistoryMessage.Location = new System.Drawing.Point(232, 48);
            this.HistoryMessage.Name = "HistoryMessage";
            this.HistoryMessage.ReadOnly = true;
            this.HistoryMessage.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.HistoryMessage.ShortcutsEnabled = false;
            this.HistoryMessage.Size = new System.Drawing.Size(172, 128);
            this.HistoryMessage.TabIndex = 7;
            this.HistoryMessage.Text = "";
            // 
            // HistoryButton
            // 
            this.HistoryButton.Location = new System.Drawing.Point(14, 148);
            this.HistoryButton.Name = "HistoryButton";
            this.HistoryButton.Size = new System.Drawing.Size(212, 21);
            this.HistoryButton.TabIndex = 5;
            this.HistoryButton.Text = "Query";
            this.HistoryButton.UseVisualStyleBackColor = true;
            this.HistoryButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "From";
            // 
            // selectRegion
            // 
            this.selectRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectRegion.FormattingEnabled = true;
            this.selectRegion.Items.AddRange(new object[] {
            "北京-雨情",
            "北京-河道",
            "北京-水库",
            "湖南-水清",
            "陕西-雨情",
            "陕西-水清",
            "欧洲天气"});
            this.selectRegion.Location = new System.Drawing.Point(12, 15);
            this.selectRegion.Name = "selectRegion";
            this.selectRegion.Size = new System.Drawing.Size(392, 20);
            this.selectRegion.TabIndex = 2;
            // 
            // ToPicker
            // 
            this.ToPicker.Location = new System.Drawing.Point(14, 114);
            this.ToPicker.Name = "ToPicker";
            this.ToPicker.Size = new System.Drawing.Size(212, 21);
            this.ToPicker.TabIndex = 1;
            // 
            // FromPicker
            // 
            this.FromPicker.Location = new System.Drawing.Point(14, 67);
            this.FromPicker.Name = "FromPicker";
            this.FromPicker.Size = new System.Drawing.Size(212, 21);
            this.FromPicker.TabIndex = 0;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(441, 260);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hydrology";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.SizeChanged += new System.EventHandler(this.mainForm_SizeChanged);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.TodayPage.ResumeLayout(false);
            this.TodayPage.PerformLayout();
            this.HistoryPage.ResumeLayout(false);
            this.HistoryPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button YangtseButton;
        private System.Windows.Forms.Button RiverwayButton;
        private System.Windows.Forms.Button ProvinceButton;
        private System.Windows.Forms.RichTextBox OutputMsg;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer CheckButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage TodayPage;
        private System.Windows.Forms.TabPage HistoryPage;
        private System.Windows.Forms.Button HistoryButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selectRegion;
        private System.Windows.Forms.DateTimePicker ToPicker;
        private System.Windows.Forms.DateTimePicker FromPicker;
        private System.Windows.Forms.RichTextBox HistoryMessage;
        private System.Windows.Forms.Label ProgressText;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
    }
}

