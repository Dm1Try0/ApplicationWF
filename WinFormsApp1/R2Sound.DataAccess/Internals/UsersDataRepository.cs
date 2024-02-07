using R2Sound.DataAccess.Contracts;
using R2Sound.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R2Sound.DataAccess.Internals
{
	internal class UsersDataRepository : IUsersDataRepository
	{
		private readonly ContextR2Sound _context;

		public UsersDataRepository(ContextR2Sound сontext)
		{
			_context = сontext;
		}
		public void Add(Users user)
		{
			_context.UsersR2Sound.Add(user);

			_context.SaveChanges();
		}
		public Users GetByKeyPass(string keypass)
		{
			return _context.UsersR2Sound.FirstOrDefault(u=> u.KeyPassword == keypass);
		}
	}
}
