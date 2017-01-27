namespace Exercise
{
	public class Library
	{
		//implement Singleton to make sure only one library will exist
		private static Library library = new Library();

		public static Library Instance
		{
			get
			{
				return library;
			}
		}

		private Library()
		{
		}

		//Implement Register method by utilizing RegistrationRepository (complete missing parts)
		public int Register(IRegistarable item)
		{
			return RegistrationRepository.Register(item);
		}
	}
}
