using Avalant.Domain.Models;
using Models.Cards;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interfaces
{
    public interface ICardRepository
    {
        Task AddAsync(CardEntity card);
        Task<CardEntity?> GetByIdAsync(Guid id);
    }
}
