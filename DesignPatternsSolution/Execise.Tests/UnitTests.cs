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
            Library lib1 = Library.Instance;
            Library lib2 = Library.Instance;
            Assert.ReferenceEquals(lib1, lib2);
        }

        //test that a book was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void BookShouldRegister()
        {
            Library lib1 = Library.Instance;
            Book book1 = new Book("I am Great", "Donald Trump", 2017, 19);
            int result = lib1.Register(book1);
            Assert.AreNotEqual(result, -1);
        }

        //test that a customer was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void CustomerShouldRegister()
        {
            Library lib1 = Library.Instance;
            Customer cust1 = new Customer("Daffy Duck", "123 Dippy Lane, Disneyland, CA");
            int result = lib1.Register(cust1);
            Assert.AreNotEqual(result, -1);
        }

        //test that a book can be borrowed
        [TestMethod]
        public void CanBorrowBook()
        {
            //create a borrowable book with available amount more than one. 
            //Run BorrowOne method of the BookBorrowable instance. Check that total amount was reduced by one.
            Library lib1 = Library.Instance;
            Book book1 = new Book("I am Great", "Donald Trump", 2017, 19);
            int result = lib1.Register(book1);

            Assert.AreNotEqual(result, -1);

        }
    }
}
