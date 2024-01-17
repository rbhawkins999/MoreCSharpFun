using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreCSharpFun
{
    internal class PrintStuff
    {
        private string language;

        //Constructor
        public PrintStuff()
        {
            language = "English";
        }
        public PrintStuff(string temp)
        {
            language = temp;
        }
        public void PrintName(string n)
        {
            if (language == "English")
            {
                System.Console.WriteLine("Hello " + n + "!");
            }

            if (language == "PT")
            {
                System.Console.WriteLine("Oi, " + n + "!");
            }
        }
    }
}
