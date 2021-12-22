using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoCurrencyTools
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
            if (File.Exists(Application.StartupPath + "\\nobitex.json"))
            {
                API.Client = Newtonsoft.Json.JsonConvert.DeserializeObject<NobitexAPI.Sharp.NobitexClient>(File.ReadAllText(Application.StartupPath + "\\nobitex.json"));
                Application.Run(new frmMain());
            }
            else
            {
                Application.Run(new Form1());
            }

        }
    }
}
