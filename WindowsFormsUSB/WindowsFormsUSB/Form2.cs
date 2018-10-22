using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsUSB
{
  public partial class Form2 : Form
  {

    public Form1 f1;

    public Form2()
    {
      InitializeComponent();
    }

    private void Form2_Load(object sender, EventArgs e)
    {
      // TODO: This line of code loads data into the 'sandboxDataSet.customer' table. You can move, or remove it, as needed.
      this.customerTableAdapter.Fill(this.sandboxDataSet.customer);

    }

    private void btnShowForm1_Click(object sender, EventArgs e)
    {
      f1.Show();
      this.Hide();
    }
  }
}
