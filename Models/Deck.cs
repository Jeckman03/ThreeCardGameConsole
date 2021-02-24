using System;
using System.Collections.Generic;
using System.Linq;

public abstract class Deck
{
	// DIFFERENT TYPE OD DECKS
	public List<Card> fullDeck = new List<Card>();
	public List<Card> discardPile = new List<Card>();
	public List<Card> drawPile = new List<Card>();

	public void CreateDeck()
	{
		// Clear the deck incase there is already on in play
		fullDeck.Clear();

		// Build deck by adding cards to it
		for (var suit = 0; suit < 4; suit++)
		{
			for (var value = 0; value < 13; value++)
			{
				// Add a card to the deck
				fullDeck.Add(new Card { Suit = (CardSuit)suit, Value = (CardValue)value });
			}
		}
	}

	public void Shuffle()
	{
		Random rnd = new Random();
		drawPile = fullDeck.OrderBy(x => rnd.Next()).ToList();
	}

	public virtual Card DrawOneCard()
	{
		// Take the first card on drawPile
		Card output = drawPile.Take(1).First();
		// Remove that card from the drawPile list
		drawPile.Remove(output);

		return output;
	}

	public abstract List<Card> DealCards();
}