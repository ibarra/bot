using System;
using Gtk;
using Sharkbite.Irc;

namespace Bot
{
	public partial class MainWindow: Gtk.Window
	{	
		private Connection connection;
		static string BotName = "Kakaroto";
		
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
			string server, channel, port;
			
			try{
				
				server = entryServer.Text;				
				
				if(server != ""){
										
					ConnectionArgs args = new ConnectionArgs(BotName, server);
					connection = new Connection(args,false, false);
					Identd.Start(BotName);
					connection.Connect();
					
					if(	connection.Connected ){
						textviewLog.Buffer.Text = "Conectado al irc . ";
					}
					
					 //Identd.Stop  ();
					
					connection.Listener.OnRegistered += new  RegisteredEventHandler  ( OnRegistered );
					connection.Listener.OnPublic += new  PublicMessageEventHandler  ( OnPublic );
					
				}else{				
					
					DialogError de = new DialogError();
					de.Run();
					de.Destroy();				
				}
				
			}catch(Exception bke){
				
				Console.WriteLine("Error on Connection " + bke.StackTrace.ToString());				
			}
			
		}
		
		public void OnPublic(UserInfo user, string channel, string message)
		{			
			//call other class for information. 
			connection.Sender.PublicMessage  ( "#gultij",BotName + "yo tengo el poder , pajitron COME POLLAS" );
			connection.Sender.PublicMessage("#gultij",  message.ToString());
		}
		
		public void OnRegistered()
		{
			try{
				
				Identd.Stop();
				connection.Sender.Join("#gultij");
				
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
			textviewLog.Buffer.Text = "Kakaroto Desconectado de la matrix ";
				
			}
		}
	
	}//end class.
}//end namespace
