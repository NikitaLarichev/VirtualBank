using VirtualBank.Models;

namespace VirtualBank.Services
{
	public interface IUser
	{
		Task<bool> AddUser(User user);
		Task<User> GetUser(string email);
	}
}
