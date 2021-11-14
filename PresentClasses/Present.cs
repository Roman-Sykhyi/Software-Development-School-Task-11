using System;

namespace Завдання_11
{
    public class Present
    {
        public Toy Toy { get; set; }
        public Edible Edible { get; set; }
        public string Wish { get; set; }

        public Present() { }

        public Present(Toy toy, Edible edible, string wish)
        {
            Toy = toy ?? throw new ArgumentNullException(nameof(toy));
            Edible = edible ?? throw new ArgumentNullException(nameof(edible));
            
            if(string.IsNullOrWhiteSpace(wish))
                throw new ArgumentNullException(nameof(wish));

            Wish = wish;
        }

        public override string ToString()
        {
            return $"подарунок: іграшка - {Toy.Name}, їстівний подарунок - {Edible.Name}, побажання - {Wish}";
        }
    }
}