using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.NonClient
{
    internal class LegacyPrinter
    {
        // Existing Device (Adaptee)
        public void PrintLegacyDocument(string document)
        {
            Console.WriteLine("Legacy Printer is printing: " + document);
        }
    }
}
