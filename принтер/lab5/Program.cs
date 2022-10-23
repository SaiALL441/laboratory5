using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class Printer
    {
        public virtual void Print (string value)
        {
            Console.WriteLine(value);
        }
    }

    public class Detail:Printer
    {
        public override void Print (string value)
        {
            var color = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(value.GetType());
        }
    }
    class Program
    {
        static void Main()
        {
            Printer det = new Detail();
            det.Print(" ... ");
        }
    }
}
