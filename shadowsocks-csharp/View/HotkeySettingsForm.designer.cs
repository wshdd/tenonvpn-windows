﻿namespace Shadowsocks.View
{
    partial class HotkeySettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRegisterAll = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.RegHotkeysAtStartupLabel = new System.Windows.Forms.Label();
            this.SwitchSystemProxyLabel = new System.Windows.Forms.Label();
            this.SwitchProxyModeLabel = new System.Windows.Forms.Label();
            this.SwitchAllowLanLabel = new System.Windows.Forms.Label();
            this.ShowLogsLabel = new System.Windows.Forms.Label();
            this.ServerMoveUpLabel = new System.Windows.Forms.Label();
            this.ServerMoveDownLabel = new System.Windows.Forms.Label();
            this.SwitchSystemProxyTextBox = new System.Windows.Forms.TextBox();
            this.SwitchProxyModeTextBox = new System.Windows.Forms.TextBox();
            this.SwitchAllowLanTextBox = new System.Windows.Forms.TextBox();
            this.ShowLogsTextBox = new System.Windows.Forms.TextBox();
            this.ServerMoveUpTextBox = new System.Windows.Forms.TextBox();
            this.ServerMoveDownTextBox = new System.Windows.Forms.TextBox();
            this.RegHotkeysAtStartupCheckBox = new System.Windows.Forms.CheckBox();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(flowLayoutPanel1, 2);
            flowLayoutPanel1.Controls.Add(this.btnOK);
            flowLayoutPanel1.Controls.Add(this.btnCancel);
            flowLayoutPanel1.Controls.Add(this.btnRegisterAll);
            flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 325);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 24, 0);
            flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            flowLayoutPanel1.Size = new System.Drawing.Size(713, 62);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(499, 10);
            this.btnOK.Margin = new System.Windows.Forms.Padding(5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(185, 47);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(304, 10);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(185, 47);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // btnRegisterAll
            // 
            this.btnRegisterAll.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRegisterAll.Location = new System.Drawing.Point(109, 10);
            this.btnRegisterAll.Margin = new System.Windows.Forms.Padding(5);
            this.btnRegisterAll.Name = "btnRegisterAll";
            this.btnRegisterAll.Size = new System.Drawing.Size(185, 47);
            this.btnRegisterAll.TabIndex = 2;
            this.btnRegisterAll.Text = "Reg All";
            this.btnRegisterAll.UseVisualStyleBackColor = true;
            this.btnRegisterAll.Click += new System.EventHandler(this.RegisterAllButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.RegHotkeysAtStartupLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.SwitchSystemProxyLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SwitchProxyModeLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SwitchAllowLanLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ShowLogsLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ServerMoveUpLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.ServerMoveDownLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.SwitchSystemProxyTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.SwitchProxyModeTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.SwitchAllowLanTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ShowLogsTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.ServerMoveUpTextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.ServerMoveDownTextBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.RegHotkeysAtStartupCheckBox, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.16726F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.16726F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.16726F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.16726F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.7784F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.38949F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.16309F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(737, 391);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // RegHotkeysAtStartupLabel
            // 
            this.RegHotkeysAtStartupLabel.AutoSize = true;
            this.RegHotkeysAtStartupLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RegHotkeysAtStartupLabel.Location = new System.Drawing.Point(49, 279);
            this.RegHotkeysAtStartupLabel.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.RegHotkeysAtStartupLabel.Name = "RegHotkeysAtStartupLabel";
            this.RegHotkeysAtStartupLabel.Size = new System.Drawing.Size(235, 46);
            this.RegHotkeysAtStartupLabel.TabIndex = 16;
            this.RegHotkeysAtStartupLabel.Text = "Reg Hotkeys At Startup";
            this.RegHotkeysAtStartupLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RegHotkeysAtStartupLabel.Click += new System.EventHandler(this.RegHotkeysAtStartupLabel_Click);
            // 
            // SwitchSystemProxyLabel
            // 
            this.SwitchSystemProxyLabel.AutoSize = true;
            this.SwitchSystemProxyLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.SwitchSystemProxyLabel.Location = new System.Drawing.Point(74, 0);
            this.SwitchSystemProxyLabel.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.SwitchSystemProxyLabel.Name = "SwitchSystemProxyLabel";
            this.SwitchSystemProxyLabel.Size = new System.Drawing.Size(210, 46);
            this.SwitchSystemProxyLabel.TabIndex = 0;
            this.SwitchSystemProxyLabel.Text = "Enable System Proxy";
            this.SwitchSystemProxyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SwitchProxyModeLabel
            // 
            this.SwitchProxyModeLabel.AutoSize = true;
            this.SwitchProxyModeLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.SwitchProxyModeLabel.Location = new System.Drawing.Point(12, 46);
            this.SwitchProxyModeLabel.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.SwitchProxyModeLabel.Name = "SwitchProxyModeLabel";
            this.SwitchProxyModeLabel.Size = new System.Drawing.Size(272, 46);
            this.SwitchProxyModeLabel.TabIndex = 1;
            this.SwitchProxyModeLabel.Text = "Switch System Proxy Mode";
            this.SwitchProxyModeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SwitchAllowLanLabel
            // 
            this.SwitchAllowLanLabel.AutoSize = true;
            this.SwitchAllowLanLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.SwitchAllowLanLabel.Location = new System.Drawing.Point(52, 92);
            this.SwitchAllowLanLabel.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.SwitchAllowLanLabel.Name = "SwitchAllowLanLabel";
            this.SwitchAllowLanLabel.Size = new System.Drawing.Size(232, 46);
            this.SwitchAllowLanLabel.TabIndex = 3;
            this.SwitchAllowLanLabel.Text = "Allow Clients from LAN";
            this.SwitchAllowLanLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShowLogsLabel
            // 
            this.ShowLogsLabel.AutoSize = true;
            this.ShowLogsLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ShowLogsLabel.Location = new System.Drawing.Point(153, 138);
            this.ShowLogsLabel.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.ShowLogsLabel.Name = "ShowLogsLabel";
            this.ShowLogsLabel.Size = new System.Drawing.Size(131, 46);
            this.ShowLogsLabel.TabIndex = 4;
            this.ShowLogsLabel.Text = "Show Logs...";
            this.ShowLogsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServerMoveUpLabel
            // 
            this.ServerMoveUpLabel.AutoSize = true;
            this.ServerMoveUpLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ServerMoveUpLabel.Location = new System.Drawing.Point(186, 184);
            this.ServerMoveUpLabel.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.ServerMoveUpLabel.Name = "ServerMoveUpLabel";
            this.ServerMoveUpLabel.Size = new System.Drawing.Size(98, 48);
            this.ServerMoveUpLabel.TabIndex = 4;
            this.ServerMoveUpLabel.Text = "Move up";
            this.ServerMoveUpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServerMoveDownLabel
            // 
            this.ServerMoveDownLabel.AutoSize = true;
            this.ServerMoveDownLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ServerMoveDownLabel.Location = new System.Drawing.Point(155, 232);
            this.ServerMoveDownLabel.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.ServerMoveDownLabel.Name = "ServerMoveDownLabel";
            this.ServerMoveDownLabel.Size = new System.Drawing.Size(129, 47);
            this.ServerMoveDownLabel.TabIndex = 4;
            this.ServerMoveDownLabel.Text = "Move Down";
            this.ServerMoveDownLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SwitchSystemProxyTextBox
            // 
            this.SwitchSystemProxyTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SwitchSystemProxyTextBox.Location = new System.Drawing.Point(301, 5);
            this.SwitchSystemProxyTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 24, 5);
            this.SwitchSystemProxyTextBox.Name = "SwitchSystemProxyTextBox";
            this.SwitchSystemProxyTextBox.ReadOnly = true;
            this.SwitchSystemProxyTextBox.Size = new System.Drawing.Size(414, 34);
            this.SwitchSystemProxyTextBox.TabIndex = 7;
            this.SwitchSystemProxyTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HotkeyDown);
            this.SwitchSystemProxyTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HotkeyUp);
            // 
            // SwitchProxyModeTextBox
            // 
            this.SwitchProxyModeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SwitchProxyModeTextBox.Location = new System.Drawing.Point(301, 51);
            this.SwitchProxyModeTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 24, 5);
            this.SwitchProxyModeTextBox.Name = "SwitchProxyModeTextBox";
            this.SwitchProxyModeTextBox.ReadOnly = true;
            this.SwitchProxyModeTextBox.Size = new System.Drawing.Size(414, 34);
            this.SwitchProxyModeTextBox.TabIndex = 8;
            this.SwitchProxyModeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HotkeyDown);
            this.SwitchProxyModeTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HotkeyUp);
            // 
            // SwitchAllowLanTextBox
            // 
            this.SwitchAllowLanTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SwitchAllowLanTextBox.Location = new System.Drawing.Point(301, 97);
            this.SwitchAllowLanTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 24, 5);
            this.SwitchAllowLanTextBox.Name = "SwitchAllowLanTextBox";
            this.SwitchAllowLanTextBox.ReadOnly = true;
            this.SwitchAllowLanTextBox.Size = new System.Drawing.Size(414, 34);
            this.SwitchAllowLanTextBox.TabIndex = 10;
            this.SwitchAllowLanTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HotkeyDown);
            this.SwitchAllowLanTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HotkeyUp);
            // 
            // ShowLogsTextBox
            // 
            this.ShowLogsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowLogsTextBox.Location = new System.Drawing.Point(301, 143);
            this.ShowLogsTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 24, 5);
            this.ShowLogsTextBox.Name = "ShowLogsTextBox";
            this.ShowLogsTextBox.ReadOnly = true;
            this.ShowLogsTextBox.Size = new System.Drawing.Size(414, 34);
            this.ShowLogsTextBox.TabIndex = 11;
            this.ShowLogsTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HotkeyDown);
            this.ShowLogsTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HotkeyUp);
            // 
            // ServerMoveUpTextBox
            // 
            this.ServerMoveUpTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServerMoveUpTextBox.Location = new System.Drawing.Point(301, 189);
            this.ServerMoveUpTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 24, 5);
            this.ServerMoveUpTextBox.Name = "ServerMoveUpTextBox";
            this.ServerMoveUpTextBox.ReadOnly = true;
            this.ServerMoveUpTextBox.Size = new System.Drawing.Size(414, 34);
            this.ServerMoveUpTextBox.TabIndex = 12;
            this.ServerMoveUpTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HotkeyDown);
            this.ServerMoveUpTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HotkeyUp);
            // 
            // ServerMoveDownTextBox
            // 
            this.ServerMoveDownTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServerMoveDownTextBox.Location = new System.Drawing.Point(301, 237);
            this.ServerMoveDownTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 24, 5);
            this.ServerMoveDownTextBox.Name = "ServerMoveDownTextBox";
            this.ServerMoveDownTextBox.ReadOnly = true;
            this.ServerMoveDownTextBox.Size = new System.Drawing.Size(414, 34);
            this.ServerMoveDownTextBox.TabIndex = 13;
            this.ServerMoveDownTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HotkeyDown);
            this.ServerMoveDownTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HotkeyUp);
            // 
            // RegHotkeysAtStartupCheckBox
            // 
            this.RegHotkeysAtStartupCheckBox.AutoSize = true;
            this.RegHotkeysAtStartupCheckBox.Location = new System.Drawing.Point(301, 292);
            this.RegHotkeysAtStartupCheckBox.Margin = new System.Windows.Forms.Padding(5, 13, 13, 13);
            this.RegHotkeysAtStartupCheckBox.Name = "RegHotkeysAtStartupCheckBox";
            this.RegHotkeysAtStartupCheckBox.Size = new System.Drawing.Size(22, 20);
            this.RegHotkeysAtStartupCheckBox.TabIndex = 17;
            this.RegHotkeysAtStartupCheckBox.UseVisualStyleBackColor = true;
            this.RegHotkeysAtStartupCheckBox.CheckedChanged += new System.EventHandler(this.RegHotkeysAtStartupCheckBox_CheckedChanged);
            // 
            // HotkeySettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(737, 391);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HotkeySettingsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Hotkeys...";
            flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label SwitchSystemProxyLabel;
        private System.Windows.Forms.Label SwitchProxyModeLabel;
        private System.Windows.Forms.Label SwitchAllowLanLabel;
        private System.Windows.Forms.Label ShowLogsLabel;
        private System.Windows.Forms.Label ServerMoveUpLabel;
        private System.Windows.Forms.Label ServerMoveDownLabel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox ShowLogsTextBox;
        private System.Windows.Forms.TextBox SwitchAllowLanTextBox;
        private System.Windows.Forms.TextBox SwitchProxyModeTextBox;
        private System.Windows.Forms.TextBox SwitchSystemProxyTextBox;
        private System.Windows.Forms.TextBox ServerMoveUpTextBox;
        private System.Windows.Forms.TextBox ServerMoveDownTextBox;
        private System.Windows.Forms.Button btnRegisterAll;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label RegHotkeysAtStartupLabel;
        private System.Windows.Forms.CheckBox RegHotkeysAtStartupCheckBox;
    }
}