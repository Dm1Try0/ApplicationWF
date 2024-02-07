using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R2Sound.DataAccess.Entities
{
	public class Users
	{
		public long Id { get; set; }
		public string? KeyPassword { get; set; }
		public DateTime dateTime { get; set; }
		public string? ComputerName { get; set; }
		public int DaysTrial { get; set; }
	}
}
