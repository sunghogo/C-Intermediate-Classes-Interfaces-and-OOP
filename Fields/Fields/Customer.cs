using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fields
{
    public class Customer
    {
        public int Id;
        public string Name = "";

        // Can initialize fields directly without constructor
        // readonly keyworld initializes the field only once during initialization/construction
        public readonly List<Order> Orders = new List<Order>();

        public Customer()
        {
            // Can initialize fields here but would need to call the default constructor in all other constructors
            //Orders = new List<Order>();
        }

        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            // Causes compilation error with readonly
            //Orders = new List<Order>();
        }
    }
}
