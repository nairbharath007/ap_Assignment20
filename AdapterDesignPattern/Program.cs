using AdapterDesignPattern.Client;
using AdapterDesignPattern.NonClient;
using System.Reflection;

namespace AdapterDesignPattern
{
    // Client Code (Modern Computer)
    internal class Program
    {
        static void Main(string[] args)
        {
            // Modern computer expects an IPrinter interface
            IPrinter computerPrinter = new LegacyPrinterAdapter(new LegacyPrinter());

            // Print a document using the modern computer
            computerPrinter.Print("Adapter Pattern Example Document");
        }
    }
}