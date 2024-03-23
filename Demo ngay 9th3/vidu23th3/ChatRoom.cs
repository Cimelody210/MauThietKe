using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ChatRoom
{
	public class Program
	{
		public static void Run()
		{
			Console.WriteLine("--------------- Chat Room -------------!");
			var person1 = new Person( Name = "Vu Viet Hoang");
			var person2 = new Person( Name = "LOD2386");
			var person3 = new Person( Name = "Tuyên Đức");
		  var room1 = new ChatRoom();
		  room1.Join(person1);
		  room1.Join(person2);
		}
	}
	internal class Person
	{
	  public string Name {get;   set;}
	  public ChatRoom Room {get;   set;}
	  public void Receive(string source, string message)
	  {
	    Console.WriteLine($ "{source}: -> {Naeme}:  {message}");
	  }
	  public void Say(string message)
	  {
	    Room.BroadCast(Name, message);
	    
	  }
	  public void PrivateMessage(string who, string message)
	  {
	    Room.Message(Name, who, message);
	  }
	}
	class ChatRoom
	{
	  public List<Person> People {get; set;} = new List<Person>();
	  public void Join(Person person)
	  {
	    People.Add(person);
	    person.Room  = this;
	    
	  }
	  public void BroadCast(string source, string message)
	  {
	    foreach (Person person in People.Where( x => x.Name != source))
	    {
	      Message(source, person.Name, message);
	    }
	  }
	  public void Message(string source, string message, string dest)
	  {
	    
	    People.FirstOrDefaut(x = > x.Name == dest)?.Receive(source, message);
	    
	  }
	}
}