using System;

namespace Завдання_11
{
    public class Edible
    {
        public string Name { get; private set; }

        public Edible(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("Name of Edible cannot be null or empty", nameof(name));

            Name = name;
        }
    }
}
