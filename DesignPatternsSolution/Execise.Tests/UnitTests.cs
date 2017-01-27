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
            Assert.AreSame(Library.Instance,Library.Instance);
        }

        //test that an book was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void BookShouldRegister()
        {
        }

        //test that an customer was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void CustomerShouldRegister()
        {
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
