using System.Security.Cryptography.X509Certificates;
using ExerciseInterfaces;

namespace Exercise
{
    public class Library
    {
        //Type ctor is thread-safe as per C# implementation specification
        private static readonly Library _instance = new Library();

        private Library() {}

        public static Library Instance() {return _instance;}

        //Implement Register method by utilizing RegistrationRepository (complete missing parts)
        public int Register(IRegistarable registarable)
        {
            return RegistrationRepository.Register(registarable);
        }
    }
}
