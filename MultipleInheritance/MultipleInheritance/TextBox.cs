namespace MultipleInheritance
{
    internal partial class Program
    {
        // Cannot have multiple inheritances/parent classes in C#, but can have multiple interfaces
        // Interfaces do NOT implement multiple inheritance, but instead forces class adherence to interface methods
        // Interfaces used for loosely coupled, extensible (polymorphic), testable code, NOT code reusability
        public class TextBox : UiControl, IDraggable, IDroppable
        {
            public void Drag()
            {
                throw new NotImplementedException();
            }

            public void Drop()
            {
                throw new NotImplementedException();
            }
        }
    }
}
