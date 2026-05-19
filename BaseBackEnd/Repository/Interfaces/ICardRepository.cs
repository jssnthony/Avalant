using Models.Cards;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interfaces
{
    public interface ICardRepository
    {
        void Add(CardBaseModel card);
        CardBaseModel? GetById(Guid id);
        List<CardBaseModel> GetAll();
    }
}
