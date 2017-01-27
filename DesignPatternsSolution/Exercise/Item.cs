using System;

namespace Exercise
{
    public abstract class Item : LibObject, IRegistrable
    {
        public Item(int amount, int year)
        {
            AvailableAmount = amount;
            ObjType = ObjectType.Item;
            YearCreated = year;
        }

        public RegisteredObject GetRegistrationInfo()
        {
            return new RegisteredObject
            {
                Id = ObjectId,
                AvailableAmount = AvailableAmount,
                Info = String.Format("{0} ({1})", NameOrTitle ?? ObjType.ToString(), YearCreated)
            };
        }
    }

    public class Book : Item
    {
        public Book(string author, string title, int year, int amount)
            : base(amount, year)
        {
            NameOrTitle = title;
            Author = author;
        }
        public string Author { get; set; }
    }
}
