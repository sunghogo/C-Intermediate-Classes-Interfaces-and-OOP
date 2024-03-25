using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon
{
    // internal access means Amazon.Customer can access this but everything in AccessModifiers2 Assembly can't
    public class RateCalculator
    {
        public int Calculate(Customer customer)
        {
            return 0;
        }
    }
}
