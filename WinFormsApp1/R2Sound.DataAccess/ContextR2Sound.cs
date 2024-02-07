using Microsoft.EntityFrameworkCore;
using R2Sound.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R2Sound.DataAccess
{
	public class ContextR2Sound : DbContext
	{
		public ContextR2Sound(DbContextOptions<ContextR2Sound> options) : base(options)
		{
			
		}
		public DbSet<Users> UsersR2Sound { get; set; }
	}
}
