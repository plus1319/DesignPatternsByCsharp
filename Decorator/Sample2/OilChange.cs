namespace Decorator.Sample2
{
    public class OilChange : ICarService
    {
        protected ICarService carService;

        public OilChange(ICarService carService)
        {
            this.carService = carService;
        }

        public int GetService()
        {
            return 29 + carService.GetService();
        }
    }
}