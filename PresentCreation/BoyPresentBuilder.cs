using System;
using System.Collections.Generic;

namespace Завдання_11
{
    public class BoyPresentBuilder : PresentBuilder
    {
        public BoyPresentBuilder() : base()
        {
            _randomToySelector = new RandomToySelector(SaintNicholas.GetInstance().boyToys);
            _inOrderToySelector = new InOrderToySelector(SaintNicholas.GetInstance().boyToys);

            wishes = SaintNicholas.GetInstance().boyWishes;

            SetToySelector(_inOrderToySelector);
        }
    }
}
