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
            this.OutputMsg = new System.Windows.Forms.RichTextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.CheckButton = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.normalWinMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.tabControl = new System.Windows.Forms.TabControl();
            this.TodayPage = new System.Windows.Forms.TabPage();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProgressText = new System.Windows.Forms.Label();
            this.HistoryPage = new System.Windows.Forms.TabPage();
            this.HistoryMessage = new System.Windows.Forms.RichTextBox();
            this.HistoryButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.selectRegion = new System.Windows.Forms.ComboBox();
            this.ToPicker = new System.Windows.Forms.DateTimePicker();
            this.FromPicker = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.清理缓存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于本软件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.TodayPage.SuspendLayout();
            this.HistoryPage.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutputMsg
            // 
            this.OutputMsg.Location = new System.Drawing.Point(24, 197);
            this.OutputMsg.Margin = new System.Windows.Forms.Padding(4);
            this.OutputMsg.Name = "OutputMsg";
            this.OutputMsg.ReadOnly = true;
            this.OutputMsg.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.OutputMsg.ShortcutsEnabled = false;
            this.OutputMsg.Size = new System.Drawing.Size(516, 184);
            this.OutputMsg.TabIndex = 4;
            this.OutputMsg.Text = "";
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.progressBar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.progressBar.Location = new System.Drawing.Point(240, 30);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(300, 29);
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
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Hydrology";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalWinMenuItem,
            this.exitMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 56);
            // 
            // normalWinMenuItem
            // 
            this.normalWinMenuItem.Name = "normalWinMenuItem";
            this.normalWinMenuItem.Size = new System.Drawing.Size(144, 26);
            this.normalWinMenuItem.Text = "恢复窗口";
            this.normalWinMenuItem.Click += new System.EventHandler(this.normalWinMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(144, 26);
            this.exitMenuItem.Text = "退出";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 442);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(571, 22);
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
            this.tabControl.Location = new System.Drawing.Point(0, 32);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(571, 432);
            this.tabControl.TabIndex = 8;
            // 
            // TodayPage
            // 
            this.TodayPage.Controls.Add(this.label8);
            this.TodayPage.Controls.Add(this.label7);
            this.TodayPage.Controls.Add(this.label6);
            this.TodayPage.Controls.Add(this.progressBar2);
            this.TodayPage.Controls.Add(this.progressBar1);
            this.TodayPage.Controls.Add(this.label5);
            this.TodayPage.Controls.Add(this.label4);
            this.TodayPage.Controls.Add(this.label3);
            this.TodayPage.Controls.Add(this.ProgressText);
            this.TodayPage.Controls.Add(this.progressBar);
            this.TodayPage.Controls.Add(this.OutputMsg);
            this.TodayPage.Location = new System.Drawing.Point(4, 25);
            this.TodayPage.Margin = new System.Windows.Forms.Padding(4);
            this.TodayPage.Name = "TodayPage";
            this.TodayPage.Padding = new System.Windows.Forms.Padding(4);
            this.TodayPage.Size = new System.Drawing.Size(563, 403);
            this.TodayPage.TabIndex = 0;
            this.TodayPage.Text = "今日情况";
            this.TodayPage.UseVisualStyleBackColor = true;
            // 
            // progressBar2
            // 
            this.progressBar2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.progressBar2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.progressBar2.Location = new System.Drawing.Point(240, 131);
            this.progressBar2.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(300, 29);
            this.progressBar2.TabIndex = 11;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.progressBar1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.progressBar1.Location = new System.Drawing.Point(240, 79);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(300, 29);
            this.progressBar1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 145);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "各省水雨情信息：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 93);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "全国水雨情信息：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "长江航道信息：";
            // 
            // ProgressText
            // 
            this.ProgressText.AutoSize = true;
            this.ProgressText.Location = new System.Drawing.Point(8, 14);
            this.ProgressText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProgressText.Name = "ProgressText";
            this.ProgressText.Size = new System.Drawing.Size(0, 15);
            this.ProgressText.TabIndex = 6;
            // 
            // HistoryPage
            // 
            this.HistoryPage.Controls.Add(this.progressBar3);
            this.HistoryPage.Controls.Add(this.label14);
            this.HistoryPage.Controls.Add(this.label13);
            this.HistoryPage.Controls.Add(this.label12);
            this.HistoryPage.Controls.Add(this.label11);
            this.HistoryPage.Controls.Add(this.textBox2);
            this.HistoryPage.Controls.Add(this.textBox1);
            this.HistoryPage.Controls.Add(this.label10);
            this.HistoryPage.Controls.Add(this.label9);
            this.HistoryPage.Controls.Add(this.HistoryMessage);
            this.HistoryPage.Controls.Add(this.HistoryButton);
            this.HistoryPage.Controls.Add(this.label2);
            this.HistoryPage.Controls.Add(this.label1);
            this.HistoryPage.Controls.Add(this.selectRegion);
            this.HistoryPage.Controls.Add(this.ToPicker);
            this.HistoryPage.Controls.Add(this.FromPicker);
            this.HistoryPage.Location = new System.Drawing.Point(4, 25);
            this.HistoryPage.Margin = new System.Windows.Forms.Padding(4);
            this.HistoryPage.Name = "HistoryPage";
            this.HistoryPage.Padding = new System.Windows.Forms.Padding(4);
            this.HistoryPage.Size = new System.Drawing.Size(563, 403);
            this.HistoryPage.TabIndex = 1;
            this.HistoryPage.Text = "历史情况";
            this.HistoryPage.UseVisualStyleBackColor = true;
            // 
            // HistoryMessage
            // 
            this.HistoryMessage.Location = new System.Drawing.Point(19, 231);
            this.HistoryMessage.Margin = new System.Windows.Forms.Padding(4);
            this.HistoryMessage.Name = "HistoryMessage";
            this.HistoryMessage.ReadOnly = true;
            this.HistoryMessage.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.HistoryMessage.ShortcutsEnabled = false;
            this.HistoryMessage.Size = new System.Drawing.Size(533, 150);
            this.HistoryMessage.TabIndex = 7;
            this.HistoryMessage.Text = "";
            // 
            // HistoryButton
            // 
            this.HistoryButton.Location = new System.Drawing.Point(389, 20);
            this.HistoryButton.Margin = new System.Windows.Forms.Padding(4);
            this.HistoryButton.Name = "HistoryButton";
            this.HistoryButton.Size = new System.Drawing.Size(163, 30);
            this.HistoryButton.TabIndex = 5;
            this.HistoryButton.Text = "数据查询下载";
            this.HistoryButton.UseVisualStyleBackColor = true;
            this.HistoryButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "结束时间：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "起始时间：";
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
            this.selectRegion.Location = new System.Drawing.Point(106, 20);
            this.selectRegion.Margin = new System.Windows.Forms.Padding(4);
            this.selectRegion.Name = "selectRegion";
            this.selectRegion.Size = new System.Drawing.Size(235, 23);
            this.selectRegion.TabIndex = 2;
            // 
            // ToPicker
            // 
            this.ToPicker.Location = new System.Drawing.Point(398, 94);
            this.ToPicker.Margin = new System.Windows.Forms.Padding(4);
            this.ToPicker.Name = "ToPicker";
            this.ToPicker.Size = new System.Drawing.Size(154, 25);
            this.ToPicker.TabIndex = 1;
            // 
            // FromPicker
            // 
            this.FromPicker.Location = new System.Drawing.Point(138, 94);
            this.FromPicker.Margin = new System.Windows.Forms.Padding(4);
            this.FromPicker.Name = "FromPicker";
            this.FromPicker.Size = new System.Drawing.Size(145, 25);
            this.FromPicker.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(571, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.清理缓存ToolStripMenuItem,
            this.ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(51, 24);
            this.toolStripMenuItem1.Text = "操作";
            // 
            // 清理缓存ToolStripMenuItem
            // 
            this.清理缓存ToolStripMenuItem.Name = "清理缓存ToolStripMenuItem";
            this.清理缓存ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.清理缓存ToolStripMenuItem.Text = "清理缓存";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.ToolStripMenuItem.Text = "退出";
            this.ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.帮助ToolStripMenuItem,
            this.关于本软件ToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(51, 24);
            this.toolStripMenuItem2.Text = "关于";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.帮助ToolStripMenuItem.Text = "帮助";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // 关于本软件ToolStripMenuItem
            // 
            this.关于本软件ToolStripMenuItem.Name = "关于本软件ToolStripMenuItem";
            this.关于本软件ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.关于本软件ToolStripMenuItem.Text = "关于本软件";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(144, 44);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "尚未开始";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(144, 93);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "尚未开始";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(144, 145);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "尚未开始";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 140);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "经度：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(299, 140);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "纬度：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 25);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(398, 140);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(154, 25);
            this.textBox2.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 23);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 15);
            this.label11.TabIndex = 12;
            this.label11.Text = "查询内容：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 68);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 15);
            this.label12.TabIndex = 13;
            this.label12.Text = "查询条件：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 185);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 15);
            this.label13.TabIndex = 14;
            this.label13.Text = "查询进度：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label14.Location = new System.Drawing.Point(135, 185);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 15);
            this.label14.TabIndex = 15;
            this.label14.Text = "尚未开始";
            // 
            // progressBar3
            // 
            this.progressBar3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.progressBar3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.progressBar3.Location = new System.Drawing.Point(302, 180);
            this.progressBar3.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(250, 29);
            this.progressBar3.TabIndex = 16;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(571, 464);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hydrology";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.SizeChanged += new System.EventHandler(this.mainForm_SizeChanged);
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.TodayPage.ResumeLayout(false);
            this.TodayPage.PerformLayout();
            this.HistoryPage.ResumeLayout(false);
            this.HistoryPage.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem normalWinMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 清理缓存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于本软件ToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}

