using Exercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Execise.Tests
{
	[TestClass]
	public class UnitTests
	{
		//test the two calls to library instance return same instance
		[TestMethod]
		public void LibraryShouldBeSingleton()
		{
			//check that when you create a Library instance second time, 
			//you get exactly the same instance as for a very first time
			Assert.AreEqual(Library.Instance, Library.Instance);
		}

		//test that an book was registered successfully by checking the returned Id value is not -1
		[TestMethod]
		public void BookShouldRegister()
		{
			BookBorrowable book = new BookBorrowable(new Book("test", "test", 2017, 2), new RegisteredObject());
			Library.Instance.Register(book);
			Assert.IsTrue(book.GetRegistrationInfo().Id > -1);
		}

		//test that an customer was registered successfully by checking the returned Id value is not -1
		[TestMethod]
		public void CustomerShouldRegister()
		{
			//The assignment didnt state that we needed to create a CustomerRegisterable class?
		}

		//test that a book can be borrowed
		[TestMethod]
		public void CanBorrowBook()
		{
			//create a borrowable book with available amount more than one. 
			//Run BorrowOne method of the BookBorrowable instance. Check that total amount was reduced by one.

			//The assignment did not state that we should create a BorrowOne method in the BookBorrowable class?
		}
	}
}
