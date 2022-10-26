namespace ClipFix
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbDisableStartupNotification = new System.Windows.Forms.CheckBox();
            this.cbEnableDebugNotification = new System.Windows.Forms.CheckBox();
            this.cbRunMinimized = new System.Windows.Forms.CheckBox();
            this.cbRunOnStartUp = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbDebug = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbDisableStartupNotification);
            this.groupBox1.Controls.Add(this.cbEnableDebugNotification);
            this.groupBox1.Controls.Add(this.cbRunMinimized);
            this.groupBox1.Controls.Add(this.cbRunOnStartUp);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // cbDisableStartupNotification
            // 
            this.cbDisableStartupNotification.AutoSize = true;
            this.cbDisableStartupNotification.Location = new System.Drawing.Point(6, 97);
            this.cbDisableStartupNotification.Name = "cbDisableStartupNotification";
            this.cbDisableStartupNotification.Size = new System.Drawing.Size(171, 19);
            this.cbDisableStartupNotification.TabIndex = 4;
            this.cbDisableStartupNotification.Text = "Disable Startup Notificaiton";
            this.cbDisableStartupNotification.UseVisualStyleBackColor = true;
            this.cbDisableStartupNotification.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // cbEnableDebugNotification
            // 
            this.cbEnableDebugNotification.AutoSize = true;
            this.cbEnableDebugNotification.Location = new System.Drawing.Point(6, 72);
            this.cbEnableDebugNotification.Name = "cbEnableDebugNotification";
            this.cbEnableDebugNotification.Size = new System.Drawing.Size(165, 19);
            this.cbEnableDebugNotification.TabIndex = 3;
            this.cbEnableDebugNotification.Text = "Enable Debug Notification\r\n";
            this.cbEnableDebugNotification.UseVisualStyleBackColor = true;
            this.cbEnableDebugNotification.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // cbRunMinimized
            // 
            this.cbRunMinimized.AutoSize = true;
            this.cbRunMinimized.Location = new System.Drawing.Point(6, 47);
            this.cbRunMinimized.Name = "cbRunMinimized";
            this.cbRunMinimized.Size = new System.Drawing.Size(106, 19);
            this.cbRunMinimized.TabIndex = 2;
            this.cbRunMinimized.Text = "Run minimized";
            this.cbRunMinimized.UseVisualStyleBackColor = true;
            this.cbRunMinimized.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // cbRunOnStartUp
            // 
            this.cbRunOnStartUp.AutoSize = true;
            this.cbRunOnStartUp.Location = new System.Drawing.Point(6, 22);
            this.cbRunOnStartUp.Name = "cbRunOnStartUp";
            this.cbRunOnStartUp.Size = new System.Drawing.Size(104, 19);
            this.cbRunOnStartUp.TabIndex = 1;
            this.cbRunOnStartUp.Text = "Run on startup";
            this.cbRunOnStartUp.UseVisualStyleBackColor = true;
            this.cbRunOnStartUp.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbDebug);
            this.groupBox2.Location = new System.Drawing.Point(266, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 205);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Debug";
            // 
            // tbDebug
            // 
            this.tbDebug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDebug.Location = new System.Drawing.Point(3, 19);
            this.tbDebug.Multiline = true;
            this.tbDebug.Name = "tbDebug";
            this.tbDebug.Size = new System.Drawing.Size(261, 183);
            this.tbDebug.TabIndex = 0;
            this.tbDebug.ReadOnly = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Clipy Fix";
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "A smol program I wrote to fix\r\nannoying double image posting\r\nin Discord from Fir" +
    "efox";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 225);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Clipy Fix";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        public CheckBox cbRunMinimized;
        public CheckBox cbRunOnStartUp;
        private GroupBox groupBox2;
        public TextBox tbDebug;
        private NotifyIcon notifyIcon1;
        private Label label1;
        public CheckBox cbEnableDebugNotification;
        public CheckBox cbDisableStartupNotification;
    }
}