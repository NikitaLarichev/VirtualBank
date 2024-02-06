using Microsoft.EntityFrameworkCore;
using VirtualBank.Data;
using VirtualBank.Models;

namespace VirtualBank.Services
{
	public class CardService
	{
		IdentityContext _dbContext;
		public CardService(IdentityContext dbContext)
		{
			_dbContext = dbContext;
		}
		public async Task<List<Card>> GetCards(string email)
		{
			List<Card> cards = await _dbContext.Cards.Where(c => c.OwnerEmail == email).ToListAsync();
			return cards;
		}
		public async Task<bool> AddCard(Card card)
		{
			try
			{
				await _dbContext.Cards.AddAsync(card);
				await _dbContext.SaveChangesAsync();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}
	}
}
