
using System;
using System.Collections.Generic;
using Sharkbite.Irc;
using System.Net;
using System.IO;




namespace Bot
{	
	
	public class Calls
	{
		
		public Calls()
		{
		}
		
		public string CallPublic(string user, string message, string channel, Connection connection){
			
			if (message.Contains("kakaroto") == true)			{
				
				connection.Sender.PublicMessage(channel, user + " " + "Cuando digas mi nombre lavate la boca ingenuo mortal");
				Console.WriteLine(channel);				
				                                
			}
			
			if (message.StartsWith("@google") )
			{ 				
				connection.Sender.PublicMessage(channel, "lo siento mi pequeño humano " + user 
				                                + " Aun no busgo en google, Solo en YouPorn.com ");
				connection.Sender.PublicMessage(channel, "Asi que putas para todos, nano para Presidente Mundial");
								
			}
			
			if(message.StartsWith("@come") && user.Equals("mic_")){
				int l = message.Length;
				
				Console.WriteLine(l);
				

		        //
		        // Split string on spaces.
		        // ... This will separate all the words.
		        //
	        	string[] words = message.Split(' ');
	        	foreach (string word in words)
	        		{
	            		Console.WriteLine(word);
	        		}	

				
				message.IndexOf("!");
				
				return "aprendiendo a comer palabras ";
				
			}
			
			return user + "-" + message + "-" + channel;
			
		}
		
		public void CallPrivate(string user, Connection connection)
		{
			connection.Sender.PrivateMessage(user, "Ingenuo mortal ahorita estoy atendiendo asuntos privados, no molestes");
		}
		
	}
}
