using System;
using Memento.Sample1;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample1.Memento memento = new Sample1.Memento();
            // Create an originator, which will hold our state data.
            ConcreteOriginator myOriginator = new ConcreteOriginator("Hello World!", StateType.ONE);
            ConcreteOriginator anotherOriginator = new ConcreteOriginator("Hola!", StateType.ONE);
            ConcreteOriginator thirdOriginator = new ConcreteOriginator(7);
            // Set some state data.
            myOriginator.Speak();
            anotherOriginator.Speak();
            thirdOriginator.Speak();
            // Save the states into our memento.
            myOriginator.SaveMemento(memento);
            anotherOriginator.SaveMemento(memento);
            thirdOriginator.SaveMemento(memento);
            // Now change our originators' states.
            myOriginator.SetData("Goodbye!", StateType.TWO);
            anotherOriginator.SetData("Adios!", StateType.TWO);
            thirdOriginator.SetData(99);
            myOriginator.Speak();
            anotherOriginator.Speak();
            thirdOriginator.Speak();
            // Restore our originator's state.
            myOriginator.RestoreMemento(memento);
            anotherOriginator.RestoreMemento(memento);
            thirdOriginator.RestoreMemento(memento);
            myOriginator.Speak();
            anotherOriginator.Speak();
            thirdOriginator.Speak();
            Console.ReadKey();
        }
    }
}
