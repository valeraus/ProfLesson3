using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]
        static void Main()
        {
            StringDictionary dict = new StringDictionary();
            dict["First"] = "1st";
            dict["Second"] = "2nd";
            dict["Third"] = "3rd"; dict["Fourth"] = "4th";
            dict["fourth"] = "fourth";
            string converted = dict["FIRST"];
            Console.WriteLine(converted + " " + dict.Count);
            //Console.ReadKey();
        }
    }
}
