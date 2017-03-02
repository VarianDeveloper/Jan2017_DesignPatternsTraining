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

        override public RegisteredObject GetRegistrationInfo()
        {
            RegisteredObject registerable = new RegisteredObject();
            registerable.Info = ObjType.ToString();
            registerable.AvailableAmount = AvailableAmount;

            return registerable;
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
    }
}
