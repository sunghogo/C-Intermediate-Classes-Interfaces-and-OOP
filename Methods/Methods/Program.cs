namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int.Parse() throws an exception
            try
            {
                var number1 = int.Parse("abc");
            }
            catch (Exception)
            {
                Console.WriteLine("Conversion failed.");
            }

            // int.TryParse() doesn't throw exception since returns bool by using out keyword to store result into out parameter
            int number2;
            var result = int.TryParse("abc", out number2);
            if (result)
            {
                Console.WriteLine(number2);
            }
            else
            {
                Console.WriteLine("Conversion failed.");
            }
        }

        static void UseParams()
        {
            var calculator = new Calculator();

            // Calling params methods
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5 }));
        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);

                // Calling overloaded methods
                point.Move(new Point(40, 60));
                Console.WriteLine($"Point is at {point.X} {point.Y}");

                point.Move(100, 200);
                Console.WriteLine($"Point is at {point.X} {point.Y}");
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occured.");
            }
        }
    }
}
