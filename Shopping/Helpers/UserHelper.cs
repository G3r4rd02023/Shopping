using Microsoft.AspNetCore.Identity;
using Shopping.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Helpers
{
	public class UserHelper : IUserHelper
	{
		private readonly UserManager<User> userManager;

		public UserHelper(UserManager<User> userManager)
		{
			this.userManager = userManager;
		}

		public async Task<IdentityResult> AddUserAsync(User user, string password)
		{
			return await this.userManager.CreateAsync(user, password);
		}

		public async Task<User> GetUserByEmailAsync(string email)
		{
			var user = await this.userManager.FindByEmailAsync(email);
			return user;
		}
	}

}
