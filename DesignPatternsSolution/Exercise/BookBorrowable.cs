namespace Exercise
{
	public class BookBorrowable : Book, IRegistarable
	{
		private Book book;
		private RegisteredObject registerable;

		public BookBorrowable(Book book, RegisteredObject registerable)
			: base(book.Author, book.NameOrTitle, book.YearCreated, book.AvailableAmount)
		{
			this.book = book;
			this.registerable = registerable;
			this.registerable.AvailableAmount = this.book.AvailableAmount;
		}

		public RegisteredObject GetRegistrationInfo()
		{
			return registerable;
		}
	}
}
