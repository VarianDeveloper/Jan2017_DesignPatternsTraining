namespace ExerciseInterfaces
{
    public interface IRegisteredObject
    {
        string Info { get; set; }
        int Id { get; set; }
        int AvailableAmount { get; set; }

        string ToString();
    }
}
