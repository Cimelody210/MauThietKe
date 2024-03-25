using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace not_found2
{
	public class Program
	{
		public static void Main(string[] args)
		{
		  dynamic person = new{
		    Name  ="d"
		    Age = 112
		  }
		  var anon = new {
		    Deposit = ReturnVoid.Argument<int>(amount => {
		      Console.WriteLine($ "Deposit" + {amount});
		    }),
		    WithDraw =  Return<bool>.Argument<int>(amount =>{
		      Console.WriteLine($ "WithDraw" + {amount});
		      return amount >= 500;
		      
		    })
		  };
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
	
	public interface IBankAccount{
	  
	  void Deposit(int amount);
	  void WithDraw(int amount);
	}
	public class BankAccount: IBankAccount{
	  private const int OverdrafLimit = -500;
	  private int _balance;
	  
	  public void Deposit(int amount){
	    _balance += amount;
	    Console.WriteLine($ "Deposit  {amount}, balance is now {_balance}");
	  }
	  public bool WithDraw(int amount){
	    if(_balance -  amount >= OverdrafLimit){
	      _balance -= amount;
	      Console.WriteLine("WithDraw"+ {amount} + "_balance is now"+ {_balance});
	      return this;
	    }
	    return false;
	  }
	  public override string ToString(){
	    return $ "{nameof(_balance)}: {_balance}";
	  }
	}
	
	public class Log<T>: DynamicObject where T: class, new()
	{
	  public Log(T, subject)
	  {
	    _subject = subject;
	  }
  	private readonly ConcurrentDictionary<string, int>_methodCallCount = new();
	  private readonly T _object;
  	public static TInterface As<TInterface>() where TInterface: class
  	{
  	  if (!typeof(TInterface).IsInterface())
  	  {
  	    throw new ArgumentExecption("TInterface must be an interface type");
  	  }
  	  return new Log<T>(new T()).ActLike<TInterface>();
  	}
  	public override bool TryInvokeMember( InvokeMemberBindler binder, object[] args)
  	{
  	  
  	}
	}
	
	
	
}