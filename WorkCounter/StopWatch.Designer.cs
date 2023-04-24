﻿namespace WorkCounter
{
    partial class StopWatch
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StopWatch));
            this.exitLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.timeDisplayLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.titleBarPanel = new System.Windows.Forms.Panel();
            this.greetingMessage = new System.Windows.Forms.Label();
            this.minimizeLabel = new System.Windows.Forms.Label();
            this.RefreshGreetingTimer = new System.Windows.Forms.Timer(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.titleBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.BackColor = System.Drawing.Color.Transparent;
            this.exitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitLabel.ForeColor = System.Drawing.Color.White;
            this.exitLabel.Location = new System.Drawing.Point(741, 3);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(48, 52);
            this.exitLabel.TabIndex = 0;
            this.exitLabel.Text = "X";
            this.exitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Black;
            this.startButton.Font = new System.Drawing.Font("Segoe UI", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Location = new System.Drawing.Point(47, 303);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(233, 104);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // timeDisplayLabel
            // 
            this.timeDisplayLabel.AutoSize = true;
            this.timeDisplayLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeDisplayLabel.Font = new System.Drawing.Font("Trebuchet MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeDisplayLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.timeDisplayLabel.Location = new System.Drawing.Point(47, 82);
            this.timeDisplayLabel.Name = "timeDisplayLabel";
            this.timeDisplayLabel.Size = new System.Drawing.Size(706, 200);
            this.timeDisplayLabel.TabIndex = 3;
            this.timeDisplayLabel.Text = "00:00:00";
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Black;
            this.resetButton.Font = new System.Drawing.Font("Segoe UI", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resetButton.ForeColor = System.Drawing.Color.White;
            this.resetButton.Location = new System.Drawing.Point(493, 303);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(233, 104);
            this.resetButton.TabIndex = 9;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // titleBarPanel
            // 
            this.titleBarPanel.BackColor = System.Drawing.Color.Black;
            this.titleBarPanel.Controls.Add(this.greetingMessage);
            this.titleBarPanel.Controls.Add(this.minimizeLabel);
            this.titleBarPanel.Location = new System.Drawing.Point(0, -1);
            this.titleBarPanel.Name = "titleBarPanel";
            this.titleBarPanel.Size = new System.Drawing.Size(807, 79);
            this.titleBarPanel.TabIndex = 10;
            this.titleBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBarPanel_MouseDown);
            this.titleBarPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBarPanel_MouseMove);
            this.titleBarPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBarPanel_MouseUp);
            // 
            // greetingMessage
            // 
            this.greetingMessage.AutoSize = true;
            this.greetingMessage.Font = new System.Drawing.Font("Trebuchet MS", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.greetingMessage.ForeColor = System.Drawing.Color.White;
            this.greetingMessage.Location = new System.Drawing.Point(12, 10);
            this.greetingMessage.Name = "greetingMessage";
            this.greetingMessage.Size = new System.Drawing.Size(209, 59);
            this.greetingMessage.TabIndex = 11;
            this.greetingMessage.Text = "Greeting";
            // 
            // minimizeLabel
            // 
            this.minimizeLabel.AutoSize = true;
            this.minimizeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeLabel.ForeColor = System.Drawing.Color.White;
            this.minimizeLabel.Location = new System.Drawing.Point(684, -2);
            this.minimizeLabel.Name = "minimizeLabel";
            this.minimizeLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.minimizeLabel.Size = new System.Drawing.Size(42, 56);
            this.minimizeLabel.TabIndex = 11;
            this.minimizeLabel.Text = "__";
            this.minimizeLabel.Click += new System.EventHandler(this.MinimizeLabel_Click);
            // 
            // RefreshGreetingTimer
            // 
            this.RefreshGreetingTimer.Enabled = true;
            this.RefreshGreetingTimer.Interval = 60000;
            this.RefreshGreetingTimer.Tick += new System.EventHandler(this.RefreshGreetingTimer_Tick);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick_1);
            // 
            // StopWatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(801, 432);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.timeDisplayLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.titleBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StopWatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timer";
            this.Load += new System.EventHandler(this.StopWatch_Load);
            this.titleBarPanel.ResumeLayout(false);
            this.titleBarPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label exitLabel;
        private Button startButton;
        private Label timeDisplayLabel;
        private Button resetButton;
        private Panel titleBarPanel;
        private Label minimizeLabel;
        private System.Windows.Forms.Timer RefreshGreetingTimer;
        private Label greetingMessage;
        private System.Windows.Forms.Timer timer;
    }
}