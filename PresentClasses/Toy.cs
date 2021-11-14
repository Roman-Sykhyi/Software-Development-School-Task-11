using System;

namespace Завдання_11
{
    public class Toy
    {
        public string Name { get; private set; }
        public Gender ForGender { get; private set; }

        public Toy(string name, Gender gender)
        {
            if(string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("Name of Toy cannot be null or empty", nameof(name));

            Name = name; 
            ForGender = gender;
        }
    }
}
