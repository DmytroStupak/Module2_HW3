namespace Module2_HW3
{
    public abstract class OliveOil : Oil
    {
        public OliveOil(string name, double calories, double weight)
            : base(name, calories, weight)
        {
        }

        public OliveOil(string name, double calories)
            : base(name, calories)
        {
        }
    }
}