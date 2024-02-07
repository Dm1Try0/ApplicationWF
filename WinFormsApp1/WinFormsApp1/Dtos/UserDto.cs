namespace WinFormsApp1.Dtos
{
	public class UserDto
	{
		public long Id { get; set; }
		public string? KeyPassword { get; set; }
		public DateTime dateTime { get; set; }
		public string? ComputerName { get; set; }
		public int DaysTrial { get; set; }
		public bool IsActivate { get; set; } = true;
	}
}
