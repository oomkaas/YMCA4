namespace YMCA_Prototype.Models
{
	public class User
	{
		public string FullName { get; set; }
		public string Username { get; set; }
		public string EmailAddress { get; set; }
		public string PhoneNumber { get; set; }
		public string City { get; set; }
		public string Password { get; set; }
		public MembershipType Member { get; set; }
		public bool Volunteer { get; set; }

		public User(string fullName, string username, string emailAddress, string phoneNumber, string city, string password, MembershipType member, bool volunteer)
		{
			FullName = fullName;
			Username = username;
			EmailAddress = emailAddress;
			PhoneNumber = phoneNumber;
			City = city;
			Password = password;
			Member = member;
			Volunteer = volunteer;
		}
	}
}