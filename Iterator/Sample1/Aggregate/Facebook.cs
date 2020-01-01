using System;
using System.Collections.Generic;
using System.Text;
using Iterator.Sample1.Iterator;

namespace Iterator.Sample1.Aggregate
{
    public class Facebook : ISocialNetworking
    {
        private LinkedList<string> Users;

        public Facebook()
        {
            Users = new LinkedList<string>();
            Users.AddLast("Mike");
            Users.AddLast("John");
            Users.AddLast("Edward");
            Users.AddLast("San");
            Users.AddLast("Stave");
        }

        public IIterator CreateIterator()
        {
            return new FacebookIterator(Users);
        }
    }
}
