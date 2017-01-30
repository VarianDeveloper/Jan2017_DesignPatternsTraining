namespace Exercise_Answers
{
    public abstract class LibObject
    {
        public int ObjectId { get; set; }
        public int AvailableAmount { get; set; }
        public string NameOrTitle { get; set; }
        public ObjectType ObjType { get; set; }
        public int YearCreated { get; set; }
    }

    public enum ObjectType
    {
        Person,
        Item
    }
}
