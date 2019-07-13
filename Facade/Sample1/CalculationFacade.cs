namespace Facade.Sample1
{
    public class CalculationFacade
    {
        private BasePremiumCalculation basePremiumCalculation;
        private TaxCalculation taxCalculation;
        private DiscountCalculation discountCalculation;

        public CalculationFacade()
        {
            basePremiumCalculation = new BasePremiumCalculation();
            taxCalculation = new TaxCalculation();
            discountCalculation = new DiscountCalculation();
        }

        public double Calculate(object obj)
        {
            return basePremiumCalculation.CalculatePremium(obj)
                   - discountCalculation.CalculateDiscount(obj)
                   + taxCalculation.CalculateTax(obj);
        }
    }
}