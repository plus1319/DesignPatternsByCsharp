using System;
using System.Collections.Generic;
using System.Text;
using Iterator.Sample1.Iterator;

namespace Iterator.Sample1.Aggregate
{
    public class Twitter : ISocialNetworking
    {
        private string[] Users;

        public Twitter()
        {
            Users = new[] {"Katy", "Lori", "Kristen", "Jamie"};
        }

        public IIterator CreateIterator()
        {
           return new TwitterIterator(Users);
        }
    }
}
