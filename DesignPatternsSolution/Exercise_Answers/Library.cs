
namespace Exercise_Answers
{
    public class Library
    {
        //implement Singleton to make sure only one library will exist

        /////
        private static Library _instance;

        private Library()
        {
        }

        public static Library GetInstance()
        {
            return _instance ?? (_instance = new Library());
        }

        public int Register(IRegistarable registarable)
        {
            return RegistrationRepository.Register(registarable);
        }
    }
}
