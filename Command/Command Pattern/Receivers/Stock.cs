using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern.Receivers
{
    public class Stock
    {
        private String name = "Stock";
        private int quantity = 10;

        public void Buy()
        {
            Console.WriteLine($"Stock [ Name: {name} Quantity: {quantity} ] bought");
        }
        public void Sell()
        {
            Console.WriteLine($"Stock [ Name: {name} Quantity: {quantity} ] sold");
        }
    }
}
