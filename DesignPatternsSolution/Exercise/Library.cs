using System.Runtime.Remoting.Messaging;

namespace Exercise
{
    public class Library
    {
        //implement Singleton to make sure only one library will exist
        private static Library libInstance = new Library();

        private Library()
        {
        }

        public static Library getLibInstance()
        {
            return libInstance;
        }


        //Implement Register method by utilizing RegistrationRepository (complete missing parts)
        public int Register(IRegistarable libObject)
        {
            return RegistrationRepository.Register(libObject);
        }
    }
}
