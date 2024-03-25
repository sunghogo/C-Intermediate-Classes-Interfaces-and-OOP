using System.Collections;

namespace Boxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ArrayList is not type safe
            // All these added values get boxed first
            var list = new ArrayList();
            list.Add(1);
            list.Add("Mosh");
            list.Add(DateTime.Today);

            // Unboxing happens
            var name = list[2];

            // Generic List with type safety
            var anotherList = new List<int>();
            var names = new List<string>();
            names.Add("Mosh");

            // Boxing
            int number = 10;
            object obj = number;

            // Unboxing
            number = (int)obj;
        }
    }
}
