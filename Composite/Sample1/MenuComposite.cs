namespace Composite.Sample1
{
    public abstract class MenuComposite
    {
        private string _name;

        protected MenuComposite(string name)
        {
            _name = name;
        }

        public abstract MenuComposite Add(MenuComposite menuComposite);
        public abstract MenuComposite Remove(MenuComposite menuComposite);

        protected string Print()
        {
            return string.Format($"{_name} \n");
        }
        public abstract override string ToString();
        
    }
}
