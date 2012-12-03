using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BoekenApplicatie
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Eerst inlezen
            DatabaseFiller df = new DatabaseFiller();
            bool f = df.fillBoeken(@"C:\Users\Adriaan\Downloads\Tekstbestanden\boeken.txt");
            df.log("Geslaagd: " + f);
            //df.log("9000/1000: " + 9000 / 1000);
            //df.log("9001/1000: " + 9001 / 1000);
            //Console.WriteLine("Geslaagd: " + f);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
