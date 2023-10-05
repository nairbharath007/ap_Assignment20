using ObserverDesignPattern.Observer;
using ObserverDesignPattern.Subject;

namespace ObserverDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StockMarket stockMarket = new StockMarket();
            Investor investor1 = new Investor("Name1", stockMarket);
            Investor investor2 = new Investor("Name2", stockMarket);

            stockMarket.Subscribe(investor1);
            stockMarket.Subscribe(investor2);

            stockMarket.StockPrice = 100.50m; // Notify both investors about the stock price change.

            Console.WriteLine("-------------------------------------------------------------------");

            stockMarket.Unsubscribe(investor1);

            stockMarket.StockPrice = 105.75m; // Only investor2 should receive this update.

            
        }
    }
}