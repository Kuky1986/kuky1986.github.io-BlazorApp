namespace CA3vin.Models
{
	public class Root
	{
		public string service { get; set; }
		public string version { get; set; }
		public string date { get; set; }
		public string status { get; set; }
		public string vin_captured { get; set; }
		public Vindecode vindecode { get; set; }
		public int left { get; set; }
		public int top { get; set; }
		public int width { get; set; }
		public int height { get; set; }
	}
}
