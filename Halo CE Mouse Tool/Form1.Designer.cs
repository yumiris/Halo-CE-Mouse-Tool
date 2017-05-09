﻿namespace Halo_CE_Mouse_Tool
{
    partial class Mainform
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SensY = new System.Windows.Forms.TextBox();
            this.SensX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.ActivateBtn = new System.Windows.Forms.Button();
            this.PatchBtn = new System.Windows.Forms.Button();
            this.GithubLink = new System.Windows.Forms.LinkLabel();
            this.RedditLink = new System.Windows.Forms.LinkLabel();
            this.EnableBtnTimer = new System.Windows.Forms.Timer(this.components);
            this.PatchBtnTip = new System.Windows.Forms.ToolTip(this.components);
            this.ActivateBtnTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vertical Sensitivity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Horizontal Sensitivity:";
            // 
            // SensY
            // 
            this.SensY.Location = new System.Drawing.Point(324, 29);
            this.SensY.Name = "SensY";
            this.SensY.Size = new System.Drawing.Size(61, 20);
            this.SensY.TabIndex = 2;
            // 
            // SensX
            // 
            this.SensX.Location = new System.Drawing.Point(125, 29);
            this.SensX.Name = "SensX";
            this.SensX.Size = new System.Drawing.Size(61, 20);
            this.SensX.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Status:";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.ForeColor = System.Drawing.Color.Red;
            this.StatusLabel.Location = new System.Drawing.Point(158, 9);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(150, 13);
            this.StatusLabel.TabIndex = 5;
            this.StatusLabel.Text = "Waiting for Halo CE Process...";
            // 
            // ActivateBtn
            // 
            this.ActivateBtn.Enabled = false;
            this.ActivateBtn.Location = new System.Drawing.Point(225, 55);
            this.ActivateBtn.Name = "ActivateBtn";
            this.ActivateBtn.Size = new System.Drawing.Size(171, 33);
            this.ActivateBtn.TabIndex = 6;
            this.ActivateBtn.Text = "Activate(PGUP)";
            this.ActivateBtnTip.SetToolTip(this.ActivateBtn, "Sets the sensitivites to the values above + disables mouse acceleration.");
            this.ActivateBtn.UseVisualStyleBackColor = true;
            this.ActivateBtn.Click += new System.EventHandler(this.ActivateBtn_Click);
            // 
            // PatchBtn
            // 
            this.PatchBtn.Location = new System.Drawing.Point(12, 55);
            this.PatchBtn.Name = "PatchBtn";
            this.PatchBtn.Size = new System.Drawing.Size(171, 33);
            this.PatchBtn.TabIndex = 7;
            this.PatchBtn.Text = "Patch...";
            this.PatchBtnTip.SetToolTip(this.PatchBtn, "Permanently patch the mouse acceleration function in the Halo executable, nullify" +
        "ing the need to use this tool any further.");
            this.PatchBtn.UseVisualStyleBackColor = true;
            this.PatchBtn.Click += new System.EventHandler(this.PatchBtn_Click);
            // 
            // GithubLink
            // 
            this.GithubLink.AutoSize = true;
            this.GithubLink.Location = new System.Drawing.Point(9, 111);
            this.GithubLink.Name = "GithubLink";
            this.GithubLink.Size = new System.Drawing.Size(38, 13);
            this.GithubLink.TabIndex = 8;
            this.GithubLink.TabStop = true;
            this.GithubLink.Text = "Github";
            this.GithubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GithubLink_LinkClicked);
            // 
            // RedditLink
            // 
            this.RedditLink.AutoSize = true;
            this.RedditLink.Location = new System.Drawing.Point(321, 111);
            this.RedditLink.Name = "RedditLink";
            this.RedditLink.Size = new System.Drawing.Size(75, 13);
            this.RedditLink.TabIndex = 9;
            this.RedditLink.TabStop = true;
            this.RedditLink.Text = "Reddit Thread";
            this.RedditLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RedditLink_LinkClicked);
            // 
            // EnableBtnTimer
            // 
            this.EnableBtnTimer.Enabled = true;
            this.EnableBtnTimer.Tick += new System.EventHandler(this.EnableBtnTimer_Tick);
            // 
            // PatchBtnTip
            // 
            this.PatchBtnTip.Tag = "test";
            this.PatchBtnTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.PatchBtnTip.ToolTipTitle = "Patch Halo.exe\'s Mouse Acceleration";
            // 
            // ActivateBtnTip
            // 
            this.ActivateBtnTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ActivateBtnTip.ToolTipTitle = "Activate the tool using the values above.";
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(409, 129);
            this.Controls.Add(this.RedditLink);
            this.Controls.Add(this.GithubLink);
            this.Controls.Add(this.PatchBtn);
            this.Controls.Add(this.ActivateBtn);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SensX);
            this.Controls.Add(this.SensY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "Mainform";
            this.Text = "Halo CE Mouse Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SensY;
        private System.Windows.Forms.TextBox SensX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button ActivateBtn;
        private System.Windows.Forms.Button PatchBtn;
        private System.Windows.Forms.LinkLabel GithubLink;
        private System.Windows.Forms.LinkLabel RedditLink;
        private System.Windows.Forms.Timer EnableBtnTimer;
        private System.Windows.Forms.ToolTip PatchBtnTip;
        private System.Windows.Forms.ToolTip ActivateBtnTip;
    }
}

