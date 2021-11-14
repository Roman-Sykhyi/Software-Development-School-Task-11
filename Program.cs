using System;
using System.Collections.Generic;

namespace Завдання_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<Child> children = new List<Child>();

            children.Add(new Child("Саша", Gender.Male, 6, 2));
            children.Add(new Child("Артем", Gender.Male, 1, 2));
            children.Add(new Child("Влад", Gender.Male, 3, 0));
            children.Add(new Child("Міша", Gender.Male, 2, 1));

            children.Add(new Child("Аня", Gender.Female, 3, 1));
            children.Add(new Child("Діана", Gender.Female, 2, 2));
            children.Add(new Child("Віка", Gender.Female, 1, 2));
            children.Add(new Child("Катя", Gender.Female, 4, 3));

            foreach(Child child in children)
            {
                Console.WriteLine(child.Name + " отримав(-ла) " + child.Present);
            }
        }
    }
}
