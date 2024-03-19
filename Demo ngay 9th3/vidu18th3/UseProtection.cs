using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Proxy
{
	public class UseProtection
	{
		public static void Run()
		{
		  var car = new CarProgy(new Driver { Age = 12});
		  car.Drive();
			Console.WriteLine("Hello, World!");
		}
		public interface ICar
		{
		  void Drive();
		}
		
		public class Car: ICar
		{
		  public void Drive()
		  {
		    Console.WriteLine("car is being driven");
		  }
		}
		
  	public class Driver
  	{
  	  public int Age {get; set;}
  	}
  	
  	public class CarProgy: Driver
  	{
  	  private readonly Driver _driver;
  	  private readonly Car _car = new();
  	  
  	  public CarProgy(Driver driver)
  	  {
  	    _driver = driver;
  	  }
  	  public void Drive()
  	  {
  	    if (_driver.Age >= 18){
  	      _car.Drive();
  	    }
  	    else{
  	      Console.WriteLine("Too young");
  	    }
  	  }
  	}
	}
}