using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int number = 5;
                Card card1 = new Card();
                Card card2 = card1;
                card1.Face = Face.eight;
                card2.Face = Face.king;

                Console.WriteLine(card1.Face);
                //TwentyOneGame game = new TwentyOneGame();
                //game.Players = new List<string>() { "Jessie", "billie", "Bob" };
                //game.ListPlayers();
                //Console.ReadLine();
                //Game game = new TwentyOneGame();
                //game.Players = new List<Player>();
                //Player player = new Player();
                //player.Name = "Jesse";
                //game += player;
                //game -= player;
                //Player<Card> player = new Player<Card>();
                
                //Deck deck = new Deck();
                //deck.Shuffle(3);


                //foreach (Card card in deck.Cards)
                //{
                //    Console.WriteLine(card.Face + " of " + card.Suit);
                //}
                //Console.WriteLine(deck.Cards.Count);
                Console.ReadLine();
                }
                //}


                //public static Deck Shuffle(Deck deck, int times)
                //{
                //    for (int i = 0; i < times; i++)
                //    {
                //        deck = Shuffle(deck);
                //    }
                //    return deck;
            }
        }

    }
