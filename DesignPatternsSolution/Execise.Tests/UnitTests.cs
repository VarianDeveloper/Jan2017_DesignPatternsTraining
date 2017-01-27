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
            var L1 = Library.getInstance();
            var L2 = Library.getInstance();

            Assert.AreEqual(L1, L2);
        }

        //test that an book was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void BookShouldRegister()
        {
            Book B1 = new Book("Hello", "World", 2017, 10);
            int result = RegistrationRepository.Register(B1);

            Assert.AreNotEqual(-1, result);
        }

        //test that an customer was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void CustomerShouldRegister()
        {
            Customer C1 = new Customer("Troy", "Winnipeg");
            int result = RegistrationRepository.Register(C1);

            Assert.AreNotEqual(-1, result);
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
