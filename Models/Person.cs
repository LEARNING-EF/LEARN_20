namespace Models
{
	public class Person : BaseEntity
	{
		public Person() : base()
		{
		}

		// **********
		//[System.ComponentModel.DataAnnotations.Display
		//	(Name = "Age")]

		//[System.ComponentModel.DataAnnotations.Display
		//	(Name = "سن")]

		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.DataDictionary),
		//	Name = "Age")]

		// غلط نیست - در حال حاضر هم درست کار می‌کند
		// ولی اصلا توصیه نمی‌شود
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.DataDictionary),
		//	Name = nameof(Age))]

		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.Age))]

		//[System.ComponentModel.DataAnnotations.Range
		//	(typeof(int), "25", "35",
		//	ErrorMessage = "The {0} value should be between {1} and {2}!")]

		// Note: Wrong Usage!
		//[System.ComponentModel.DataAnnotations.Range
		//	(typeof(int), "25", "35",
		//	ErrorMessage = Resources.Messages.RangeErrorMessage)]

		//[System.ComponentModel.DataAnnotations.Range
		//	(type: typeof(int), minimum: "25", maximum: "35",
		//	ErrorMessageResourceType = typeof(Resources.Messages),
		//	ErrorMessageResourceName = "RangeErrorMessage")]

		//[System.ComponentModel.DataAnnotations.Range
		//	(type: typeof(int), minimum: "25", maximum: "35",
		//	ErrorMessageResourceType = typeof(Resources.Messages),
		//	ErrorMessageResourceName = "Googooli")]

		[System.ComponentModel.DataAnnotations.Range
			(type: typeof(int), minimum: "25", maximum: "35",
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = nameof(Resources.Messages.RangeErrorMessage))]
		public int Age { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.FullName))]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = nameof(Resources.Messages.RequiredErrorMessage))]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 50, MinimumLength = 3,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = nameof(Resources.Messages.StringLengthErrorMessage))]
		public string FullName { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.EmailAddress))]

		[System.ComponentModel.DataAnnotations.RegularExpression
			(pattern: Dtx.RegularExpressionPatterns.EmailAddress,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = nameof(Resources.Messages.EmailAddressIsNotValide))]
		public string EmailAddress { get; set; }
		// **********

		public void SomeFunction()
		{
			string username =
				Resources.DataDictionary.Username;

			string message =
				Resources.Messages.RangeErrorMessage;
		}
	}
}
