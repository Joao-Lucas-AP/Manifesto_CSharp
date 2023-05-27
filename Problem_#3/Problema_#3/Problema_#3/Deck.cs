using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema__3
{
    public class Deck
    {
        private List<Card> cards;

        public Deck()
        {
            cards = new List<Card>();
            InitializeDeck();
        }

        public void InitializeDeck()
        {
            //adiciona cartas ao deck [[cards.Add(new Card("tipo da carta", "nome da carta"))]];
            cards.Add(new Card("Champion", "Sylas"));
            cards.Add(new Card("Unit", "Mago revolucionário"));
            cards.Add(new Card("Skill", "Usurpar"));
            cards.Add(new Card("Equipment", "Correntes de petricita"));
            cards.Add(new Card("Monument", "Prisão de magos demaciana"));
            cards.Add(new Card("Spell", "Evasão e abdução"));
        }

        public void Shuffle()
        {
            Random random = new Random();

            for (int i = cards.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                Card temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }
        }

        public void PrintDeck()
        {
            foreach (Card card in cards)
            {
                Console.WriteLine($"{card.Type} - {card.Name}");
            }
        }
    }
}
