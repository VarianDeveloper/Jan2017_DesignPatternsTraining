using System;

namespace Exercise
{
    public class Customer : LibObject
    {
        public string Address { get; set; }
        public DateTime RegisteredAt { get; set; }

        //public Customer(string name, string addr)
        public Customer(string name, string addr, IRegistrationApi registrationApi)
            : base(registrationApi)
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
    }
}
