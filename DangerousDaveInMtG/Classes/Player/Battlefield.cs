/*
 * Created by SharpDevelop.
 * User: Brad
 * Date: 23-Nov-18
 * Time: 01:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace DangerousDaveInMtG
{
	/// <summary>
	/// Description of Field.
	/// </summary>
	public class Battlefield
	{
		private readonly IList<Card> cards;
		
		public Battlefield()
		{
			cards = new List<Card>();
		}
		
		public void Add(Card card)
		{
			cards.Add(card);
		}
		
		public void TapCard(int index)
		{
			cards[index].Tap();
		}
	}
}
