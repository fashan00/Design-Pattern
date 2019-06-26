using Command_Pattern.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern.Commands
{
    public class BuyStockOrder : IOrder
    {
        private Stock stock;

        public BuyStockOrder(Stock stock)
        {
            this.stock = stock;
        }

        public void Execute()
        {
            stock.Buy();
        }
    }
}
