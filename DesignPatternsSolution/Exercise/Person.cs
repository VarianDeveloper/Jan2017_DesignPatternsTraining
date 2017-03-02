﻿using System;

namespace Exercise
{
    public class Customer : LibObject , IRegistarable
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
        public RegisteredObject GetRegistrationInfo()
        {
            return new RegisteredObject()
            {
                Info = NameOrTitle
            };
        }
        public void SetId(int id)
        {
            ObjectId = id;
        }
    }
}
