using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsUSB
{
  static class Program
  {

    static Form1 form1;
    static Form2 form2;
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      form1 = new Form1();
      form2 = new Form2();

      form2.f1 = form1;
      form1.f2 = form2;

      Application.Run(form2);
    }
  }
}
