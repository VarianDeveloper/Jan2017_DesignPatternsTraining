namespace Exercise
{
    public class BookBorrowable: Book 
    {
        public BookBorrowable(string author, string title, int year, int amount, IRegisterAPI registerApi) : base(author, title, year, amount, registerApi)
        {
        }

        public bool BorrowBook()
        {
            if (this.AvailableAmount > 0)
            {
                this.AvailableAmount--;
                return true;
            }
            return false;
        }
    }
}
