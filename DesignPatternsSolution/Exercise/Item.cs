namespace Exercise
{
    public abstract class Item : LibObject
    {
        public Item(int amount, int year, IRegisterAPI registerApi): base(registerApi)
        {
            AvailableAmount = amount;
            ObjType = ObjectType.Item;
            YearCreated = year;
        }
    }

    public class Book : Item
    {
        public Book(string author, string title, int year, int amount, IRegisterAPI registerApi)
            : base(amount, year, registerApi)
        {
            NameOrTitle = title;
            Author = author;
        }
        public string Author { get; set; }

       
    }
}
