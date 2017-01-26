using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class LibObjectRegistrationInfoAPI : IRegistrationInfoAPI
    {
        public LibObjectRegistrationInfoAPI() { }

        public RegisteredObject GetRegistrationInfo(LibObject objectIn)
        {
            RegisteredObject regObject = new RegisteredObject();
            regObject.Info = objectIn.NameOrTitle;
            regObject.AvailableAmount = objectIn.AvailableAmount;
            regObject.Id = objectIn.ObjectId;
            return regObject;
        }
    }
}
