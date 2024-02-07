using Microsoft.EntityFrameworkCore;
using WinFormsApp1.Dtos;

namespace WinFormsApp1
{
	public class ApplicationContext : DbContext
	{
		public DbSet<UserDto> Users { get; set; } = null!;
		public ApplicationContext()
		{
			//Database.EnsureCreated();
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseNpgsql("Host=;Port=;Database=;Username=;Password="); //строка подключения
		}
	}
}
