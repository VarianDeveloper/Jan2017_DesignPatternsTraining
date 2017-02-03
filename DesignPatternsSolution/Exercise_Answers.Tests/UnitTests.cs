using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise_Answers.Tests
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
            Assert.IsTrue(ReferenceEquals(Library.GetInstance(), Library.GetInstance()));
        }

        //test that an book was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void BookShouldRegister()
        {
            Assert.IsTrue(Library.GetInstance().Register(new Book(" J. K. Rowling", "Harry Potter", 2016, 10)) != -1);

        }

        //test that an customer was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void CustomerShouldRegister()
        {
            Assert.IsTrue(Library.GetInstance().Register(new Customer("Alex B", "386 Broadway")) != -1);
        }

        //test that a book can be borrowed
        [TestMethod]
        public void CanBorrowBook()
        {
            //create a borrowable book with available amount more than one. 
            //Run BorrowOne method of the BookBorrowable instance. Check that total amount was reduced by one.
            var intialAmount = 10;
            var borrowableBook = new BookBorrowable(new Book(" J. K. Rowling", "Harry Potter", 2016, intialAmount));
            borrowableBook.BorrowOne();

            Assert.IsTrue(borrowableBook.AvailableAmount == intialAmount - 1);
        }


        //////// NOT FOR EXERCISE ////////

        //test the very first id is always 1
        [TestMethod]
        public void FirstIdIsAlwaysOne()
        {
            RegistrationRepository.DeleteAllRegisteredItems();

            var id = Library.GetInstance().Register(new Book(" J. K. Rowling", "Harry Potter", 2016, 10));

            Assert.IsTrue(id == 1);
        }
    }
}
