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
        public Book(string author, string title, int year, int amount)
            : base(amount, year)
        {
            NameOrTitle = title;
            Author = author;
        }
        public string Author { get; set; }

        public RegisteredObject GetRegistrationInfo()
        {
            RegisteredObject registeredObject = new RegisteredObject();
            registeredObject.Info = this.NameOrTitle;
            registeredObject.AvailableAmount = this.AvailableAmount;

            return registeredObject;
        }
    }
}
