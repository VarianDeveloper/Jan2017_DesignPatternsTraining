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
            Library lib1 = Library.getInstance();
            Library lib2 = Library.getInstance();

            Assert.AreSame(lib1, lib2, "Objects are not the same instance!");
        }

        //test that an book was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void BookShouldRegister()
        {
            Library library = Library.getInstance();
            LibObject book = new Book("Brandon Meilleur", "Best Code Practices", 1994, 20);
            Assert.AreNotEqual(-1, library.Register(book));
        }

        //test that an customer was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void CustomerShouldRegister()
        {
            Library library = Library.getInstance();
            LibObject customer = new Customer("Brandon Meilleur", "123 Fake St");
            Assert.AreNotEqual(-1, library.Register(customer));
        }

        //test that a book can be borrowed
        [TestMethod]
        public void CanBorrowBook()
        {
            //create a borrowable book with available amount more than one. 
            //Run BorrowOne method of the BookBorrowable instance. Check that total amount was reduced by one.
            BookBorrowable borrowable = new BookBorrowable("Brandon Meilleur", "Cool Things and Stuff", 2000, 15);
            Assert.AreEqual(14, borrowable.borrowOne());
        }       
    }
}
