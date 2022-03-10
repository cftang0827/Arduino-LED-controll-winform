namespace arduino_led_controller
{
    partial class MainForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.timeComboBox = new System.Windows.Forms.ComboBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.blinkBtn = new System.Windows.Forms.Button();
            this.logTextBox = new System.Windows.Forms.RichTextBox();
            this.logLabel = new System.Windows.Forms.Label();
            this.stopBtn = new System.Windows.Forms.Button();
            this.serialLabel = new System.Windows.Forms.Label();
            this.serialComboBox = new System.Windows.Forms.ComboBox();
            this.connectBtn = new System.Windows.Forms.Button();
            this.baudLabel = new System.Windows.Forms.Label();
            this.baudComboBox = new System.Windows.Forms.ComboBox();
            this.disconnectBtn = new System.Windows.Forms.Button();
            this.clearlogBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(12, 41);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(137, 76);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "LED \r\n控制軟體";
            // 
            // timeComboBox
            // 
            this.timeComboBox.FormattingEnabled = true;
            this.timeComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.timeComboBox.Location = new System.Drawing.Point(290, 113);
            this.timeComboBox.Name = "timeComboBox";
            this.timeComboBox.Size = new System.Drawing.Size(151, 27);
            this.timeComboBox.TabIndex = 1;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(166, 116);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(39, 19);
            this.timeLabel.TabIndex = 2;
            this.timeLabel.Text = "秒數";
            // 
            // blinkBtn
            // 
            this.blinkBtn.Enabled = false;
            this.blinkBtn.Location = new System.Drawing.Point(460, 113);
            this.blinkBtn.Name = "blinkBtn";
            this.blinkBtn.Size = new System.Drawing.Size(94, 29);
            this.blinkBtn.TabIndex = 3;
            this.blinkBtn.Text = "Blink!";
            this.blinkBtn.UseVisualStyleBackColor = true;
            this.blinkBtn.Click += new System.EventHandler(this.blinkBtn_Click);
            // 
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(36, 191);
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.Size = new System.Drawing.Size(606, 249);
            this.logTextBox.TabIndex = 4;
            this.logTextBox.Text = "";
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.Location = new System.Drawing.Point(36, 159);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(79, 19);
            this.logLabel.TabIndex = 5;
            this.logLabel.Text = "Serial Log";
            // 
            // stopBtn
            // 
            this.stopBtn.Enabled = false;
            this.stopBtn.Location = new System.Drawing.Point(560, 113);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(94, 29);
            this.stopBtn.TabIndex = 6;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // serialLabel
            // 
            this.serialLabel.AutoSize = true;
            this.serialLabel.Location = new System.Drawing.Point(166, 21);
            this.serialLabel.Name = "serialLabel";
            this.serialLabel.Size = new System.Drawing.Size(81, 19);
            this.serialLabel.TabIndex = 7;
            this.serialLabel.Text = "Serial Port";
            // 
            // serialComboBox
            // 
            this.serialComboBox.FormattingEnabled = true;
            this.serialComboBox.Location = new System.Drawing.Point(288, 18);
            this.serialComboBox.Name = "serialComboBox";
            this.serialComboBox.Size = new System.Drawing.Size(151, 27);
            this.serialComboBox.TabIndex = 8;
            this.serialComboBox.SelectedIndexChanged += new System.EventHandler(this.serialComboBox_SelectedIndexChanged);
            // 
            // connectBtn
            // 
            this.connectBtn.Enabled = false;
            this.connectBtn.Location = new System.Drawing.Point(460, 18);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(94, 71);
            this.connectBtn.TabIndex = 9;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // baudLabel
            // 
            this.baudLabel.AutoSize = true;
            this.baudLabel.Location = new System.Drawing.Point(166, 65);
            this.baudLabel.Name = "baudLabel";
            this.baudLabel.Size = new System.Drawing.Size(80, 19);
            this.baudLabel.TabIndex = 10;
            this.baudLabel.Text = "Baud Rate";
            // 
            // baudComboBox
            // 
            this.baudComboBox.FormattingEnabled = true;
            this.baudComboBox.Items.AddRange(new object[] {
            "9600"});
            this.baudComboBox.Location = new System.Drawing.Point(288, 62);
            this.baudComboBox.Name = "baudComboBox";
            this.baudComboBox.Size = new System.Drawing.Size(151, 27);
            this.baudComboBox.TabIndex = 11;
            this.baudComboBox.SelectedIndexChanged += new System.EventHandler(this.baudComboBox_SelectedIndexChanged);
            // 
            // disconnectBtn
            // 
            this.disconnectBtn.Enabled = false;
            this.disconnectBtn.Location = new System.Drawing.Point(560, 16);
            this.disconnectBtn.Name = "disconnectBtn";
            this.disconnectBtn.Size = new System.Drawing.Size(94, 73);
            this.disconnectBtn.TabIndex = 12;
            this.disconnectBtn.Text = "Disconnect";
            this.disconnectBtn.UseVisualStyleBackColor = true;
            this.disconnectBtn.Click += new System.EventHandler(this.disconnectBtn_Click);
            // 
            // clearlogBtn
            // 
            this.clearlogBtn.Location = new System.Drawing.Point(130, 154);
            this.clearlogBtn.Name = "clearlogBtn";
            this.clearlogBtn.Size = new System.Drawing.Size(94, 29);
            this.clearlogBtn.TabIndex = 13;
            this.clearlogBtn.Text = "Clear Logs";
            this.clearlogBtn.UseVisualStyleBackColor = true;
            this.clearlogBtn.Click += new System.EventHandler(this.clearlogBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 470);
            this.Controls.Add(this.clearlogBtn);
            this.Controls.Add(this.disconnectBtn);
            this.Controls.Add(this.baudComboBox);
            this.Controls.Add(this.baudLabel);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.serialComboBox);
            this.Controls.Add(this.serialLabel);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.logLabel);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.blinkBtn);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.timeComboBox);
            this.Controls.Add(this.titleLabel);
            this.Name = "MainForm";
            this.Text = "Arduino LED Control App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label titleLabel;
        private ComboBox timeComboBox;
        private Label timeLabel;
        private Button blinkBtn;
        private RichTextBox logTextBox;
        private Label logLabel;
        private Button stopBtn;
        private Label serialLabel;
        private ComboBox serialComboBox;
        private Button connectBtn;
        private Label baudLabel;
        private ComboBox baudComboBox;
        private Button disconnectBtn;
        private Button clearlogBtn;
    }
}