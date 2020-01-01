using System;

namespace Memento.Sample1
{
    public abstract class MementoBase
    {
        //careTaker state
        protected Guid mementoKey = Guid.NewGuid();
        public abstract void SaveMemento(Memento memento);
        public abstract void RestoreMemento(Memento memento);
    }
    class ConcreteOriginator : MementoBase
    {
        private int _value = 0;
        public ConcreteOriginator(int newValue)
        {
            SetData(newValue);
        }
        public void SetData(int newValue)
        {
            _value = newValue;
        }
        public void Speak()
        {
            Console.WriteLine("My value is " + _value.ToString());
        }
        public override void SaveMemento(Memento memento)
        {
            memento.SetState(mementoKey, _value);
        }
        public override void RestoreMemento(Memento memento)
        {
            int restoredValue = (int)memento.GetState(mementoKey);
            SetData(restoredValue);
        }
    }
}