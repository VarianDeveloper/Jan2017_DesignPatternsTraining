﻿using Exercise;
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
            Assert.AreSame(Library.Instance, Library.Instance);
        }

        //test that an book was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void BookShouldRegister()
        {
            var result = Library.Instance.Register(new Book("Keith Tremorin", "Design Patterns", 1992, 50));
            Assert.AreNotEqual(-1, result);
        }

        //test that an customer was registered successfully by checking the returned Id value is not -1
        [TestMethod]
        public void CustomerShouldRegister()
        {
            var result = Library.Instance.Register(new Customer("Some Guy", "123 Fake Street"));
            Assert.AreNotEqual(-1, result);
        }

        //test that a book can be borrowed
        [TestMethod]
        public void CanBorrowBook()
        {
            var availableBooks = 20;
            var book = new Book("Keith Tremorin", "Design Patterns", 1992, availableBooks);
            var borrowableBook = new BookBorrowable(book);
            borrowableBook.BorrowOne();
            Assert.AreEqual(availableBooks - 1, book.AvailableAmount);
        }
    }
}