using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testability
{
    public class OrderProcessor
    {
        private readonly IShippingCalculator _shippingCalcluator;

        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            //_shippingCalcluator = new ShippingCalculator();
            _shippingCalcluator = shippingCalculator;
        }

        public void Process(Order order)
        {
            if (order.IsShipped)
            {
                throw new InvalidOperationException("This order is already processed");
            }

            order.Shipment = new Shipment
            {
                Cost = _shippingCalcluator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
        }
    }
}
