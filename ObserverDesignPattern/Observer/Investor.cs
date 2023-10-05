using ObserverDesignPattern.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern.Observer
{
    // Concrete Observers (Investors)

    internal class Investor
    {
        private string name;
        private StockMarket stockMarket;

        public Investor(string name, StockMarket stockMarket)
        {
            this.name = name;
            this.stockMarket = stockMarket;
        }

        public void Update()
        {
            Console.WriteLine($"Investor {name} received an update. New stock price: {stockMarket.StockPrice:C}");
        }
    }
}
