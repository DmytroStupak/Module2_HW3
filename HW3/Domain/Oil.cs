namespace Module2_HW3
{
    public abstract class Oil : Vegetable
    {
        public Oil(string name, double calories, double weight)
            : base(name, calories, weight)
        {
            Category = "Oil";
        }

        public Oil(string name, double calories)
            : base(name, calories)
        {
            Category = "Oil";
        }
    }
}
