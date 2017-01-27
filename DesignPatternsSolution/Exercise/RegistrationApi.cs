using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public interface IRegistrationApi
    {
        RegisteredObject GetRegistrationInfo(LibObject libObject);
    }

    public class RegistrationApi : IRegistrationApi
    {
        public RegistrationApi()
        {
        }

        public RegisteredObject GetRegistrationInfo(LibObject libObject)
        {
            return new RegisteredObject
            {
                Info = libObject.NameOrTitle,
                AvailableAmount = libObject.AvailableAmount,
                Id = libObject.ObjectId
            };
        }
    }
}
