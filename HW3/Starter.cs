namespace Module2_HW3
{
    public class Starter
    {
        public static void Run()
        {
            Salad salad = new Salad();
            salad.MakeSalad();
            Array.Sort(salad.GetSalad(), new CaloriesCompare());

            Console.WriteLine("Sort by Calories:");
            Console.WriteLine();
            foreach (var item in salad.GetSalad())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine($"Total calories : {salad.GetCalories()}kcal");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Find ingr 10-100kcal in salad :");
            Console.WriteLine();

            foreach (var item in salad.GetSalad().FindByCalories(10, 100))
            {
                Console.WriteLine(item);
            }
        }
    }
}