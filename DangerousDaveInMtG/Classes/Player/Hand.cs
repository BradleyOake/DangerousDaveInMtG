/*
 * Created by SharpDevelop.
 * User: Brad
 * Date: 23-Nov-18
 * Time: 01:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace DangerousDaveInMtG
{
	/// <summary>
	/// Description of Hand.
	/// </summary>
	public class Hand
	{
		private readonly IList<Card> hand = new List<Card>();
		
		public Hand()
		{
		}
		
		public void Draw(Deck deck)
		{
			hand.Add(deck.Draw());
		}
		
		public void Remove(Card card)
		{
			hand.Remove(card);
		}
		
		public void PlayCard(int index, Battlefield battlefield)
		{
			Card card = hand[index];
			hand.RemoveAt(index);
			battlefield.Add(card);
		}
	}
}
