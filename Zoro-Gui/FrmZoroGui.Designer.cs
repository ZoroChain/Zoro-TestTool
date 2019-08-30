namespace Zoro_Gui
{
    partial class FrmZoroGui
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmZoroGui));
            this.tableControl = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tbxWithdrawAddress = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.tbxLockerAddress = new System.Windows.Forms.TextBox();
            this.cbxLockMethod = new System.Windows.Forms.ComboBox();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.rtbxLockReturnResult = new System.Windows.Forms.RichTextBox();
            this.btnLockSendRaw = new System.Windows.Forms.Button();
            this.btnLockInvoke = new System.Windows.Forms.Button();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.tbxLockContract = new System.Windows.Forms.TextBox();
            this.accountFrmLock = new Zoro_Gui.AccountFrm();
            this.tableControl.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableControl
            // 
            this.tableControl.Controls.Add(this.tabPage7);
            this.tableControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableControl.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableControl.Location = new System.Drawing.Point(0, 0);
            this.tableControl.Name = "tableControl";
            this.tableControl.SelectedIndex = 0;
            this.tableControl.Size = new System.Drawing.Size(856, 540);
            this.tableControl.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.accountFrmLock);
            this.tabPage7.Controls.Add(this.tbxWithdrawAddress);
            this.tabPage7.Controls.Add(this.label56);
            this.tabPage7.Controls.Add(this.tbxLockerAddress);
            this.tabPage7.Controls.Add(this.cbxLockMethod);
            this.tabPage7.Controls.Add(this.label52);
            this.tabPage7.Controls.Add(this.label53);
            this.tabPage7.Controls.Add(this.rtbxLockReturnResult);
            this.tabPage7.Controls.Add(this.btnLockSendRaw);
            this.tabPage7.Controls.Add(this.btnLockInvoke);
            this.tabPage7.Controls.Add(this.label54);
            this.tabPage7.Controls.Add(this.label55);
            this.tabPage7.Controls.Add(this.tbxLockContract);
            this.tabPage7.Location = new System.Drawing.Point(4, 28);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(848, 508);
            this.tabPage7.TabIndex = 8;
            this.tabPage7.Text = "Lock Operation";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tbxWithdrawAddress
            // 
            this.tbxWithdrawAddress.Location = new System.Drawing.Point(125, 252);
            this.tbxWithdrawAddress.Name = "tbxWithdrawAddress";
            this.tbxWithdrawAddress.Size = new System.Drawing.Size(391, 25);
            this.tbxWithdrawAddress.TabIndex = 52;
            this.tbxWithdrawAddress.Visible = false;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(23, 254);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(97, 20);
            this.label56.TabIndex = 51;
            this.label56.Text = "To Address：";
            this.label56.Visible = false;
            // 
            // tbxLockerAddress
            // 
            this.tbxLockerAddress.Location = new System.Drawing.Point(125, 201);
            this.tbxLockerAddress.Name = "tbxLockerAddress";
            this.tbxLockerAddress.Size = new System.Drawing.Size(391, 25);
            this.tbxLockerAddress.TabIndex = 50;
            // 
            // cbxLockMethod
            // 
            this.cbxLockMethod.FormattingEnabled = true;
            this.cbxLockMethod.Items.AddRange(new object[] {
            "UnlockedAmount",
            "LockedAmount",
            "CurrentLockStartTime",
            "UnlockInterval",
            "UnlockAmount",
            "Withdraw"});
            this.cbxLockMethod.Location = new System.Drawing.Point(620, 147);
            this.cbxLockMethod.Name = "cbxLockMethod";
            this.cbxLockMethod.Size = new System.Drawing.Size(163, 27);
            this.cbxLockMethod.TabIndex = 49;
            this.cbxLockMethod.SelectedIndexChanged += new System.EventHandler(this.CbxLockMethod_SelectedIndexChanged);
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(528, 150);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(91, 20);
            this.label52.TabIndex = 43;
            this.label52.Text = "Operation：";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(39, 320);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(64, 20);
            this.label53.TabIndex = 41;
            this.label53.Text = "Result：";
            // 
            // rtbxLockReturnResult
            // 
            this.rtbxLockReturnResult.BackColor = System.Drawing.Color.AliceBlue;
            this.rtbxLockReturnResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbxLockReturnResult.Location = new System.Drawing.Point(44, 354);
            this.rtbxLockReturnResult.Name = "rtbxLockReturnResult";
            this.rtbxLockReturnResult.ReadOnly = true;
            this.rtbxLockReturnResult.Size = new System.Drawing.Size(758, 120);
            this.rtbxLockReturnResult.TabIndex = 40;
            this.rtbxLockReturnResult.Text = "";
            // 
            // btnLockSendRaw
            // 
            this.btnLockSendRaw.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLockSendRaw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLockSendRaw.FlatAppearance.BorderSize = 0;
            this.btnLockSendRaw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLockSendRaw.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLockSendRaw.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLockSendRaw.Location = new System.Drawing.Point(620, 253);
            this.btnLockSendRaw.Name = "btnLockSendRaw";
            this.btnLockSendRaw.Size = new System.Drawing.Size(99, 29);
            this.btnLockSendRaw.TabIndex = 39;
            this.btnLockSendRaw.Text = "Withdraw";
            this.btnLockSendRaw.UseVisualStyleBackColor = false;
            this.btnLockSendRaw.Visible = false;
            this.btnLockSendRaw.Click += new System.EventHandler(this.BtnLockSendRaw_Click);
            // 
            // btnLockInvoke
            // 
            this.btnLockInvoke.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLockInvoke.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLockInvoke.FlatAppearance.BorderSize = 0;
            this.btnLockInvoke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLockInvoke.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLockInvoke.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLockInvoke.Location = new System.Drawing.Point(620, 198);
            this.btnLockInvoke.Name = "btnLockInvoke";
            this.btnLockInvoke.Size = new System.Drawing.Size(99, 29);
            this.btnLockInvoke.TabIndex = 38;
            this.btnLockInvoke.Text = "Query";
            this.btnLockInvoke.UseVisualStyleBackColor = false;
            this.btnLockInvoke.Click += new System.EventHandler(this.BtnLockInvoke_Click);
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(8, 204);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(111, 20);
            this.label54.TabIndex = 37;
            this.label54.Text = "Lock Address：";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(5, 153);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(115, 20);
            this.label55.TabIndex = 36;
            this.label55.Text = "Lock Contract：";
            // 
            // tbxLockContract
            // 
            this.tbxLockContract.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbxLockContract.Location = new System.Drawing.Point(125, 150);
            this.tbxLockContract.Name = "tbxLockContract";
            this.tbxLockContract.Size = new System.Drawing.Size(391, 25);
            this.tbxLockContract.TabIndex = 35;
            this.tbxLockContract.Text = "0xb0a79578303bc8435f5b5221e5fb90d6fe185775";
            // 
            // accountFrmLock
            // 
            this.accountFrmLock.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.accountFrmLock.Dock = System.Windows.Forms.DockStyle.Top;
            this.accountFrmLock.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.accountFrmLock.Location = new System.Drawing.Point(3, 3);
            this.accountFrmLock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.accountFrmLock.Name = "accountFrmLock";
            this.accountFrmLock.RpcUrl = "http://127.0.0.1:20332";
            this.accountFrmLock.Size = new System.Drawing.Size(842, 118);
            this.accountFrmLock.TabIndex = 53;
            // 
            // FrmZoroGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(856, 540);
            this.Controls.Add(this.tableControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmZoroGui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zoro-Gui";
            this.Load += new System.EventHandler(this.FrmZoroGui_Load);
            this.tableControl.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tableControl;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TextBox tbxWithdrawAddress;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.TextBox tbxLockerAddress;
        private System.Windows.Forms.ComboBox cbxLockMethod;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.RichTextBox rtbxLockReturnResult;
        private System.Windows.Forms.Button btnLockSendRaw;
        private System.Windows.Forms.Button btnLockInvoke;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TextBox tbxLockContract;
        private AccountFrm accountFrmLock;
    }
}

