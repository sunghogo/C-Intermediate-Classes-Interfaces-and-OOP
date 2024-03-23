namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();

            // Protected because private keyword
            //person._birthDate = new DateTime();

            // Using Setter/Getting methods to access private fields
            person.SetBirthDate(new DateTime(1982, 1, 1));
            Console.WriteLine(person.GetBirthDate());
        }
    }
}
