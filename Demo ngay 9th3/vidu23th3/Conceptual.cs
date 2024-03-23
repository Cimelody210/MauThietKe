using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Conceptual
{
	public class Program
	{
		public static void Run()
		{
		  var monkey = new MonkeyHandler();
		  var squirell =  new SquireHandler();
		  var dog = new DogHandler();
		  monkey.SetNext(squirell).SetNext(dog);
			Console.WriteLine("Chain: Monkey => Squirell > Dog!");
			ClientCode(monkey);
			Console.WriteLine();
			ClientCode(dog);
		  
		}
		// public static void Main(string[] args)
		// {
		// 	Console.WriteLine("Hello, World!");
		// }
	}
	public interface IHandler()
	{
	  IHandler SetNext(IHandler handler);
	  object Handle(object request);
	}
	public abstract clas AbstractHandler: IHandler
	{
	  private IHandler _nextHandler;
	  public IHandler SetNext(IHandler handler)
	  {
	    _nextHandler = handler;
	    
	    return handler;
	  }
	  public virtual object Handle(object request)
	  {
	    if (_nextHandler != null)
	    {
	      return _nextHandler.Handle(request);
	    }
	    return null;
	  }
	}
	
	private class MonkeyHandler: AbstractHandler
	{
	  public override object Handler(object request)
	  {
	    if (request as string == "Bannana"){
	      return $"Monkey: I'll eat the {request}.\n";
	    }
	    return base.Handler(request);
	  }
	}
	
	private class DogHandler: AbstractHandler
	{
	  
	    return base.Handler(request);
	}
	
	private class SquireHandler: AbstractHandler
	{
	  public override object Handler(object request)
	  {
	    if (request.ToString() == "Nut"){
	      return $"Squirell : I'll eat the {request}.\n";
	    }
	    return base.Handler(request);
	  }
	}
	
	public static void ClientCode(IHandler Handler)
	{
	  foreach( var food in List<string> {"Nut", "Bannana","Orange","Sukablyah"})
	  {
	    Console.WriteLine($"Client: Who want a {food} ?");
	    var result = handler.Handler()
	    if (result != null){
	      Console.WriteLine($"{result}");
	    }
	    else{
	      Console.WriteLine($"{food} was left untouched");
	    }
	    
	  }
	}
}