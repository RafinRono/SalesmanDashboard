using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectFinal
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            User u1 = new User("S-001", "Salesman", "1234", "01234567890", "salesman@gmail.com", "Kuril, Dhaka", "Salesman");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormDashboardSalesPerson(u1));
        }
    }
}
