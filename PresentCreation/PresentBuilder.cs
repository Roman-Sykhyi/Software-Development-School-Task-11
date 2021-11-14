using System.Collections.Generic;

namespace Завдання_11
{
    public abstract class PresentBuilder
    {
        protected Present present;
        protected ToySelector toySelector;

        protected ToySelector _randomToySelector;
        protected ToySelector _inOrderToySelector;

        protected List<string> wishes;

        public void CreateNewPresent() { present = new Present(); }
        public Present GetPresent() { return present; }
            
        public virtual void SetToy(Child child)
        {
            if(child.IsNaughty)
            {
                present.Toy = SaintNicholas.GetInstance().Rod;
            }
            else
            {
                present.Toy = toySelector.GetToy();
            }
        }
        public virtual void SetEdible(Child child)
        {
            System.Random random = new System.Random();

            List<Edible> edibleGifts = SaintNicholas.GetInstance().edibleGifts;
            present.Edible = edibleGifts[random.Next(edibleGifts.Count)];
        }
        public virtual void SetWish(Child child) 
        {
            if (child.IsNaughty)
            {
                present.Wish = SaintNicholas.GetInstance().BadChildWish;
            }
            else
            {
                System.Random random = new System.Random();
                present.Wish = wishes[random.Next(wishes.Count)];
            }
        }

        protected void SetToySelector(ToySelector selector) { toySelector = selector; }
    }
}