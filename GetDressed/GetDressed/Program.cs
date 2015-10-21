using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetDressed
{
    public partial class clothes
    {
        public string Season { get; set; }
        public string Type 
        {   get;

            set 
            {
                string[] nSeasons =new string[] {"spring","summer", "autumn", "winter" };
                if (nSeasons.Contains(value))
                {
                    Type = value;
                }
                else 
                {
                    Type = "spring"; //better fix later
                }
            }
        }

        public double HeatValue { get; set; }

        public clothes(string season, string type, double heat)
        {
            Season = season;
            Type = type;
            HeatValue = heat; 
        }

    }
    
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
            Application.Run(new Form1());
        }
    }
}
