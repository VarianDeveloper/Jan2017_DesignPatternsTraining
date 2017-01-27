using System;
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
            var a = Library.getLibInstance();
            var b = Library.getLibInstance();
            var bSameObject = ReferenceEquals(a, b);
            Assert.AreEqual(true, bSameObject, "Objects returned are different");
        }

        //test that an book was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void BookShouldRegister()
        {
            var registeredId = RegistrationRepository.Register(new Book("bill", "bill's book", 1995, 5));
            Assert.AreNotEqual(-1, registeredId);  

        }

        //test that an customer was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void CustomerShouldRegister()
        {
            var registeredId = RegistrationRepository.Register(new Customer("bill", "bill's addr"));
            Assert.AreNotEqual(-1, registeredId);  
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
