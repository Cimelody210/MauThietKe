using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CommandPattern
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Command pattern");
		}
		public class BankAccount{
		  public int Balance {get; set;}
		  public string Name {get; set;}
		}
		
		
		public void Deposit(int amount)
		{
		  Balance += amount;
	  	  Console.WriteLine($ "Deposit"+ {amount} + "Balance = " {Balance});
		}
		
		public void WithDraw(int amount){
		  if (Balance >= amount)
		  {
		    Balance -= amount;
		    Console.WriteLine( $ "Deposit ="+ {amount}+ "Balance = "+ {Balance});
		  }
		  else{
		    Console.WriteLine("So du cua quy khach khong du");
		  }
		}
		public interface ICommand{
		  void Call();
		  void Undo();
		}
		public void BankAccountCommand: ICommand{
		  private readonly BankAccount _ba;
		  private readonly BankAccount _action;
		  private readonly int _amount;
		  public BankAccountCommand(BankAccount ba, BankAccount action, int amount)
		  {
		    _ba = ba;
		    _action =  action;
		    _amount =  amount;
		  }
		  public void Call(){
		    _ba.Deposit(_amount);
		    switch(_amount)
		    {
		      case
		    }
		  }
		  public void Undo(){
		    // throw new.NotImpelmentedException();
		    _ba.WithDraw(_amount);
		  }
		}
	}
}