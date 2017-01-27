namespace Exercise
{
    public abstract class LibObject : IRegistarable
    {
        private IRegistrationInfoAPI _registerableInfoBridge;

        public int ObjectId { get; set; }
        public int AvailableAmount { get; set; }
        public string NameOrTitle { get; set; }
        public ObjectType ObjType { get; set; }
        public int YearCreated { get; set; }

        public RegisteredObject GetRegistrationInfo()
        {
            return _registerableInfoBridge.GetRegistrationInfo(this);
        }

        public LibObject(IRegistrationInfoAPI registerableInfoBridge)
        {
            this._registerableInfoBridge = registerableInfoBridge;
        }
    }

    public enum ObjectType
    {
        Person,
        Item
    }
}
