using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Dtos;

namespace WinFormsApp1.Contracts
{
	public interface IUsersService
	{
		UserDto? GetKeyPass(string keypass);
		UserDto CreateNewKeyPass(string keypass, DateTime dateTime, string computername, int daystrial);
	}
}
