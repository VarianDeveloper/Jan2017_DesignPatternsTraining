using ExerciseInterfaces;
using Type = ExerciseEnums.Type;

namespace Exercise
{
    // renamed from LibObject
    public abstract class LibraryObject : ILibraryObject, IRegistarable
    {
        public int Id { get; set; }
        public int AvailableAmount { get; set; }
        public string NameOrTitle { get; set; } // the fact that this property is re-used for two distinct purposes is a good indicator that SRP is not adhered to.
        public Type Type { get; set; } // renamed from ObjType. "Object" is implied. Naming should be consistent with ID property
        public int YearCreated { get; set; } // customers have a year created?

        //public abstract IRegisteredObject GetRegistrationInfo(); // Override in child classes
        public IRegisteredObject GetRegistrationInfo()
        {
            return new RegisteredObject() { AvailableAmount = AvailableAmount, Id = Id, Info = NameOrTitle };
        }
    }
}
