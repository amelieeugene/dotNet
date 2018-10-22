using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace WindowsFormsUSB
{
  

  public partial class Form1 : Form
  {
    private string StatusText;

    public Form2 f2;

    public Form1()
    {
      InitializeComponent();
    }


    private void Form1_Load(object sender, EventArgs e)
    {
      string[] ports = SerialPort.GetPortNames();

      foreach (string port in ports)
      {
        cboPort.Items.Add(port);
      }

      cboSpeed.SelectedIndex = 11;
    }

    private void BtnConnect_Click(object sender, EventArgs e)
    {
      if (cboPort.Text.Trim().Length == 0)
      {
        MessageBox.Show("Select a port!", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      if (cboSpeed.Text.Trim().Length == 0)
      {
        MessageBox.Show("Select a speed!", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      //SerialPort sp1 = new SerialPort();
      serialPort1.PortName = cboPort.Text;
      serialPort1.BaudRate = Convert.ToInt32(cboSpeed.Text);
      serialPort1.Open();

      EnableDisableButtons();
    }

    private void EnableDisableButtons()
    {      
          btnConnect.Enabled = !serialPort1.IsOpen;
          btnDisconnect.Enabled = serialPort1.IsOpen;
    }

    private void WriteStatusLine(string text)
    {
      txtStatus.AppendText(string.Format("{0}\r\n", text));
    }

    private void DisplayThreadText(object sender, EventArgs e)
    {
      WriteStatusLine(StatusText);
    }

    private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
    {
      StatusText = serialPort1.ReadExisting();
      Invoke(new EventHandler(DisplayThreadText));
    }

    private void btnSend_Click(object sender, EventArgs e)
    {
      if (serialPort1.IsOpen && txtDataSend.Text.Length > 0)
      {
        serialPort1.WriteLine(txtDataSend.Text);
      }
    }

    private void btnDisconnect_Click(object sender, EventArgs e)
    {
      if (serialPort1.IsOpen)
        serialPort1.Close();

      EnableDisableButtons();
    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
      f2.Show();
    }
  }
}
