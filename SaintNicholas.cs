using System.Collections.Generic;

namespace Завдання_11
{
    public class SaintNicholas
    {
        public Toy Rod = new Toy("Різка", Gender.Any);
        public string BadChildWish = "Треба бути чемнішим";

        public List<Toy> boyToys = new List<Toy>();
        public List<Toy> girlToys = new List<Toy>();

        public List<Edible> edibleGifts = new List<Edible>();

        public List<string> boyWishes = new List<string>();
        public List<string> girlWishes = new List<string>();

        private PresentCreator _presentCreator;

        private static SaintNicholas _instance;

        private SaintNicholas() 
        {
            boyToys.Add(new Toy("Конструктор", Gender.Male));
            boyToys.Add(new Toy("Машинка", Gender.Male));
            boyToys.Add(new Toy("Робот", Gender.Male));
            boyToys.Add(new Toy("Велосипед", Gender.Male));

            girlToys.Add(new Toy("Лялька", Gender.Female));
            girlToys.Add(new Toy("Косметика", Gender.Female));
            girlToys.Add(new Toy("Ролики", Gender.Female));
            girlToys.Add(new Toy("Набір для малювання", Gender.Female));

            edibleGifts.Add(new Edible("мандарини"));
            edibleGifts.Add(new Edible("шоколадка"));
            edibleGifts.Add(new Edible("цукерки"));

            boyWishes.Add("Рости великий");
            boyWishes.Add("Помагай мамі з татом");
            boyWishes.Add("Ставай розумнішим з кожним днем");

            girlWishes.Add("Будь красунею, завжди щасливою");
            girlWishes.Add("Нехай збуваються всі твої бажання");
            girlWishes.Add("Нехай батьки завжди пишаються твоїми успіхами.");
        }

        public static SaintNicholas GetInstance()
        {
            if(_instance == null)
            {
                _instance = new SaintNicholas();
                _instance._presentCreator = new PresentCreator();
            }

            return _instance;
        }

        public Present GivePresent(Child child)
        { 
            _presentCreator.ConstructPresent(child);

            return _presentCreator.GetPresent();
        }
    }
}