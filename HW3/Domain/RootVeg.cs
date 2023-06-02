namespace Module2_HW3
{
    public abstract class RootVeg : Vegetable
    {
        public RootVeg(string name, double calories, double weight)
            : base(name, calories, weight)
        {
            Category = "Root Vegetable";
        }

        public RootVeg(string name, double calories)
            : base(name, calories)
        {
            Category = "Root Vegetable";
        }
    }
}
