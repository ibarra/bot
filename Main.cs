using System;
using Gtk;
using Sharkbite.Irc;


namespace Bot
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			//connection.Listener.OnError += new ErrorMessageEventHandler ( OnError );
			MainWindow win = new MainWindow ();
			win.Show ();
			Application.Run ();
		}
	}
}