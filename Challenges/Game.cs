using System;
public class Game
{
	public void Start()
	{
		Console.WriteLine("Game started");
		Console.WriteLine("What is your name");
		string name = Console.ReadLine();
		Character player = new Character(name, 3 , true);
		Character enemy = new Character("orc", 1, false);

		player.Attack(enemy);
		enemy.Attack(player);
		
	}
}