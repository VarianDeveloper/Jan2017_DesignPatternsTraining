using Exercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Execise.Tests
{
    [TestClass]
    public class UnitTests
    {
        //test the two calls to library instance return same instance
        [TestMethod]
        public void LibraryShouldBeSingleton()
        {
            Library myLib = Library.getInstance();
            Library secondLib = Library.getInstance();

            Assert.AreSame(myLib, secondLib);
        }

        //test that an book was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void BookShouldRegister()
        {
            Library myLib = Library.getInstance();
            Book book = new Book("Author", "Title", 2010, 5);
            int ret_code = myLib.Register(book);
            Assert.AreNotEqual(-1, ret_code);

        }

        //test that an customer was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void CustomerShouldRegister()
        {
            Console.WriteLine("WHAT");
            Library myLib = Library.getInstance();
            Customer customer = new Customer("Name", "Address");
            int ret_code = myLib.Register(customer);
            Assert.AreNotEqual(-1, ret_code);
        }

        //test that a book can be borrowed
        [TestMethod]
        public void CanBorrowBook()
        {
            //Didn't do decorator.. this is more reliable.
            int start_book_count = 30;
            Book borrowBook = new Book("Author2", "Title2", 1990, start_book_count);
            Library myLib = Library.getInstance();
            int book_id = myLib.Register(borrowBook);
            myLib.borrow(book_id);
            int book_count = myLib.getAvailableAmount(book_id);
            Assert.AreEqual(start_book_count - 1, book_count);
        }       
    }
}
