using System;
using ExerciseInterfaces;
using Type = ExerciseEnums.Type;

namespace Exercise
{
    public class Customer : LibraryObject, ICustomer
    {
        public string Address { get; set; }
        public DateTime RegisteredAt { get; set; }

        //Exercise states "Customer class - extending Person abstract class". There is no Person class -- it's just a property type of the LibraryObject
        public Customer(string name, string addr)
        {
            NameOrTitle = name;
            Address = addr;
            RegisteredAt = DateTime.Now;
            Type = Type.Person;
        }

        public void SetId(int id)
        {
            Id = id;
        }
    }
}
