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
            var libOne = Library.GetLibrary();
            var libTwo = Library.GetLibrary();
            Assert.AreSame(libOne, libTwo);


        }

        //test that an book was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void BookShouldRegister()
        {
            var lib = Library.GetLibrary();
            var book = new Book("The Dude", "The Big Lebowski", 1998, 100, new LibObjectRegisterAPI());

            var retval = lib.Register(book);
            Assert.AreNotEqual(-1, retval);


        }

        //test that an customer was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void CustomerShouldRegister()
        {
            var lib = Library.GetLibrary();

            var customer = new Customer("The Dude", "609 Venezia Avenue", new LibObjectRegisterAPI());

            var retval = lib.Register(customer);
            Assert.AreNotEqual(-1, retval);
        }

        //test that a book can be borrowed
        [TestMethod]
        public void CanBorrowBook()
        {
            //create a borrowable book with available amount more than one. 
            //Run BorrowOne method of the BookBorrowable instance. Check that total amount was reduced by one.
            var lib = Library.GetLibrary();
            var book = new BookBorrowable("The Dude", "The Big Lebowski", 1998, 100, new LibObjectRegisterAPI());

            var retval = lib.Register(book);

            Assert.IsTrue(book.BorrowBook());

        }       
    }
}
