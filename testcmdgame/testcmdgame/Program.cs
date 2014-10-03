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
			//let the game begin
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
			Thread.Sleep (1000);
			Console.WriteLine ("It is intended to the played randomly by the cpu");
			Thread.Sleep (1000);
			Console.WriteLine ("The Player has no control over most of the game mechanics");
			Thread.Sleep (1000);
			Console.WriteLine ("The Player will be able to control some parts of the game but not others!");
			Thread.Sleep (1000);
			Console.WriteLine ("During the beta the Players will not be able to customise their character");
			Thread.Sleep (1000);
			Console.WriteLine ("The feature will be added though!");
			Thread.Sleep (1000);
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
			//this is the start of the game
			// I Promise
			// Really I will start this time
			#region BetaNotfication
			//this will tell the user about how the beta is going to work!
			Console.WriteLine ("The Beta has commenced,");
			Thread.Sleep (3000); 
			Console.WriteLine ("That means that the project is not fully finished");
			Thread.Sleep (3000);
			Console.WriteLine ("The game will surely have its fair share of bugs");
			Thread.Sleep (3000);
			Console.WriteLine ("During the Beta, the server will not accept changes in player looks or the name of the player");
			Thread.Sleep (3000);
			Console.WriteLine ("The Mainframe of the game lives in San Fransisco");
			Thread.Sleep (3000);
			Console.WriteLine ("During the Beta, Nobody will be able to interact with other players util we iron out all of the bugs");
			Thread.Sleep (3000);
			Console.WriteLine ("This is to be sure that nobody cheats.");
			Thread.Sleep (3000);
			Console.WriteLine ("Thankyou for reading this short message!");
			Thread.Sleep (3000);
			Console.WriteLine ("Are you ready to continue the game?");
			Console.ReadKey ();
			#endregion
			#region BeginFirstPart
			//introduce the player to they're surroundings
			Console.WriteLine ("You have spawned in a beatiful forest");
			Thread.Sleep (1000); 
			Console.WriteLine ("There are beautiful things to look at everywhere,");
			Thread.Sleep (1000);
			Console.WriteLine ("But you do not have the time to look around!");
			Thread.Sleep (1000);
			//explain the meaning of being here
			Console.WriteLine ("Do you know why you are here");
			Thread.Sleep (1000);
			Console.WriteLine ("No, I do not!");
			Thread.Sleep (1000);
			Console.WriteLine ("That's weird I thought I told you why you were here, oh well");
			Thread.Sleep (1000);
			Console.WriteLine (nameofChar);
			Thread.Sleep (1000);
			Thread.Sleep (1000);
			Console.WriteLine ("Walks along the forest floor before him,");
			Thread.Sleep (1000);
			Console.WriteLine ("Wow, this place is HUGE");
			Thread.Sleep (1000);
			Console.WriteLine ("Actually Sir, It is quite small if you ask me!"); 
			Thread.Sleep (1000);
			#endregion
			#region SecondPart
			Console.WriteLine ("You continue walking along a Path that is very wet like it has rained not long ago");
			Thread.Sleep (1000);
			Console.WriteLine ("What do you do next");
			Thread.Sleep (1000);
			Console.WriteLine ("You Say:");
			Thread.Sleep (1000);
			Console.WriteLine ("I continue walking!");
			Thread.Sleep (1000);
			Console.WriteLine ("What do you do next, A. There infront of you a ice cream van has spawned or B. Do you walk down this very boring path");
			Thread.Sleep (1000);
			Console.WriteLine ("You can pick either a or b for this one.");
			Thread.Sleep (1000);
			// The Player can pick for themselves in this bit
			ConsoleKeyInfo keyInfo;
			while ((keyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape)

			{

				switch (keyInfo.Key)

				{

				case ConsoleKey.A:

					Console.WriteLine ("You have been captured and killed by a person hiding in the ice cream van!");
					Console.WriteLine ("You have died, please close and re-open the app to start over again");
					break;


				case ConsoleKey.B:

					Console.WriteLine ("You have survived the choice and you are of full health");
					break;
				}

			#endregion





		}
	}
	}}

