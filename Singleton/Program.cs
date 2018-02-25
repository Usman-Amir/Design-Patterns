using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
	public class MarioGame
	{
		private static MarioGame MarioPlayerInstance;

		public string name;

		// we make the contructor as private so nobody can't instantiate the object of class like new class()
		private MarioGame()
		{
			name = "Default Player";
		}
		//make the method as public so you dont have to create an instance of class in order to call this method.
		public static MarioGame GetInstance()
		{
			if (MarioPlayerInstance == null)
			{
				MarioPlayerInstance = new MarioGame();
			}
			return MarioPlayerInstance;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			MarioGame player1 = MarioGame.GetInstance();
			MarioGame player2 = MarioGame.GetInstance();
			Console.WriteLine(player1 == player2 ? $"The only instance for the game player is { player1.name}" : $"Both the instance are not same as : {player1.name} and {player2.name}");
		}
	}
}
