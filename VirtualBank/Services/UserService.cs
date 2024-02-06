using Microsoft.EntityFrameworkCore;
using VirtualBank.Data;
using VirtualBank.Models;

namespace VirtualBank.Services
{
	public class UserService : IUser
	{
		IdentityContext _dbContext;
		public UserService(IdentityContext dbContext)
		{
			_dbContext = dbContext;
		}
		public async Task<bool> AddUser(User user)
		{
			if (await _dbContext.Users.AnyAsync(u => u.Email == user.Email))
			{
				return false;
			}
			else
			{
				try
				{
					//string password = user.Password; //захэшировать
					//user.Password = password;
					////user.Card = new Card()
					//await _dbContext.Users.AddAsync(user);
					//await _dbContext.SaveChangesAsync();
					return true;
				}
				catch (Exception)
				{
					return false;
				}
			}
		}
		public async Task<User> GetUser(string email)
		{
			User user = null;
			return user;
		}
	}
}
