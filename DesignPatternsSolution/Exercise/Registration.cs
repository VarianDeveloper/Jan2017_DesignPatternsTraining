using System;
using System.Collections.Generic;
using System.Linq;
namespace Exercise
{
    public interface IRegistarable
    {
        RegisteredObject GetRegistrationInfo();
    }

    public static class RegistrationRepository
    {
        //registered objects list
        private static List<RegisteredObject> _registeredList = new List<RegisteredObject>();

        private static int _nextId = 1;

        //With BRIDGE pattern, implement Register method so it will accept both a Person and an Item
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

        public static int BorrowBook(int book_id)
        {
            foreach(RegisteredObject obj in _registeredList) {
                if (obj.Id == book_id)
                {
                    if (obj.obj is IBorrowable && obj.AvailableAmount > 0)
                    {
                        obj.AvailableAmount -= 1;
                        return 0;
                    }
                }
            }
            return -1;
        }

        public static int GetAvailableAmount(int book_id)
        {
            foreach (RegisteredObject obj in _registeredList)
            {
                if (obj.Id == book_id)
                {
                    return obj.AvailableAmount;
                }
            }
            return -1;
        }
    }

    public class RegisteredObject
    {
        public string Info { get; set; }
        public int Id { get; set; }
        public int AvailableAmount { get; set; }
        public IRegistarable obj { get; set; }

        public override string ToString()
        {
            return Info + " " + "Available: " + AvailableAmount;
        }
    }
}
