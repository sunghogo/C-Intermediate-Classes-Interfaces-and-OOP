using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        // Default paramter-less constructor
        // Use 'ctor' code snipper
        public Customer()
        {
            Orders = new List<Order>();
        }

        // Overloaded constructors
        // : this() will call the default constructor first
        public Customer(int id)
            : this()
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }
    }
}
