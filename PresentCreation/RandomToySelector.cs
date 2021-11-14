using System;
using System.Collections.Generic;

namespace Завдання_11
{
    public class RandomToySelector : ToySelector
    {
        private Random _random = new Random();

        public RandomToySelector(List<Toy> toys) : base(toys) { }

        public override Toy GetToy()
        {
            return toys[_random.Next(0, toys.Count)];
        }
    }
}
