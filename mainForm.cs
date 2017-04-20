using System;
using System.Threading;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace testGUI
{
    public delegate void DelReadErrOutput(string result);
    public partial class mainForm : Form
    {
        private Thread run;
        private bool clicked;
        private string dir = @"./Hydrology-Compile/";
        private string prefix = "python ";
        private string suffix = " 1>&2 ";
        private Dictionary<string, string> Button2Script = new Dictionary<string,string>();
        //private string suffix = " ";
        public mainForm()
        {
            InitializeComponent();
        }
        private void mainForm_Load(object sender, EventArgs e)
        {
            // 
            this.Text = "全国水文信息";
            notifyIcon.Text = "全国水文信息";
            YangtseButton.Text = "长江航道";
            RiverwayButton.Text = "全国水雨情";
            ProvinceButton.Text = "各省水雨情";
            HistoryButton.Text = "下载";
            TodayPage.Text = "当日";
            HistoryPage.Text = "历史";
            label1.Text = "开始日期";
            label2.Text = "结束日期";
             //selectRegion.Items.Clear();           
            //
            ShowInTaskbar = true;
            notifyIcon.Visible = false;
            Control.CheckForIllegalCrossThreadCalls = false;
            clicked = false;
            selectRegion.SelectedIndex = 0;
            //
            clock_Tick(new Object(), new EventArgs());
            //
            Button2Script.Add(YangtseButton.Text, @"2-YangtseRiver\|YangtseRiver.pyc|parseList.pyc");
            Button2Script.Add(RiverwayButton.Text, @"3-KeyRiverway\|KeyRiverway.pyc|parseTable.pyc");
            Button2Script.Add(ProvinceButton.Text, @"4-Province\|parseTable.py");
        }

        private void OutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
        {
            if (!String.IsNullOrEmpty(outLine.Data))
            {
                OutputMsg.Text += outLine.Data + "\n";
                ProgressText.Text = outLine.Data;
            }
            progressBar.Value = (progressBar.Value + 10) % progressBar.Maximum;
        }

        Process createCMD()
        {
            Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;     
            p.StartInfo.RedirectStandardInput = true; 
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true; 
            p.StartInfo.CreateNoWindow = true;
            //p.OutputDataReceived += new DataReceivedEventHandler(OutputHandler);
            p.ErrorDataReceived += new DataReceivedEventHandler(OutputHandler);
            p.Start();
            p.StandardInput.AutoFlush = true;
            p.BeginErrorReadLine();
            return p;
        }
        
        void CMD(Object data)
        {
            string[] pairs = (data as string).Split('|');
            string dir = pairs[0];
            string cmd = pairs[1];
            string btstr = pairs[2];
            ProgressText.Text = "正在下载[" + btstr + "]数据";
            Process p = createCMD();
            p.StandardInput.WriteLine("cd " + dir);
            //"dir 1>&2 &" +
            p.StandardInput.WriteLine( cmd + " & exit");
            p.WaitForExit();
            p.Close();
            ProgressText.Text = "[" + btstr + "]数据下载完成";
        }

        void showTime(string task) {
            System.DateTime currentTime = System.DateTime.Now;
            OutputMsg.Text += currentTime.ToString() + "\n";
            OutputMsg.Text += "[" + task + "]任务开始\n";
        }

        void executeScript(string buttonText)
        {
            string sub_cmds = Button2Script[buttonText];
            string[] pairs = sub_cmds.Split('|');
            string sub = pairs[0];
            string subdir = dir + sub;
            string cmd = prefix + pairs[1] + suffix;
            for (int i = 2; i < pairs.Length; i++)
            {
                cmd += "&& " + prefix + pairs[i] + suffix ;
            }
            //string cmd = prefix + script + suffix;
            progressBar.Value = 0;
            showTime(buttonText);
            run = new Thread(new ParameterizedThreadStart(CMD));
            run.IsBackground = true;
            run.Start(subdir + "|" + cmd + "|" + buttonText);
            clicked = true;
        }



        private void Button_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            executeScript(b.Text);
        }

        private void CheckButton_Tick(object sender, EventArgs e)
        {
            if (clicked && run.IsAlive)
            {
                //progressBar.Value = (progressBar.Value + 1) % progressBar.Maximum;
                YangtseButton.Enabled = false;
                RiverwayButton.Enabled = false;
                ProvinceButton.Enabled = false;
                HistoryButton.Enabled = false;
            }
            else {
                progressBar.Value = progressBar.Maximum;
                YangtseButton.Enabled = true;
                RiverwayButton.Enabled = true;
                ProvinceButton.Enabled = true;
                HistoryButton.Enabled = true;
            }

        }

        private void mainForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Visible = false;
                this.notifyIcon.Visible = true;
                this.notifyIcon.ShowBalloonTip(3, "[全国水文信息]", "双击右下角可恢复窗口", ToolTipIcon.Info);
            }
            else {
                this.notifyIcon.Visible = false;
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            this.CenterToScreen();
            this.notifyIcon.Visible = false;

        }

        private void clock_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = DateTime.Now.ToString();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            int qindex = selectRegion.SelectedIndex;
            DateTime from = FromPicker.Value.Date;
            DateTime to = ToPicker.Value.Date;
            DateTime now = DateTime.Now.Date;

            if (to > now) 
            {
                MessageBox.Show("对不起，我们无法下载未来数据", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (to < from)
            {
                MessageBox.Show("日期区间有误请检查", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                string script = "queryHistory.py";
                string sub = dir + @"5-History\";
                string arg = " " + qindex.ToString() + " ";
                OutputMsg.Text += "[History query]\n";
                clicked = true;
                for (DateTime index = from; index <= to; index.AddDays(1)) {
                    run = new Thread(new ParameterizedThreadStart(CMD));
                    run.IsBackground = true;
                    string dtime = index.ToString("yyyy-MM-dd");
                    string cmd = prefix + script + arg + dtime + suffix;
                    run.Start(sub + "|" + cmd);
                }
            }
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void normalWinMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon_MouseDoubleClick(sender, e as MouseEventArgs);
        }

    }
}
