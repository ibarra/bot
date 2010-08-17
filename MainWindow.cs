using System;
using Gtk;
using Sharkbite.Irc;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
//using System.Runtime.Remoting.Channels.Tcp;

namespace Bot
{	
	public partial class MainWindow: Gtk.Window
	{	
		private Connection connection;
		public static string BotName = "Kakaroto";
		public static string channel = "";
		
		public MainWindow (): base (Gtk.WindowType.Toplevel)
		{
			//connection.Listener.OnPublic += new  PublicMessageEventHandler  ( OnPublic );
			//connection.Listener.OnPrivate += new PrivateMessageEventHandler ( OnPrivate );
			//connection.Listener.OnError += new ErrorMessageEventHandler ( OnError );
			Build ();			
		}
		
		protected void OnDeleteEvent (object sender, DeleteEventArgs a)
		{
			Application.Quit ();
			a.RetVal = true;
		}
	
		protected virtual void OnButton1Clicked (object sender, System.EventArgs e)
		{
			string server, port;
			
			try{
				
				server = entryServer.Text;				
				
				if(server != ""){										
					ConnectionArgs args = new ConnectionArgs(BotName, server);
					connection = new Connection(args,false, false);
					Identd.Start(BotName);
					connection.Connect();
					
					if(	connection.Connected ){
						textviewLog.Buffer.Text = "Conectado al irc . ";
						channel = entryChannel.Text;						
					}
					
					 //Identd.Stop  ();
					
					connection.Listener.OnRegistered += new  RegisteredEventHandler  ( OnRegistered );
					connection.Listener.OnPublic += new  PublicMessageEventHandler  ( OnPublic );
					connection.Listener.OnPrivate += new PrivateMessageEventHandler (OnPrivate );					
					connection.Listener.OnJoin += new JoinEventHandler(OnJoin);
					//connection.Listener.OnQuit += new QuitEventHandler(OnQuit);
					
				}else{								
					DialogError de = new DialogError();
					de.Run();
					de.Destroy();				
				}
				
			}catch(Exception bke){				
				Console.WriteLine("Error on Connection " + bke.StackTrace.ToString());				
			}
			
		}
		/*
		public void OnQuit(UserInfo user, string channel)
		{
			connection.Sender.PublicMessage(channel, "Ese " + user.Nick.ToString() + " Gay, te vas por tu paleta de platano ?.");
		}
		*/
		public void OnJoin(UserInfo user,  string channel)
		{
			connection.Sender.PublicMessage(channel, "Bienvenido " + user.Nick.ToString() );
		}
		
		public void OnPublic(UserInfo user, string channel, string message)
		{			
			Calls c = new Calls();
			string txt = c.CallPublic(user.Nick.ToString(), message, channel, connection);		
			textviewLog.Buffer.Text = txt.ToString();
						
			//connection.Sender.PublicMessage(channel, user + " " + "Cuando digas mi nombre lavate la boca ingenuo mortal");

			
		}
		public void OnPrivate(UserInfo user, string message)
		{
			Calls c = new Calls();
			c.CallPrivate(user.Nick.ToString(), connection);			
		
		}
		
		public void OnRegistered()
		{
			try{
				
				Identd.Stop();
				connection.Sender.Join(channel);
				connection.Sender.Nick("kakarotos");
				connection.Sender.PublicMessage("#gultij", "yo tengo el poder");
				
			}catch(Exception e){
				Console.WriteLine("Error in OnRegistered(): " + e.StackTrace.ToString());
			}				
		}

		protected virtual void OnQuitActionActivated (object sender, System.EventArgs e)
		{
			if(connection.Connected){
				
			connection.Disconnect("Mantenimiento");
				
			}
			Application.Quit();
		}

		protected virtual void OnCloseActionActivated (object sender, System.EventArgs e)
		{
			if(connection.Connected){				
				connection.Disconnect("por algo sera ");
				textviewLog.Buffer.Text = "Kakarotos Desconectado de la Matrix";				
			}
		}
		
		

		
	
	}//end class.
}//end namespace
