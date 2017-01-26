using System;

namespace Exercise
{
    public class Customer : LibObject, IRegistarable
    {
        public string Address { get; set; }
        public DateTime RegisteredAt { get; set; }
        private RegisteredObject registeredObject;

        public Customer(string name, string addr)
        {
            NameOrTitle = name;
            Address = addr;
            RegisteredAt = DateTime.Now;
            ObjType = ObjectType.Person;
            registeredObject = new RegisteredObject();
            registeredObject.Info = "information";
        }

        public void SetId(int id)
        {
            ObjectId = id;
        }

        public RegisteredObject GetRegistrationInfo()
        {
            return registeredObject;
        }

    }
}
