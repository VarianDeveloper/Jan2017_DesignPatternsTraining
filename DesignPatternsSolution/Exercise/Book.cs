using ExerciseInterfaces;

namespace Exercise
{
    // Relocated from LibraryItem.cs -- Poor practice to define a concrete class within the abstract class file
    public class Book : LibraryItem, IBook
    {
        public Book(string author, string title, int year, int amount) : base(amount, year)
        {
            NameOrTitle = title;
            Author = author;
        }
        public string Author { get; set; }
    }
}
