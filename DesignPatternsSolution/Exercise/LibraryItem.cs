using ExerciseEnums;
using ExerciseInterfaces;

namespace Exercise
{
    public abstract class LibraryItem : LibraryObject
    {
        public LibraryItem(int amount, int year)
        {
            AvailableAmount = amount;
            Type = Type.Item;
            YearCreated = year;
        }
    }
}
