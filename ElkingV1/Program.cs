using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElkingV1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Startup());
        }
    }

    public abstract class PublicVariables
    {
        public const string ConnectionString = "Data Source=.;Initial Catalog=ElkingDB;Integrated Security=True";
        public static DataTable SupplierTable;
        public static DataTable CustomerTable;
    }
}
