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
            var lib1 = Library.getInstance();
            var lib2 = Library.getInstance();

            Assert.AreEqual(lib1, lib2);

        }

        //test that an book was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void BookShouldRegister()
        {
            var lib = Library.getInstance();
            var book = new Book("one","wolf",1999,1);
            Assert.AreNotEqual(-1,lib.Register(book));
        }

        //test that an customer was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void CustomerShouldRegister()
        {
            var lib = Library.getInstance();
            var cust = new Customer("Bad Man", "123 Street");
            Assert.AreNotEqual(-1, lib.Register(cust));
        }

        //test that a book can be borrowed
        [TestMethod]
        public void CanBorrowBook()
        {
            //create a borrowable book with available amount more than one. 
            //Run BorrowOne method of the BookBorrowable instance. Check that total amount was reduced by one.
            
        }       
    }
}
