using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTask5
{
    internal class Printer
    {
        public virtual ConsoleColor TextColor { get {return ConsoleColor.Gray;} }

        public void Print(string value)
        {
            Console.ForegroundColor = this.TextColor;
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
