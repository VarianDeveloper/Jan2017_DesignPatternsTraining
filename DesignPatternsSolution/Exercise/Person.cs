using System;

namespace Exercise
{
    public class Customer : LibObject, IRegistrable
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
            return new RegisteredObject
            {
                Id = ObjectId,
                AvailableAmount = AvailableAmount,
                Info = String.Format("{0} of {1} ({2})", NameOrTitle, Address, RegisteredAt)
            };
        }
    }
}
