﻿using System;

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
			#region AutoSaveFeature
			Console.WriteLine ("This app has an autosave feature and will pause and save before continuing OK?");
			Console.ReadKey ();
			Console.WriteLine ("The app has successfully saved");
			#endregion
			#region Customise the Player
			//coming soon!
			#endregion
			#region ExplanationOfTheBeta
			Console.WriteLine ("This app is only in beta and may have some weirds bugs in it,");
			Console.WriteLine ("To help the developers out please report all bugs to the issues page");
			Console.WriteLine ("On Github, Thankyou!"); 
			#endregion
			#region GameStart
			Console.WriteLine ("Link Start");
			Console.WriteLine ("Player Username: BETATESTPLAYER");
			Console.WriteLine ("Player Password: abetaisfinetoo");
			Console.WriteLine ("Credentials Correct!")
			#endregion




		}
	}
}
