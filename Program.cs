using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(2, 8);
            Rectangle r2 = new Rectangle(4, 5);
            Rectangle r3 = r1 + r2;
            Console.WriteLine(r1.getRectangle());
            Console.WriteLine(r2.getRectangle());
            Console.WriteLine(r3.getRectangle());
            Console.ReadKey();
        }
    }
}
