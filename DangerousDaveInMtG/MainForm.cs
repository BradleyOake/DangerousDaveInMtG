/*
 * Created by SharpDevelop.
 * User: Brad
 * Date: 21-Nov-18
 * Time: 22:42
 * 
 * This is a shameless copyright infringement of Magic the Gathering
 */
using System;
using System.Windows.Forms;

namespace DangerousDaveInMtG
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			Player player1 = new Player();

			player1.deck.Shuffle();
			for(int i = 0; i < 7; i++)
			{
				player1.hand.Draw(player1.deck);
			}
			player1.hand.PlayCard(0, player1.battlefield);
			player1.battlefield.TapCard(0);
			//Card myCard = myDeck.Draw();
			//Card myCard2 = myDeck.Draw();
		//	lblOutput.Text = myCard.ToString();
		
			InitializeComponent();
		}
	}
}
