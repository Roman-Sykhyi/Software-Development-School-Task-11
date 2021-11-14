using System;
using System.Collections.Generic;

namespace Завдання_11
{
    public class GirlPresentBuilder : PresentBuilder
    {
        public GirlPresentBuilder() : base()
        {
            _randomToySelector = new RandomToySelector(SaintNicholas.GetInstance().girlToys);
            _inOrderToySelector = new InOrderToySelector(SaintNicholas.GetInstance().girlToys);

            wishes = SaintNicholas.GetInstance().girlWishes;

            SetToySelector(_inOrderToySelector);
        }

        public override void SetWish(Child child)
        {
            if (child.IsNaughty)
            {
                present.Wish = SaintNicholas.GetInstance().BadChildWish;
            }
            else
            {
                System.Random random = new System.Random();

                List<string> wishes = SaintNicholas.GetInstance().girlWishes;
                present.Wish = wishes[random.Next(wishes.Count)];
            }
        }
    }
}