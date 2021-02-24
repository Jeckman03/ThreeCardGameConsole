using System;
using System.Collections.Generic;
using System.Linq;

public class War : Deck
{
	public War()
	{
		CreateDeck();
		Shuffle();
	}

	public override List<Card> DealCards()
	{
		List<Card> output = new List<Card>();
		for (var i = 0; i < 1; i++)
		{
			output.Add(DrawOneCard());
		}

		return output;
	}
}