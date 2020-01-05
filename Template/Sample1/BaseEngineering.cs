using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Template.Sample1
{
    //Template
    public abstract class BaseEngineering
    {
        public void Study()
        {
            //Should do 
            Math();
            Physic();
            //maybe you need more 
            AdditionalStudy();
        }

        public abstract void AdditionalStudy();

        private void Physic()
        {
            Console.WriteLine("Physic");
        }

        private void Math()
        {
            Console.WriteLine("Math");
        }
    }
}
