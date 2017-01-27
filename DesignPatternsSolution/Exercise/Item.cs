namespace Exercise
{
    public abstract class Item : LibObject
    {
        public Item(int amount, int year, IRegistrationInfoAPI registerableInfoBridge) : base(registerableInfoBridge)
        {
            AvailableAmount = amount;
            ObjType = ObjectType.Item;
            YearCreated = year;
        }
    }

    public class Book : Item
    {
        public Book(string author, string title, int year, int amount, IRegistrationInfoAPI registerableInfoBridge) : base(amount, year, registerableInfoBridge)
        {
            NameOrTitle = title;
            Author = author;
        }
        public string Author { get; set; }
    }
}
