using System;
using System.Collections.Generic;
using System.Linq;

public class Poker : Deck
{

	public Poker()
	{
		CreateDeck();
		Shuffle();
	}
	
	public override List<Card> DealCards()
	{
		List<Card> output = new List<Card>();
		for (var i = 0; i < 5; i++)
		{
			output.Add(DrawOneCard());
		}

		return output;
	}
}