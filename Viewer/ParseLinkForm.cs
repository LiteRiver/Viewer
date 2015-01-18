using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viewer {
    public partial class ParseLinkForm : Form {
        private HtmlDocument m_doc;

        public ParseLinkForm() {
            InitializeComponent();
        }

        public ParseLinkForm(HtmlDocument doc)
            : this() {
            m_doc = doc;
        }

        private void btnParse_Click(object sender, EventArgs e) {
            var pattern = textboxPattern.Text.Trim();
            if (string.IsNullOrEmpty(pattern)) {
                MessageBox.Show("需要输入正则表达式");
                return;
            }

            try {
                var regex = new Regex(pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);

                var linkElements = m_doc.GetElementsByTagName("a");
                var links = new List<string>();
                foreach (HtmlElement el in linkElements) {

                    Console.WriteLine(el.OuterHtml);
                    if (regex.IsMatch(el.OuterHtml)) {
                        links.Add(el.GetAttribute("href"));
                    }
                }

                var linkText = string.Join(Environment.NewLine, links).Trim();

                if (!string.IsNullOrEmpty(linkText)){
                    Clipboard.SetText(linkText, TextDataFormat.Text);
                    MessageBox.Show("地址已经保存到剪贴板！");
                } else {
                    MessageBox.Show("没有解析到任何链接！");
                }
                
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
