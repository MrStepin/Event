using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Event
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassInstance monitoring = new ClassInstance();

            string path = @"C:\TEST";
            monitoring.Monitoring(path);

            Console.ReadKey();
        }
    }
}
