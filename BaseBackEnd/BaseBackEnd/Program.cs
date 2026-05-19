using Avalant.Application.Managers;
using Repository.InMemory;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaseBackEnd
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ICardRepository cardRepository = new InMemoryCardRepository();
            CardManager cardManager = new CardManager(cardRepository);

            var character = cardManager.CreateCharacter("Elías", true);

            Console.WriteLine($"Personaje creado: {character.Name}");
        }
    }
}
