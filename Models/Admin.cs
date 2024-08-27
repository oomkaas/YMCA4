namespace YMCA_Prototype.Models
{
	public class Admin
	{
		public string Username { get; set; }
		public string EmailAddress { get; set; }
		public string Password { get; set; }

		public Admin(string username, string emailAddress, string password)
		{
			Username = username;
			EmailAddress = emailAddress;
			Password = password;
		}
	}
}