namespace Fields
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1);

            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            Console.WriteLine(customer.Orders.Count);

            // With readonly field, cannot reinitialize field
            customer.Promote();
            Console.WriteLine(customer.Orders.Count);
        }
    }
}
