using Type = ExerciseEnums.Type;

namespace ExerciseInterfaces
{
    public interface ILibraryObject
    {
        int Id { get; set; }
        int AvailableAmount { get; set; }
        string NameOrTitle { get; set; }
        Type Type { get; set; }
        int YearCreated { get; set; }
    }
}
