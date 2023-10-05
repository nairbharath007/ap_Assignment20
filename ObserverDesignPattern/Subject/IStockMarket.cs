using ObserverDesignPattern.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern.Subject
{
    // Subject interface
    internal interface IStockMarket
    {
        void Subscribe(Investor investor);
        void Unsubscribe(Investor investor);
        void Notify();
    }
}
