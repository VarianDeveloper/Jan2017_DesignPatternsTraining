using System;
using System.Collections.Generic;
using System.Linq;
namespace Exercise
{
    public interface IRegistrable
    {
        RegisteredObject GetRegistrationInfo();
    }

    public static class RegistrationRepository
    {
        private static readonly List<RegisteredObject> RegisteredList = new List<RegisteredObject>();

        private static int _nextId = 1;

        public static int Register(IRegistrable registrable)
        {
            var info = registrable.GetRegistrationInfo();
            if (info == null) return -1;

            info.Id = _nextId;

            RegisteredList.Add(info); 

            _nextId = RegisteredList.Count + 1;

            return info.Id;
        }

        public static int DeleteAllRegisteredItems()
        {
            var size = RegisteredList.Count();
            RegisteredList.RemoveRange(0, size);
            _nextId = 1;

            return size;
        }
    }

    public class RegisteredObject
    {
        public string Info { get; set; }
        public int Id { get; set; }
        public int AvailableAmount { get; set; }

        public override string ToString()
        {
            return Info + " " + "Available: " + AvailableAmount;
        }
    }
}
