using Command_Pattern.Commands;
using Command_Pattern.Invokers;
using Command_Pattern.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock();

            BuyStockOrder buyStockOrder = new BuyStockOrder(stock);
            SellStockOrder sellStockOrder = new SellStockOrder(stock);

            Broker broker = new Broker();
            broker.TakeOrder(buyStockOrder);
            broker.TakeOrder(sellStockOrder);

            broker.PlaceOrders();

            Console.ReadLine();
        }
    }
}
