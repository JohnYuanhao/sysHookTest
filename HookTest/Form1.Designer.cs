namespace HookTest
{
    partial class Form1
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
            this.btnInstallHook = new System.Windows.Forms.Button();
            this.btnUnInstall = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbKeyState = new System.Windows.Forms.Label();
            this.lbMouseState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInstallHook
            // 
            this.btnInstallHook.Location = new System.Drawing.Point(117, 39);
            this.btnInstallHook.Name = "btnInstallHook";
            this.btnInstallHook.Size = new System.Drawing.Size(121, 40);
            this.btnInstallHook.TabIndex = 0;
            this.btnInstallHook.Text = "安装钩子";
            this.btnInstallHook.UseVisualStyleBackColor = true;
            this.btnInstallHook.Click += new System.EventHandler(this.btnInstallHook_Click);
            // 
            // btnUnInstall
            // 
            this.btnUnInstall.Location = new System.Drawing.Point(272, 39);
            this.btnUnInstall.Name = "btnUnInstall";
            this.btnUnInstall.Size = new System.Drawing.Size(121, 40);
            this.btnUnInstall.TabIndex = 0;
            this.btnUnInstall.Text = "卸载钩子";
            this.btnUnInstall.UseVisualStyleBackColor = true;
            this.btnUnInstall.Click += new System.EventHandler(this.btnUnInstall_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "键盘:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "鼠标:";
            // 
            // lbKeyState
            // 
            this.lbKeyState.AutoSize = true;
            this.lbKeyState.Location = new System.Drawing.Point(115, 192);
            this.lbKeyState.Name = "lbKeyState";
            this.lbKeyState.Size = new System.Drawing.Size(29, 12);
            this.lbKeyState.TabIndex = 3;
            this.lbKeyState.Text = "未知";
            // 
            // lbMouseState
            // 
            this.lbMouseState.AutoSize = true;
            this.lbMouseState.Location = new System.Drawing.Point(115, 249);
            this.lbMouseState.Name = "lbMouseState";
            this.lbMouseState.Size = new System.Drawing.Size(29, 12);
            this.lbMouseState.TabIndex = 3;
            this.lbMouseState.Text = "未知";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 363);
            this.Controls.Add(this.lbMouseState);
            this.Controls.Add(this.lbKeyState);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUnInstall);
            this.Controls.Add(this.btnInstallHook);
            this.Name = "Form1";
            this.Text = "全局钩子测试程序";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInstallHook;
        private System.Windows.Forms.Button btnUnInstall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbKeyState;
        private System.Windows.Forms.Label lbMouseState;
    }
}

