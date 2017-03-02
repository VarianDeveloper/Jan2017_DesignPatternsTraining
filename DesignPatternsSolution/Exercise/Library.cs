namespace Exercise
{
    public class Library
    {
        //implement Singleton to make sure only one library will exist


        static Library lib = new Library();

        private Library() { }
        //Implement Register method by utilizing RegistrationRepository (complete missing parts)

        public static Library getLib()
        {
            return lib;
        }
        public int Register()
        {
            // return RegistrationRepository.Register();

            //dummy, just to compile


            return 0;
        }
    }
}
