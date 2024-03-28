namespace MultipleInheritance
{
    internal partial class Program
    {
        public class UiControl
        {
            public string Id { get; set; }
            public Size Size { get; set; }
            public Position Position { get; set; }

            public UiControl()
            {
                Id = "";
                Size = new Size();
                Position = new Position();  
            }

            public virtual void Draw()
            { }
            }

            public void Focus()
            {
                Console.WriteLine("Received focus.");
            }
        }
    }
}
