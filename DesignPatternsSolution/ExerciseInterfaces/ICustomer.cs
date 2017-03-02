using System;

namespace ExerciseInterfaces
{
    public interface ICustomer
    {
        string Address { get; set; }
        DateTime RegisteredAt { get; set; }

        void SetId(int id);
    }
}
