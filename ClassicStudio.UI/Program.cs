using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassicStudio.UI
{
    public class Program
    {
        public static void Main()
        {
            Application.EnableVisualStyles();
            var x = new frmMain();

            Application.Run(x);
        }
    }
}
