using System.Net;

namespace Exercise
{
    public abstract class Item : LibObject
    {
        public Item(int amount, int year)
        {
            AvailableAmount = amount;
            ObjType = ObjectType.Item;
            YearCreated = year;
        }

        
    }

    public class Book : Item
    {
        public Book(string author, string title, int year, int amount) : base(amount, year)
        {
            NameOrTitle = title;
            Author = author;
        }
        public string Author { get; set; }

        public override RegisteredObject GetRegistrationInfo()
        {
            return new RegisteredObject()
            {
                AvailableAmount = AvailableAmount,
                Id = -1,
                Info = NameOrTitle
            };
        }
    }

    public class Video : Item
    {
        public Video(string director, string title, int year, int amount) : base(amount, year)
        {
            NameOrTitle = title;
            Director = director;
        }
        public string Director { get; set; }

        public override RegisteredObject GetRegistrationInfo()
        {
            return new RegisteredObject()
            {
                AvailableAmount = AvailableAmount,
                Id = -1,
                Info = NameOrTitle
            };
        }
    }
}
