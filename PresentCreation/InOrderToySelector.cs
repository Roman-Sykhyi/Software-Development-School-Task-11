using System;
using System.Collections.Generic;
using System.Text;

namespace Завдання_11
{
    public class InOrderToySelector : ToySelector
    {
        private int _current = 0;

        public InOrderToySelector(List<Toy> toys) : base(toys) { }

        public override Toy GetToy()
        {
            if(_current >= toys.Count)
            {
                _current = 0;
            }

            Toy toy = toys[_current];
            _current++;

            return toy;
        }
    }
}
