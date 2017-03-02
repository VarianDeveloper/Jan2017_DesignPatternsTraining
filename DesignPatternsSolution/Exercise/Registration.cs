using System;
using System.Collections.Generic;
using System.Linq;
using ExerciseInterfaces;

namespace Exercise
{
    public static class RegistrationRepository
    {
        // Registered objects list
        private static List<IRegisteredObject> _registeredList = new List<IRegisteredObject>();

        private static int _nextId = 1;

        //With BRIDGE pattern, implement Register method so it will accept both a Person and an LibraryItem
        public static int Register(IRegistarable registarable)
        {
            //get info from an lib object
            var info = registarable.GetRegistrationInfo();
            if (info == null) return -1;

            //get new id for for the registered object
            info.Id = _nextId;

            //add to registration repository
            _registeredList.Add(info);

            //store next available id
            _nextId = _registeredList.Count + 1;

            //return success
            return info.Id;
        }

        public static int DeleteAllRegisteredItems()
        {
            var size = _registeredList.Count();
            _registeredList.RemoveRange(0, size);
            _nextId = 1;

            return size;
        }
    }

    public class RegisteredObject : IRegisteredObject
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
