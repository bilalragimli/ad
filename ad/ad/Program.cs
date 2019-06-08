using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ad
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("Zehmet olmasa adinizi daxil edin");
            //    string a = Console.ReadLine();
            //    Console.WriteLine("Zehmet olmasa yashinizi daxil edin");
            //    string b = Console.ReadLine();
            //    if(a=="Admin" && b == "12345")
            //    {
            //        Console.WriteLine("Xosh gelmisen Admin");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Bele bir admin yoxdur");
            //    }
            //}

            Student telebe1 = new Student();
            telebe1.name = "Bilal";

            Student telebe2 = new Student();
            telebe2.name = "Cavid";

            telebe1.setPassword("bilal123");
            Console.WriteLine(telebe1.getPassword(Console.ReadLine()));
        }
    }
}
