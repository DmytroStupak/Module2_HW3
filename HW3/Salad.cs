﻿namespace Module2_HW3
{
    public class Salad
    {
        private Vegetable[] _salad = new Vegetable[1];
        private int _countIngr = 0;

        public void MakeSalad()
        {
            AddIngredients((Vegetable)new RedCarrot(110));
            AddIngredients((Vegetable)new Cucumber(200));
            AddIngredients((Vegetable)new Potato(500));
            AddIngredients((Vegetable)new ExtraVirginOil(50));
            AddIngredients((Vegetable)new CherryTomato(130));
            AddIngredients((Vegetable)new Onion(30));
            AddIngredients((Vegetable)new GreenTomato(140));
        }

        public Vegetable[] GetSalad()
        {
            return _salad;
        }

        public void AddIngredients(Vegetable vegetable)
        {
            if (_countIngr + 1 >= _salad.Length)
            {
                Array.Resize(ref _salad, _countIngr + 1);
            }

            _salad[_countIngr] = vegetable;
            _countIngr++;
        }

        public double GetCalories()
        {
            double res = 0;

            foreach (var item in _salad)
            {
                res += item.Calories / 100 * item.Weight;
            }

            return res;
        }
    }
}
