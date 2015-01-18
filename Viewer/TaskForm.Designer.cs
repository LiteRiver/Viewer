namespace Viewer {
    partial class TaskForm {
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
            this.labelChangeInterval = new System.Windows.Forms.Label();
            this.numericChangeInterval = new System.Windows.Forms.NumericUpDown();
            this.labelChangeUnit = new System.Windows.Forms.Label();
            this.textboxAddresses = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelMacroInterval = new System.Windows.Forms.Label();
            this.numericMacroInterval = new System.Windows.Forms.NumericUpDown();
            this.labelMacroUnit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericChangeInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMacroInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // labelChangeInterval
            // 
            this.labelChangeInterval.AutoSize = true;
            this.labelChangeInterval.Location = new System.Drawing.Point(7, 14);
            this.labelChangeInterval.Name = "labelChangeInterval";
            this.labelChangeInterval.Size = new System.Drawing.Size(65, 12);
            this.labelChangeInterval.TabIndex = 2;
            this.labelChangeInterval.Text = "网址间隔：";
            // 
            // numericChangeInterval
            // 
            this.numericChangeInterval.Location = new System.Drawing.Point(78, 10);
            this.numericChangeInterval.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericChangeInterval.Name = "numericChangeInterval";
            this.numericChangeInterval.Size = new System.Drawing.Size(58, 21);
            this.numericChangeInterval.TabIndex = 3;
            this.numericChangeInterval.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // labelChangeUnit
            // 
            this.labelChangeUnit.AutoSize = true;
            this.labelChangeUnit.Location = new System.Drawing.Point(146, 14);
            this.labelChangeUnit.Name = "labelChangeUnit";
            this.labelChangeUnit.Size = new System.Drawing.Size(29, 12);
            this.labelChangeUnit.TabIndex = 4;
            this.labelChangeUnit.Text = "分钟";
            // 
            // textboxAddresses
            // 
            this.textboxAddresses.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textboxAddresses.Location = new System.Drawing.Point(0, 96);
            this.textboxAddresses.Multiline = true;
            this.textboxAddresses.Name = "textboxAddresses";
            this.textboxAddresses.Size = new System.Drawing.Size(286, 222);
            this.textboxAddresses.TabIndex = 5;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(211, 67);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "开始";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(7, 72);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(41, 12);
            this.labelAddress.TabIndex = 7;
            this.labelAddress.Text = "地址：";
            // 
            // labelMacroInterval
            // 
            this.labelMacroInterval.AutoSize = true;
            this.labelMacroInterval.Location = new System.Drawing.Point(7, 43);
            this.labelMacroInterval.Name = "labelMacroInterval";
            this.labelMacroInterval.Size = new System.Drawing.Size(53, 12);
            this.labelMacroInterval.TabIndex = 8;
            this.labelMacroInterval.Text = "宏间隔：";
            // 
            // numericMacroInterval
            // 
            this.numericMacroInterval.Location = new System.Drawing.Point(78, 39);
            this.numericMacroInterval.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericMacroInterval.Name = "numericMacroInterval";
            this.numericMacroInterval.Size = new System.Drawing.Size(58, 21);
            this.numericMacroInterval.TabIndex = 9;
            this.numericMacroInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelMacroUnit
            // 
            this.labelMacroUnit.AutoSize = true;
            this.labelMacroUnit.Location = new System.Drawing.Point(146, 43);
            this.labelMacroUnit.Name = "labelMacroUnit";
            this.labelMacroUnit.Size = new System.Drawing.Size(29, 12);
            this.labelMacroUnit.TabIndex = 10;
            this.labelMacroUnit.Text = "分钟";
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 318);
            this.Controls.Add(this.labelMacroUnit);
            this.Controls.Add(this.numericMacroInterval);
            this.Controls.Add(this.labelMacroInterval);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.textboxAddresses);
            this.Controls.Add(this.labelChangeUnit);
            this.Controls.Add(this.labelChangeInterval);
            this.Controls.Add(this.numericChangeInterval);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TaskForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "开始任务";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.numericChangeInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMacroInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChangeInterval;
        private System.Windows.Forms.NumericUpDown numericChangeInterval;
        private System.Windows.Forms.Label labelChangeUnit;
        private System.Windows.Forms.TextBox textboxAddresses;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelMacroInterval;
        private System.Windows.Forms.NumericUpDown numericMacroInterval;
        private System.Windows.Forms.Label labelMacroUnit;


    }
}