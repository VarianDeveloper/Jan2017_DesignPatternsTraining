using System;

namespace Exercise
{
    public class Customer : LibObject
    {
        public string Address { get; set; }
        public DateTime RegisteredAt { get; set; }

        public Customer(string name, string addr, IRegisterAPI registerApi): base (registerApi)
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
