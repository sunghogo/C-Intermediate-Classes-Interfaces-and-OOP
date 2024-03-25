using Amazon;

namespace AccessModifiers2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            //customer.CalculateRating();

            var customer2 = new Amazon.Customer();
            var calculator = new Amazon.RateCalculator();
        }
    }
}
