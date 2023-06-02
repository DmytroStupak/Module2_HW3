namespace Module2_HW3
{
    public abstract class Tomato : NightShVeg
    {
        public Tomato(string name, double calories, double weight)
            : base(name, calories, weight)
        {
        }

        public Tomato(string name, double calories)
            : base(name, calories)
        {
        }
    }
}
