using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Memento.Sample3
{
    public class BankAccount2
    {
        private int _blance;
        private List<BankMemento2> changes = new List<BankMemento2>();
        private int _current;
        public BankAccount2(int blance)
        {
            _blance = blance;
            changes.Add(new BankMemento2(blance));
        }

        public BankMemento2 Deposit(int amount)
        {
            _blance += amount;
            var m = new BankMemento2(_blance);
            changes.Add(m);
            ++_current;
            return m;
        }

        public BankMemento2 Restore(BankMemento2 m)
        {
            if (m != null)
            {
                _blance = m.Blance;
                changes.Add(m);
            }
            return null;
        }
        public BankMemento2 Undo()
        {
            if (_current > 0)
            {
                var m = changes[--_current];
                _blance = m.Blance;
                return m;
            }
            return null;
        }
        public BankMemento2 Redo()
        {
            if (_current + 1 < changes.Count)
            {
                var m = changes[++_current];
                _blance = m.Blance;
                return m;
            }
            return null;
        }

        public override string ToString()
        {
            return $"{nameof(_blance)}:{_blance}";
        }
    }
}
