using Command_Pattern.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern.Commands
{
    public class SellStockOrder : IOrder
    {
        private Stock stock;

        public SellStockOrder(Stock stock)
        {
            this.stock = stock;
        }

        public void Execute()
        {
            stock.Sell();
        }
    }
}
