namespace Exercise
{
    public class Library
    {
        //implement Singleton to make sure only one library will exist
        private static Library library = new Library();
        
        private Library() {

        }

        public static Library getInstance()
        {
            return library;
        }

        //Implement Register method by utilizing RegistrationRepository (complete missing parts)
        public int Register(IRegistarable registarable)
        {
            return RegistrationRepository.Register(registarable);
        }

        public int borrow(int book_id)
        {
            return RegistrationRepository.BorrowBook(book_id);
        }

        public int getAvailableAmount(int book_id)
        {
            return RegistrationRepository.GetAvailableAmount(book_id);
        }
    }
}
