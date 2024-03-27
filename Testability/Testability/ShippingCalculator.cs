using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testability
{
    // interface keyword sets up interfaces useful for decoupling objects
    // there are no bodies or acess modifiers for interface fields and methods
    // derived interface classes should have the relevant fields and methods be public
    // can easily extract interfaces from class from Quick Actions + Refactoring/CTRL + . , or Right Click->Refactor->Extract->Extract interface

    public interface IShippingCalculator
    {
        float CalculateShipping(Order order);
    }

    public class ShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            if (order.TotalPrice < 30f)
            {
                return order.TotalPrice * 0.1f;
            }
            return 0;
        }
    }
}
