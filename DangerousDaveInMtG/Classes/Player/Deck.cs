/*
 * Created by SharpDevelop.
 * User: Brad
 * Date: 21-Nov-18
 * Time: 23:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace DangerousDaveInMtG
{
	/// <summary>
	/// Description of Deck.
	/// </summary>
	public class Deck
	{
		const int deckSize = 100;
		private readonly IList<Card> cards;

		public Deck(int size)
		{			
			cards = new List<Card>();
			
			for(int i = 0; i < deckSize/2; i++)
			{
				cards.Add(new Forest());
				cards.Add(new LlanowarElves());
			}
		}

		
		public Card Draw()
		{
			Card drawnCard;
			
			drawnCard = cards[0];
			cards.Remove(drawnCard);
			
			return drawnCard;
		}
		
		//  Fisher-Yates	
		public void Shuffle()
		{
			Random r = new Random();
			
			for (int n = cards.Count - 1; n > 0; --n)
			{
				int k = r.Next(n+1);
				Card temp = cards[n];
				cards[n] = cards[k];
				cards[k] = temp;
			}
		}
	}
}
