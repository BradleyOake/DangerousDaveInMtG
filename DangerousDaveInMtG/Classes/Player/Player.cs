/*
 * Created by SharpDevelop.
 * User: Brad
 * Date: 22-Nov-18
 * Time: 22:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace DangerousDaveInMtG
{
	/// <summary>
	/// Description of Player.
	/// </summary>
	public class Player
	{
		public Deck deck;
		public Hand hand;
		public Battlefield battlefield;
		public Mana manaPool;

		
		public Player()
		{
			deck = new Deck(100);
			hand = new Hand();
			battlefield = new Battlefield();
			manaPool = new Mana();
		}
		
		public void PlayCard(int index)
		{
			hand.PlayCard(index, battlefield);
		}
	}
}
