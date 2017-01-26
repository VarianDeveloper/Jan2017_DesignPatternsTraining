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

    public class Book : Item, IRegistarable
    {
        private RegisteredObject registeredObject;

        public Book(string author, string title, int year, int amount) : base(amount, year)
        {
            NameOrTitle = title;
            Author = author;
            registeredObject = new RegisteredObject();
            registeredObject.Info = "Book";
            registeredObject.AvailableAmount = amount;
        }
        public string Author { get; set; }

        public RegisteredObject GetRegistrationInfo()
        {
            return registeredObject;
        }
    }
}
