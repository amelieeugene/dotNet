namespace WindowsFormsUSB
{
  partial class Form1
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
      this.btnConnect = new System.Windows.Forms.Button();
      this.cboSpeed = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.cboPort = new System.Windows.Forms.ComboBox();
      this.btnDisconnect = new System.Windows.Forms.Button();
      this.txtDataSend = new System.Windows.Forms.TextBox();
      this.txtStatus = new System.Windows.Forms.TextBox();
      this.btnSend = new System.Windows.Forms.Button();
      this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
      this.SuspendLayout();
      // 
      // btnConnect
      // 
      this.btnConnect.Location = new System.Drawing.Point(427, 41);
      this.btnConnect.Name = "btnConnect";
      this.btnConnect.Size = new System.Drawing.Size(75, 23);
      this.btnConnect.TabIndex = 0;
      this.btnConnect.Text = "Connect";
      this.btnConnect.UseVisualStyleBackColor = true;
      this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
      // 
      // cboSpeed
      // 
      this.cboSpeed.FormattingEnabled = true;
      this.cboSpeed.Items.AddRange(new object[] {
            "75",
            "110",
            "134",
            "150",
            "300",
            "600",
            "1200",
            "1800",
            "2400",
            "4800",
            "7200",
            "9600",
            "19200",
            "38400",
            "67600",
            "115200",
            "128000"});
      this.cboSpeed.Location = new System.Drawing.Point(271, 43);
      this.cboSpeed.Name = "cboSpeed";
      this.cboSpeed.Size = new System.Drawing.Size(121, 21);
      this.cboSpeed.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(227, 46);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(38, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Speed";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(30, 46);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(26, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Port";
      // 
      // cboPort
      // 
      this.cboPort.FormattingEnabled = true;
      this.cboPort.Location = new System.Drawing.Point(62, 43);
      this.cboPort.Name = "cboPort";
      this.cboPort.Size = new System.Drawing.Size(121, 21);
      this.cboPort.TabIndex = 4;
      // 
      // btnDisconnect
      // 
      this.btnDisconnect.Enabled = false;
      this.btnDisconnect.Location = new System.Drawing.Point(508, 41);
      this.btnDisconnect.Name = "btnDisconnect";
      this.btnDisconnect.Size = new System.Drawing.Size(90, 23);
      this.btnDisconnect.TabIndex = 5;
      this.btnDisconnect.Text = "Disconnect";
      this.btnDisconnect.UseVisualStyleBackColor = true;
      this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
      // 
      // txtDataSend
      // 
      this.txtDataSend.Location = new System.Drawing.Point(33, 70);
      this.txtDataSend.Multiline = true;
      this.txtDataSend.Name = "txtDataSend";
      this.txtDataSend.Size = new System.Drawing.Size(565, 247);
      this.txtDataSend.TabIndex = 6;
      // 
      // txtStatus
      // 
      this.txtStatus.Location = new System.Drawing.Point(33, 337);
      this.txtStatus.Name = "txtStatus";
      this.txtStatus.Size = new System.Drawing.Size(447, 20);
      this.txtStatus.TabIndex = 7;
      // 
      // btnSend
      // 
      this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSend.Location = new System.Drawing.Point(503, 334);
      this.btnSend.Name = "btnSend";
      this.btnSend.Size = new System.Drawing.Size(95, 23);
      this.btnSend.TabIndex = 8;
      this.btnSend.Text = "Send";
      this.btnSend.UseVisualStyleBackColor = true;
      this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
      // 
      // serialPort1
      // 
      this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(616, 376);
      this.Controls.Add(this.btnSend);
      this.Controls.Add(this.txtStatus);
      this.Controls.Add(this.txtDataSend);
      this.Controls.Add(this.btnDisconnect);
      this.Controls.Add(this.cboPort);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.cboSpeed);
      this.Controls.Add(this.btnConnect);
      this.Name = "Form1";
      this.Text = "Serial Connect";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnConnect;
    private System.Windows.Forms.ComboBox cboSpeed;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox cboPort;
    private System.Windows.Forms.Button btnDisconnect;
    private System.Windows.Forms.TextBox txtDataSend;
    private System.Windows.Forms.TextBox txtStatus;
    private System.Windows.Forms.Button btnSend;
    private System.IO.Ports.SerialPort serialPort1;
  }
}

