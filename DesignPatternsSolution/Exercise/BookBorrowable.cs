namespace Exercise
{
    public class BookBorrowable: Book
    {
        public BookBorrowable(string author, string title, int year, int amount): base(author, title, year, amount)
        {

        }      

        public void BorrowOne() {
            this.AvailableAmount--;
        }

        public int getAvailableAmount()
        {
            return this.AvailableAmount;
        }
    }

}
