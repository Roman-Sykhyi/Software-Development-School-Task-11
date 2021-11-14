using System;

namespace Завдання_11
{
    public class Child
    {
        public string Name { get; private set; }

        public Gender Gender { get; private set; }

        public int GoodDeeds { get; private set; }
        public int BadDeeds { get; private set; }

        public bool IsNaughty => BadDeeds > GoodDeeds;

        public Present Present { get; private set; }

        public Child(string name, Gender gender, int goodDeeds, int badDeeds)
        {
            if(string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("Name of Child cannot be null or empty", nameof(name));

            if (goodDeeds < 0 || badDeeds < 0)
                throw new ArgumentException("Number of deeds cannot be less than zero");

            Name = name;
            Gender = gender;
            GoodDeeds = goodDeeds;
            BadDeeds = badDeeds;

            Present = SaintNicholas.GetInstance().GivePresent(this);
        }
    }
}
