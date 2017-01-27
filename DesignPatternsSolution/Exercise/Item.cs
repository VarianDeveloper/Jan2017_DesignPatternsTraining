namespace Exercise
{
    public abstract class Item : LibObject
    {
        protected Item(int amount, int year)
        {
            AvailableAmount = amount;
            ObjType = ObjectType.Item;
            YearCreated = year;
        }
    }

    public class Book : Item, IRegistrable
    {
        public Book(string author, string title, int year, int amount) : base(amount, year)
        {
            NameOrTitle = title;
            Author = author;
        }
        public string Author { get; set; }

        public RegisteredObject GetRegistrationInfo()
        {
            RegisteredObject resgisteredObject = new RegisteredObject();
            resgisteredObject.Info = this.NameOrTitle;
            resgisteredObject.AvailableAmount = this.AvailableAmount;

            return resgisteredObject;
        }
    }
}
