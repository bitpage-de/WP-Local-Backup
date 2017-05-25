using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Local_Backup
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to " + Assembly.GetExecutingAssembly().GetName().Name + " " + Assembly.GetExecutingAssembly().GetName().Version);

            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Make a backup");




            Console.ReadLine();
        }
    }
}
