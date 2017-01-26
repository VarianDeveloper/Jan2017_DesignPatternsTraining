namespace Exercise
{
    public abstract class LibObject: IRegistarable
    {
        public int ObjectId { get; set; }
        public int AvailableAmount { get; set; }
        public string NameOrTitle { get; set; }
        public ObjectType ObjType { get; set; }
        public int YearCreated { get; set; }
        protected IRegisterAPI _RegisterApi;

        public RegisteredObject GetRegistrationInfo()
        {
            return _RegisterApi.GetRegisteredObject(this);
        }

        public LibObject(IRegisterAPI iRegisterApi)
        {
            _RegisterApi = iRegisterApi;
        }
    }

    public enum ObjectType
    {
        Person,
        Item
    }
}
