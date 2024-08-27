namespace YMCA3
{
	public class NewsFeedItem
	{
		public string Image { get; set; }
		public string Headline { get; set; }
		public string Description { get; set; }
		public DateTime Date { get; set; }

		public NewsFeedItem(string image, string headline, string description, DateTime date)
		{
			Image = image;
			Headline = headline;
			Description = description;
			Date = date;
		}
	}
}