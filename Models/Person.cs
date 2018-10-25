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

		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.Models.Person),
			Name = "Age")]

		//[System.ComponentModel.DataAnnotations.Range
		//	(typeof(int), "25", "35",
		//	ErrorMessage = "The {0} value should be between {1} and {2}!"]

		[System.ComponentModel.DataAnnotations.Range
			(type: typeof(int), minimum: "25", maximum: "35",
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = "RangeErrorMessage")]
		public int Age { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.Models.General),
			Name = "FullName")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = "RequiredErrorMessage")]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 50, MinimumLength = 3,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = "StringLengthErrorMessage")]
		public string FullName { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.Models.General),
			Name = "EmailAddress")]

		[System.ComponentModel.DataAnnotations.RegularExpression
			(pattern: Dtx.RegularExpressionPatterns.EmailAddress,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = "RegularExpressionErrorMessage")]
		public string EmailAddress { get; set; }
		// **********
	}
}
