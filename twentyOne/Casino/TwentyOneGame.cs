﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casino.Interfaces;

namespace Casino.twentyOne
{
    public class TwentyOneGame : Game, IWalkAway
    {
        public TwentyOneDealer Dealer { get; set; }
        public override void Play()
        {
            Dealer = new TwentyOneDealer();
            foreach (Player player in Players)
            {
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>();
            Dealer.stay = false;
            Dealer.Deck = new Deck();
            Dealer.Deck.Shuffle();
           

            foreach (Player player in Players)
            {
                bool validAnswer = false;
                int bet = 0;
                while(!validAnswer)
                {
                    Console.WriteLine("Place your bet!");
                    validAnswer = int.TryParse(Console.ReadLine(), out bet);
                    if(!validAnswer)
                    {
                        Console.WriteLine("Please enter digits only, no decimals.");
                    }
                if (bet < 0)
                    {
                        throw new FraudException("Security! Kick this person out.");
                    }
                }
            
                bool sucessfullyBet = player.Bet(bet);
                if (!sucessfullyBet)
                {
                    return;
                }
                Bets[player] = bet;
        }
        for (int i = 0; i < 2; i++)  
            {
                Console.WriteLine("Dealing...");
                foreach (Player player in Players)
                {
                    Console.Write("{0}: ", player.Name);
                    Dealer.Deal(player.Hand);
                    if (i == 1)
                    {

                    }
                }
            }

       
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 players:");
            base.ListPlayers();
        }
        public void WalkAway(Player Player)
        {
            throw new NotImplementedException();
        }
    }   
}
