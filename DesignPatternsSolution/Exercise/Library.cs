namespace Exercise
{
    public class Library
    {
        //implement Singleton to make sure only one library will exist
        static Library instance = new Library();

        private Library() { }

        public static Library getInstance() { return instance; }
      //  private IRegistarable _registerObject;
        

        //Implement Register method by utilizing RegistrationRepository ()
        public int Register(IRegistarable _registerObject)
        {
            
            return RegistrationRepository.Register(_registerObject);

            //dummy, just to compile
           //return 0;
        }
    }
}
