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
		public class BankAccount
		
		public int Balance {get; set;}
		
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
		    Console.WriteLine("So du cua quy khach");
		  }
		}
	}
}