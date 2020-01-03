namespace Memento.Sample2
{
    public class BankMemento
    {
        public BankMemento(int blance)
        {
            Blance = blance;
        }

        public int Blance { get; }
    }
}