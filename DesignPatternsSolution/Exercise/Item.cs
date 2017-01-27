namespace Exercise
{
    public abstract class Item : LibObject
    {
        //public Item(int amount, int year)
        public Item(int amount, int year, IRegistrationApi registrationApi)
            : base(registrationApi)
        {
            AvailableAmount = amount;
            ObjType = ObjectType.Item;
            YearCreated = year;
        }
    }

    public class Book : Item
    {
        //public Book(string author, string title, int year, int amount) : base(amount, year)
        public Book(string author, string title, int year, int amount, IRegistrationApi registrationApi)
            : base(amount, year, registrationApi)
        {
            NameOrTitle = title;
            Author = author;
        }
        public string Author { get; set; }
    }
}
