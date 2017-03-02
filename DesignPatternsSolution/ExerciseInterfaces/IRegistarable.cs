namespace ExerciseInterfaces
{
    public interface IRegistarable
    {
        // Program to interfaces. Do not use concrete user defined types in an interface. Now we can split this class  
        // into a separate dll and consumers do not need rebuild every time our RegisteredObject implementation changes
        IRegisteredObject GetRegistrationInfo();
    }
}
