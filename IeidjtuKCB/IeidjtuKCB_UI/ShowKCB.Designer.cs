namespace IeidjtuKCB_UI
{
    partial class ShowKCB
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.WebBrowserForKCB = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // WebBrowserForKCB
            // 
            this.WebBrowserForKCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebBrowserForKCB.Location = new System.Drawing.Point(0, 0);
            this.WebBrowserForKCB.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebBrowserForKCB.Name = "WebBrowserForKCB";
            this.WebBrowserForKCB.Size = new System.Drawing.Size(1365, 960);
            this.WebBrowserForKCB.TabIndex = 0;
            // 
            // ShowKCB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WebBrowserForKCB);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ShowKCB";
            this.Size = new System.Drawing.Size(1365, 960);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser WebBrowserForKCB;
    }
}
