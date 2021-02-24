using System;
using System.Collections.Generic;
using System.Linq;

public class BlackJack : Deck
{
	public BlackJack()
	{
		CreateDeck();
		Shuffle();
	}

	public override List<Card> DealCards()
	{
		List<Card> output = new List<Card>();
		for (var i = 0; i < 2; i++)
		{
			output.Add(DrawOneCard());
		}

		return output;
	}
}