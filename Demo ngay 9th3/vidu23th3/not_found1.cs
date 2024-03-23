using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace not_found1
{
	public class Program
	{
		public static void Main(string[] args)
		{
		    Console.WriteLine("--------------- Chat Room -------------!");
		    var person = new Person( Name = "Cristian");
		    person.FallIllEvent += Person_FallIllEvent;
		    person.CatchACold();
		    person.CatchACold();
		}
	}
	
	public class Person{
	  
	  public event EventHandler FallIllEvent;
	  public void CatchACold()
    {
      Console.WriteLine("CatchACold");
      Console.WriteLine("BS => ........");
      OnFallIllEvent();
    }
	}
	
	private static void Person_FallIllEvent(object render, EnventArgs args){
	  var person = render as Person;
	  var person1 = (Person)renderl;
	  Console.WriteLine("Call doctor at 12ABC");
	}
	public string Name {get;   set;}
  
  private void OnFallIllEvent()
  {
    FallIllEvent.Invoke(this, EnventArgs.Empty);
    
    // FallIllEvent.Invoke(this, new FallIllEventArgs{
    //   Address = "I GONNA TO NYC";
    // });
  }
	
}