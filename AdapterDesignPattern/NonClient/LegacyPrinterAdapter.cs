using AdapterDesignPattern.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.NonClient
{
    // Adapter
    internal class LegacyPrinterAdapter : IPrinter
    {
        private readonly LegacyPrinter legacyPrinter;

        public LegacyPrinterAdapter(LegacyPrinter printer)
        {
            legacyPrinter = printer;
        }

        public void Print(string document)
        {
            // Adapt the legacy method to the new interface
            legacyPrinter.PrintLegacyDocument(document);
        }
    }
}
