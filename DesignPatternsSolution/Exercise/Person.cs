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
    }

    public class PersonRegistration : IRegistarable
    {
        private readonly Customer _cust;

        public PersonRegistration(Customer cust)
        {
            _cust = cust;
            _cust.SetId(1);
        }

        public RegisteredObject GetRegistrationInfo()
        {
            return new RegisteredObject()
            {
                AvailableAmount = _cust.AvailableAmount,
                Id = _cust.ObjectId,
                Info = _cust.NameOrTitle
            };
        }
    }
}
