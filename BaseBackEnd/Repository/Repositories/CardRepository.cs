using Avalant.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories
{
    public class CardRepository : ICardRepository
    {
        private readonly GameDbContext _context;

        public CardRepository(GameDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(CardEntity card)
        {
            await _context.Cards.AddAsync(card);
            await _context.SaveChangesAsync();
        }

        public async Task<CardEntity?> GetByIdAsync(Guid id)
        {
            return await _context.Cards.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
