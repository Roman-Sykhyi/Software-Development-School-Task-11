using System.Collections.Generic;

namespace Завдання_11
{
    public abstract class ToySelector
    {
        protected List<Toy> toys;

        public ToySelector(List<Toy> toys)
        {
            this.toys = toys;
        }

        public abstract Toy GetToy();
    }
}
