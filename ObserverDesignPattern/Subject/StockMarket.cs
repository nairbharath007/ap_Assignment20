using ObserverDesignPattern.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern.Subject
{
    // Concrete Subject
    internal class StockMarket : IStockMarket
    {
        private List<Investor> investors = new List<Investor>();
        private decimal stockPrice;

        public decimal StockPrice
        {
            get { return stockPrice; }
            set
            {
                stockPrice = value;
                Notify();
            }
        }

        public void Subscribe(Investor investor)
        {
            investors.Add(investor);
        }

        public void Unsubscribe(Investor investor)
        {
            investors.Remove(investor);
        }

        public void Notify()
        {
            foreach (var investor in investors)
            {
                investor.Update();
            }
        }
    }
}
