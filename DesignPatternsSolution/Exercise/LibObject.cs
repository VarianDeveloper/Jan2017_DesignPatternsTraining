namespace Exercise
{
    public abstract class LibObject : IRegistarable
    {
        private IRegistrationApi registrationApi;
        protected LibObject(IRegistrationApi registrationApi)
        {
            this.registrationApi = registrationApi;
        }
        public int ObjectId { get; set; }
        public int AvailableAmount { get; set; }
        public string NameOrTitle { get; set; }
        public ObjectType ObjType { get; set; }
        public int YearCreated { get; set; }

        public RegisteredObject GetRegistrationInfo()
        {
            return registrationApi.GetRegistrationInfo(this);
        }
    }

    public enum ObjectType
    {
        Person,
        Item
    }
}
