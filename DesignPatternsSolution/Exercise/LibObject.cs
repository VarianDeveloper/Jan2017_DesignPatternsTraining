namespace Exercise
{
    public abstract class LibObject : IRegistarable
    {
        public int ObjectId { get; set; }
        public int AvailableAmount { get; set; }
        public string NameOrTitle { get; set; }
        public ObjectType ObjType { get; set; }
        public int YearCreated { get; set; }

        public RegisteredObject GetRegistrationInfo()
        {
            return new RegisteredObject()
                { 
                     Info = NameOrTitle,
                     AvailableAmount = AvailableAmount,
                     Id = ObjectId
                };
        }
    }

    public enum ObjectType
    {
        Person,
        Item
    }

   
}
