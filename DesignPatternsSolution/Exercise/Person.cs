using System;

namespace Exercise
{
    public class Customer : LibObject
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

        public override RegisteredObject GetRegistrationInfo()
        {
            return new RegisteredObject()
            {
                AvailableAmount = 1,
                Id = -1,
                Info = NameOrTitle
            };
        }
    }
}
