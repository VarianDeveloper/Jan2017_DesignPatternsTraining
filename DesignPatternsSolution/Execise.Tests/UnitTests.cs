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
            Library instance1 = Library.getInstance();
            Library instance2 = Library.getInstance();

            Assert.AreSame(instance1, instance2);
        }

        //test that an book was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void BookShouldRegister()
        {
            Library instance = Library.getInstance();
            Book myBook = new Book("Orwell, George", "Nineteen Eighty-Four", 1949, 5);

            int idValue = instance.Register(myBook);

            Assert.IsTrue(idValue != -1);
        }

        //test that an customer was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void CustomerShouldRegister()
        {
            Library instance = Library.getInstance();
            Customer customer = new Customer("Christopher MacKinnon", "386 Broadway");

            int idValue = instance.Register(customer);

            Assert.IsTrue( idValue != -1);
        }

        //test that a book can be borrowed
        [TestMethod]
        public void CanBorrowBook()
        {
            BookBorrowable borrowableBook = new BookBorrowable(new Book("Orwell, George", "Nineteen Eighty-Four", 1949, 6));
            int originalAmount = borrowableBook.AmountToBorrow();

            borrowableBook.BorrowOne();

            Assert.IsTrue(borrowableBook.AmountToBorrow() < originalAmount);
        }       
    }
}
