using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.Sample2
{
    public class FinancialSystem
    {
        private readonly IList<IElement> _elements;

        public FinancialSystem()
        {
            _elements = new List<IElement>();
        }

        public void Attach(IElement element)
        {
            _elements.Add(element);
        }

        public void Detach(IElement element)
        {
            _elements.Remove(element);
        }

        public void Accept(IElementVisitor visitor)
        {
            foreach (var element in _elements)
            {
                element.Accept(visitor);
            }
        }
    }
}
