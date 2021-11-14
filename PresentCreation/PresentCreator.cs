namespace Завдання_11
{
    public class PresentCreator
    {
        private PresentBuilder _presentBuilder;

        private PresentBuilder _boyPresentBuilder = new BoyPresentBuilder();
        private PresentBuilder _girlPresentBuilder = new GirlPresentBuilder();

        public void SetPresentBuilder(PresentBuilder builder)
        {
            _presentBuilder = builder;
        }

        public Present GetPresent()
        {
            return _presentBuilder.GetPresent();
        }

        public void ConstructPresent(Child child)
        {
            if (child.Gender == Gender.Male)
                SetPresentBuilder(_boyPresentBuilder);
            else if (child.Gender == Gender.Female)
                SetPresentBuilder(_girlPresentBuilder);

            _presentBuilder.CreateNewPresent();
            _presentBuilder.SetToy(child);
            _presentBuilder.SetEdible(child);
            _presentBuilder.SetWish(child);
        }
    }
}