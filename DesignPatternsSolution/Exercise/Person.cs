using System;

namespace Exercise
{
    public class Customer : LibObject
    {
        public Customer(string name, string addr)
        {
            NameOrTitle = name;
            Address = addr;
            RegisteredAt = DateTime.Now;
            ObjType = ObjectType.Person;
        }

        public string Address { get; set; }
        public DateTime RegisteredAt { get; set; }

        public void SetId(int id)
        {
            ObjectId = id;
        }
    }
}