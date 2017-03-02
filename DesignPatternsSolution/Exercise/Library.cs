namespace Exercise
{
    public sealed class Library
    {
        //implement Singleton to make sure only one library will exist
        private static Library instance;
        private Library() { }


        public static Library Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Library();
                }
                return instance;
            }
        }

        //public static Library getInstance() ()
        //Implement Register method by utilizing RegistrationRepository (complete missing parts)
        public int Register(IRegistarable newRegObject)
        {
            return RegistrationRepository.Register(newRegObject);

            //dummy, just to compile
            //return 0;
        }
    }
}
