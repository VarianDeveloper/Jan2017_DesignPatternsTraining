using System;

namespace Exercise
{
    public class Customer : LibObject, IRegistarable
    {
        public string Address { get; set; }
        public DateTime RegisteredAt { get; set; }

        public Customer(string name, string addr)
        {
            NameOrTitle = name;
            Address = addr;
            RegisteredAt = DateTime.Now;
            ObjType = ObjectType.Person;
        }

        public void SetId(int id)
        {
            ObjectId = id;
        }

        public RegisteredObject GetRegistrationInfo()
        {
            RegisteredObject obj = new RegisteredObject();
            obj.AvailableAmount = this.AvailableAmount;
            obj.Info = "Stuff about this person";
            obj.obj = this;
            return obj;
        }
    }
}
