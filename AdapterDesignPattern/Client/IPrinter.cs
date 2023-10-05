using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.Client
{
    // Target Interface
    internal interface IPrinter
    {
        void Print(string document);
    }
}
