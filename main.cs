using System;
using System.Collections.Generic;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {

		// CREATE AN APP THAT YOU CAN SELECT EITHER POKER, 21, OR WAR
		
		GameUI.MainMenu();
		
		BlackJack deck = new BlackJack();

		var hand = deck.DealCards();

		foreach (var card in hand)
		{
			Console.WriteLine($"{ card.Value.ToString() } of { card.Suit.ToString() }");
		}

		

    Console.ReadLine();
  }
}

public class GameUI
{
	public static int MainMenu()
	{
		Console.WriteLine();
		Console.WriteLine("---Welcome to the console Card Game Simulator!---");
		Console.WriteLine();
		Console.WriteLine("Please select what game your would like to play:");
		Console.WriteLine();
		GamesToPlay();
		int output = Convert.ToInt32(Console.ReadLine());
		Console.Clear();

		return output;
	}

	public static void GamesToPlay()
	{
		Console.WriteLine("1.) BlackJack");
		Console.WriteLine("2.) Poker");
		Console.WriteLine("3.) War");
	}
}

public class Logic
{

}











