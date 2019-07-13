namespace Decorator.Sample2
{
    public class TireRotation : ICarService
    {
        protected ICarService carService;

        public TireRotation(ICarService carService)
        {
            this.carService = carService;
        }

        public int GetService()
        {
            return 15 + carService.GetService();
        }
    }
}