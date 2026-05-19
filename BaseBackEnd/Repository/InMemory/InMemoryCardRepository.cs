using Models.Cards;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.InMemory
{
    public class InMemoryCardRepository : ICardRepository
    {
        private readonly List<CardBaseModel> _cards = new();

        public void Add(CardBaseModel card)
        {
            _cards.Add(card);
        }

        public CardBaseModel? GetById(Guid id)
        {
            return _cards.FirstOrDefault(x => x.UniqueId == id);
        }

        public List<CardBaseModel> GetAll()
        {
            return _cards;
        }
    }
}
