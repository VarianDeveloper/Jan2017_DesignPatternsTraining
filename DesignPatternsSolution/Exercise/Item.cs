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

    public class Book : Item, IRegistarable, IBorrowable
    {
        public Book(string author, string title, int year, int amount) : base(amount, year)
        {
            NameOrTitle = title;
            Author = author;
        }

        public RegisteredObject GetRegistrationInfo()
        {
            RegisteredObject obj = new RegisteredObject();
            obj.AvailableAmount = this.AvailableAmount;
            obj.Info = "Stuff about this book";
            obj.obj = this;
            return obj;
        }
        public string Author { get; set; }
    }
}
