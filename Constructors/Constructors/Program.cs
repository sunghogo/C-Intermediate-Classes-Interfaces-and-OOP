namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1, "John");

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

            // Object Initialization, will call the default constructor then intiialize with values
            var customer2 = new Customer { Id = 1, Name = "John" };
        }
    }
}
