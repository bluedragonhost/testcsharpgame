using System;
using System.Threading;

namespace testcmdgame
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			//Introduction to the app and waits for a save to commence
			#region Intro to the app
			Console.WriteLine ("Hello and Welcome to the TestApp Game");
			#endregion
			Thread.Sleep (1000); 
			#region AutoSaveFeature
			Console.WriteLine ("This app has an autosave feature and will pause and save before continuing OK?");
			Console.ReadKey ();
			Thread.Sleep (1000); 
			Console.WriteLine ("The app has successfully saved");
			Thread.Sleep (500);
			#endregion
			#region Customise the Player
			//coming soon!
			#endregion
			#region ExplanationOfTheBeta
			//ask people to please report all bugs to the dev team
			Console.WriteLine ("This app is only in beta and may have some weirds bugs in it,");
			Thread.Sleep (1000); 
			Console.WriteLine ("To help the developers out please report all bugs to the issues page");
			Thread.Sleep (1000); 
			Console.WriteLine ("On Github, Thankyou!"); 
			Thread.Sleep (1000);
			#endregion
			#region GameStart
			//sao go!
			Console.WriteLine ("Link Start");
			Thread.Sleep (500);
			//enter the player credentials, until the beta is finished the players will sign in using a beta key
			Console.WriteLine ("Player Username: BETATESTPLAYER");
			//wait a bit to make the typing look realistic
			Thread.Sleep (500);
			//oh, wow what a interesting password!
			Console.WriteLine ("Player Password: abetaisfinetoo");
			//sleep the thread again
			Thread.Sleep (500);
			//say that the credentials are correct
			Console.WriteLine ("Credentials Correct!");
			Thread.Sleep (200);
			#endregion
			#region AfterGameStartIntro
			Console.WriteLine ("This game is like all others");
			Console.WriteLine ("It is intended to the played randomly by the cpu");
			Console.WriteLine ("The Player has no control over most of the game mechanics");
			Console.WriteLine ("The Player will be able to control some parts of the game but not others!");
			Console.WriteLine ("During the beta the Players will not be able to customise their character");
			Console.WriteLine ("The feature will be added though!");
			#endregion
			#region WelcomeToTheGame
			//the game asks the character what their name is
			Console.WriteLine ("Welcome to the game umm, what was your name again?");
			//Console.WriteLine ("[Info]- Please write your name below");

			//this is the set name for all beta players
			string nameofChar = "Jimmy";
			Console.WriteLine ("That's right your name is,");
			//references what your name is from the string value "nameofChar"
			Console.WriteLine (nameofChar);
			#endregion
			#region AppearancesEngine
			//this will introduce the player to the engine
			Console.WriteLine (nameofChar);
			Console.WriteLine ("What do you look like?");
			bool isBeta = true;
			string LookofChar = "!The Character Appearence Customisation will be unavailble during the Beta!";
			if (isBeta == true)
			{
				Console.WriteLine ("During the Beta, Nobody will be able to change the name value or the appearence of any character");
				Console.WriteLine ("OK?");
				Console.ReadKey ();
			}
			else
			{
				Console.WriteLine (LookofChar); 
			}
			#endregion
			#region BetaNotfication
			Console.WriteLine ("The Beta has commenced,");
			Console.WriteLine ("That means that the project is not fully finished");
			Console.WriteLine ("The game will surely have its fair share of bugs");
			Console.WriteLine ("During the Beta, the server will not accept changes in player looks or the name of the player");
			Console.WriteLine ("The Mainframe of the game lives in San Fransisco");
			Console.WriteLine ("During the Beta, Nobody will be able to interact with other players util we iron out all of the bugs");
			Console.WriteLine ("This is to be sure that nobody cheats.");
			Console.WriteLine ("Thankyou for reading this short messag!");
			Thread.Sleep (3000);
			Console.WriteLine ("Are you ready to continue the game?");
			Console.ReadKey ();
			#endregion




		}
	}
}
