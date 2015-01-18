namespace Viewer {
    partial class ParseLinkForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.labelPattern = new System.Windows.Forms.Label();
            this.textboxPattern = new System.Windows.Forms.TextBox();
            this.btnParse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPattern
            // 
            this.labelPattern.AutoSize = true;
            this.labelPattern.Location = new System.Drawing.Point(12, 21);
            this.labelPattern.Name = "labelPattern";
            this.labelPattern.Size = new System.Drawing.Size(77, 12);
            this.labelPattern.TabIndex = 0;
            this.labelPattern.Text = "正则表达式：";
            // 
            // textboxPattern
            // 
            this.textboxPattern.Location = new System.Drawing.Point(95, 18);
            this.textboxPattern.Name = "textboxPattern";
            this.textboxPattern.Size = new System.Drawing.Size(472, 21);
            this.textboxPattern.TabIndex = 1;
            this.textboxPattern.Text = "/knowledge/(video)|(document)/";
            // 
            // btnParse
            // 
            this.btnParse.Location = new System.Drawing.Point(573, 16);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(75, 23);
            this.btnParse.TabIndex = 2;
            this.btnParse.Text = "解析";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // ParseLinkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 57);
            this.Controls.Add(this.btnParse);
            this.Controls.Add(this.textboxPattern);
            this.Controls.Add(this.labelPattern);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ParseLinkForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "解析链接";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPattern;
        private System.Windows.Forms.TextBox textboxPattern;
        private System.Windows.Forms.Button btnParse;
    }
}