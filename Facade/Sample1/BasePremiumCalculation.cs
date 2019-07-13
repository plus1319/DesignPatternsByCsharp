using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Sample1
{
    public class BasePremiumCalculation
    {
        public double CalculatePremium(Object obj)
        {
            return 0d;
        }
    }
    public class TaxCalculation
    {
        public double CalculateTax(Object obj)
        {
            return 0d;
        }
    }
    public class DiscountCalculation
    {
        public double CalculateDiscount(Object obj)
        {
            return 0d;
        }
    }
}
