using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viewer {
    public partial class TaskForm : Form {
        private TaskContext m_taskContext;

        public TaskForm() {
            InitializeComponent();
        }

        public TaskContext TaskContext {
            get {
                return m_taskContext;
            }
        }

        private void btnOk_Click(object sender, EventArgs e) {
            try {
                var addresses = textboxAddresses.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).Select(addr => new Uri(addr)).ToList();

                if (addresses.Count == 0) {
                    MessageBox.Show("没有输入任何网址");
                    return;
                }

                m_taskContext = new TaskContext();
                m_taskContext.ChangeInterval = TimeSpan.FromMinutes((int)numericChangeInterval.Value);
                m_taskContext.MacroInterval = TimeSpan.FromMinutes((int)numericMacroInterval.Value);
                m_taskContext.Urls = addresses;

                DialogResult = DialogResult.OK;
                Close();
            } catch (UriFormatException) {
                MessageBox.Show("输入了错误的网址");
            }
        }
    }
}
