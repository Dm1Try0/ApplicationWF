using R2Sound.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R2Sound.DataAccess.Contracts
{
	public interface IUsersDataRepository
	{
		Users GetByKeyPass(string keypass);
		void Add(Users user);
	}
}
