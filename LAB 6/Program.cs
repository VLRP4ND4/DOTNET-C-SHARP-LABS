using System;
using System.Windows.Forms;

namespace LAB_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();  
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
