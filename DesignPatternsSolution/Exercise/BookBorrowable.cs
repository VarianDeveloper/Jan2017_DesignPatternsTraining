namespace Exercise
{
    public class BookBorrowable : Book
    {

        public BookBorrowable(string author, string title, int year, int amount) 
            : base(author, title, year, amount)
        {

        }

        public int borrowOne()
        {
            if (this.AvailableAmount > 0)
            {
                this.AvailableAmount -= 1;
                return this.AvailableAmount;
            }
            else
            {
                return -1;
            }
            
        }
    }
}
