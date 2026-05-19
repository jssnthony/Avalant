using Models.Cards;
using Models.Enums;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avalant.Application.Managers
{
    public class CardManager
    {
        private readonly ICardRepository _cardRepository;

        public CardManager(ICardRepository cardRepository)
        {
            _cardRepository = cardRepository;
        }

        public CharacterCardModel CreateCharacter(string name, bool isPlayable)
        {
            var character = new CharacterCardModel
            {
                UniqueId = Guid.NewGuid(),
                Name = name,
                CardType = CardTypeEnum.Character,
                
            };

            _cardRepository.Add(character);

            return character;
        }

        public List<CardBaseModel> GetAllCards()
        {
            return _cardRepository.GetAll();
        }
    }
}
