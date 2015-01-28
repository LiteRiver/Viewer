using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Viewer.Macro;

namespace Viewer {
    public partial class Workbench : Form, ITaskObserver {
        private ToolStripAddress toolTextboxAddress;

        private ViewTask m_currentTask;

        private MacroForm m_macroForm;

        private INextIntervalParser m_nextIntervalParser;

        public Workbench() {
            InitializeComponent();

            toolTextboxAddress = new ToolStripAddress();
            m_nextIntervalParser = new DefaultNextIntervalParser();
            toolTextboxAddress.BorderStyle = BorderStyle.FixedSingle;
            toolStripWorkbench.Items.Insert(1, toolTextboxAddress);
            toolTextboxAddress.KeyDown += toolTextboxAddress_KeyDown;
        }

        void toolTextboxAddress_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                Navigate();
            }
        }

        private void Workbench_Load(object sender, EventArgs e) {
            browser.DocumentText = "<!DOCTYPE html><head><meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge,chrome=1\"><style>body{background-color:#F41;} h1{margin-top:80px;font-size:80px; text-align:center; color: #FFF; text-shadow: 0 0 150px #FFF, 0 0 60px #FFF, 0 0 10px #FFF;}</style></head><html><body><h1>欢迎使用 “看片”!</h1></body></html>";
        }

        private void toolButtonNavigate_Click(object sender, EventArgs e) {
            Navigate();
        }

        private void menuStart_Click(object sender, EventArgs e) {
            IEnumerable<MacroEvent> macroEvents;
            try {
                macroEvents = MacroStorage.Load();
            } catch (Exception ex) {
                MessageBox.Show("载入宏失败：" + ex.Message);
                return;
            }


            using (var taskForm = new TaskForm()) {
                if (DialogResult.OK == taskForm.ShowDialog()) {
                    Stop();

                    var context = taskForm.TaskContext;
                    context.MacroEvents = macroEvents;

                    m_currentTask = new ViewTask(taskForm.TaskContext, this);
                    m_currentTask.Start();
                }
            }
        }

        private void toolStop_Click(object sender, EventArgs e) {
            if (m_currentTask != null) {
                m_currentTask.Stop();
                m_currentTask = null;
            }

            statusUrl.Text = "大功还未告成，已被手动停止！！！";
        }

        private void browser_Navigating(object sender, WebBrowserNavigatingEventArgs e) {
            statusUrl.Text = "正在努力加载：" + e.Url;
        }

        private void browser_Navigated(object sender, WebBrowserNavigatedEventArgs e) {
            statusUrl.Text = "当前网址：" + browser.Url;
            toolTextboxAddress.Text = browser.Url.ToString();
        }

        // 只有网页载入后才能从中获取下次执行时间，所以只能在此解析下个网页执行的时间。 
        private void browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) {
            if (m_currentTask != null) {
                m_currentTask.PendingNext(m_nextIntervalParser.Parse(browser.DocumentText)); // 获取下次时间并开始定时
            }
        }

        private void browser_NewWindow(object sender, CancelEventArgs e) {
            e.Cancel = true;
        }

        private void toolRecordMacro_Click(object sender, EventArgs e) {
            if (m_macroForm == null || m_macroForm.IsDisposed) {
                m_macroForm = new MacroForm();
            }

            m_macroForm.Stop();
        }

        private void toolPayMacro_Click(object sender, EventArgs e) {
            IEnumerable<MacroEvent> macroEvents;
            try {
                macroEvents = MacroStorage.Load();
            } catch (Exception ex) {
                MessageBox.Show("载入宏失败：" + ex.Message);
                return;
            }

            if (macroEvents == null || macroEvents.Count() == 0) {
                MessageBox.Show("没有录制的宏");
                return;
            }

            Task.Run(() => MacroEvent.Playback(macroEvents)).ContinueWith(t => {
                if (t.Exception != null) {
                    ShowMessage("播放宏出错", t.Exception);
                } else {
                    ShowMessage("播放完毕");
                }
            });
        }

        private void Navigate() {
            var addr = toolTextboxAddress.Text.Trim();
            if (string.IsNullOrEmpty(addr)) {
                return;
            }

            if (!addr.StartsWith("http://", StringComparison.InvariantCultureIgnoreCase) && !addr.StartsWith("https://", StringComparison.InvariantCultureIgnoreCase)) {
                addr = "http://" + addr;
                toolTextboxAddress.Text = addr;
            }

            try {
                browser.Navigate(new Uri(toolTextboxAddress.Text));
            } catch (UriFormatException) {
                MessageBox.Show("输入的地址有误");
            }
        }

        private void Stop() {
            if (m_currentTask != null) {
                m_currentTask.Stop();
                m_currentTask = null;
            }
        }

        public void OnStart() {

        }

        public void OnView(Uri uri, int index) {
            UpdateUI(() => browser.Navigate(uri));
        }

        public void OnComplete() {
            UpdateUI(() => statusUrl.Text = "看完收工");
        }

        private void toolParseLink_Click(object sender, EventArgs e) {
            try {
                var doc = browser.Document;

                using (var form = new ParseLinkForm(doc)) {
                    form.ShowDialog(this);
                }

            } catch {
                MessageBox.Show("解析链接失败，请确定当前页面已正确载入！");
            }
        }

        private void ShowMessage(string msg, Exception ex = null) {
            UpdateUI(() => {
                var str = msg + (ex == null ? "" : ("：" + ex.ToString()));
                MessageBox.Show(str);
            });
        }

        private void UpdateUI(Action action) {
            if (InvokeRequired) {
                BeginInvoke(action);
            } else {
                action();
            }
        }
    }
}
