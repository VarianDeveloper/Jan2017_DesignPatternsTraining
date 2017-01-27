namespace Exercise
{
    public class Library
    {
        private static Library Instance { get; set; }

        private Library() { Instance = new Library(); }
        public static Library GetInstance() { return Library.Instance; }

        //Implement Register method by utilizing RegistrationRepository (complete missing parts)
        public int Register()
        {
            // return RegistrationRepository.Register();

            //dummy, just to compile
            return 0;
        }
    }
}
