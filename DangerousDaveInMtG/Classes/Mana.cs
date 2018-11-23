/*
 * Created by SharpDevelop.
 * User: Brad
 * Date: 23-Nov-18
 * Time: 00:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;

namespace DangerousDaveInMtG
{
	/// <summary>
	/// Description of Mana.
	/// </summary>
	public class Mana
	{
		private int[] mana;
			
		public Mana()
		{
			mana = new int[Enum.GetValues(typeof(ManaType)).Cast<int>().Max()+1];
		}
		
		public void AddWhiteMana(int amount)
		{
			mana[(int)ManaType.White] += amount;
		}
		public void AddBlackMana(int amount)
		{
			mana[(int)ManaType.Black] += amount;
		}
		public void AddBlueMana(int amount)
		{
			mana[(int)ManaType.Blue] += amount;
		}
		public void AddGreenMana(int amount)
		{
			mana[(int)ManaType.Green] += amount;
		}
		public void AddRedMana(int amount)
		{
			mana[(int)ManaType.Red] += amount;
		}
		public void AddColourlessMana(int amount)
		{
			mana[(int)ManaType.Colourless] += amount;
		}
		public void RemoveWhiteMana(int amount)
		{
			mana[(int)ManaType.White] -= amount;
		}
		public void RemoveBlackMana(int amount)
		{
			mana[(int)ManaType.Black] -= amount;
		}
		public void RemoveBlueMana(int amount)
		{
			mana[(int)ManaType.Blue] -= amount;
		}
		public void RemoveGreenMana(int amount)
		{
			mana[(int)ManaType.Green] -= amount;
		}
		public void RemoveRedMana(int amount)
		{
			mana[(int)ManaType.Red] -= amount;
		}
		public void RemoveColourlessMana(int amount)
		{
			mana[(int)ManaType.Colourless] -= amount;
		}
	}
}
