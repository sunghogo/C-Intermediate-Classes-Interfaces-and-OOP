using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers2
{
    public class GoldCustomer : Customer
    {
        public void OfferVoucher()
        {
            // this creates coupling from Customer.CalculateRating()
            var rating = this.CalculateRating(excludeOrders: true);
        }
    }
}
