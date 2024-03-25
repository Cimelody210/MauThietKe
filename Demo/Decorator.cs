using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using static System.Runtime.InterService.JavaScript.JSType;

namespace Decorator
{
	public class Program
	{
		public static void Main(string[] args)
		{
		  var ds = new EncryptionDecorator(new LoggingDecorator(new FileDataSource()));
		  ds.Write("10");
		  var data = ds.ReadFile();
		  Console.WriteLine("Output = "+ data);
		}
		
		interface IFileDataSource
		{
		  void Write(string data);
		  string ReadFile();
		}
		
		class LoggingDecorator: IFileDataSource
		{
		  private readonly IFileDataSource _ifds;
		  public LoggingDecorator(IFileDataSource ds)
		  {
		    _ifds = ds;
		  }
		  public string ReadFile()
		  {
		    Console.WriteLine("Load readline ...");
		    _ifds.ReadFile();
		    Console.WriteLine("Log read done ...");
		  }
		}
		
		class FileDataSource: IFileDataSource
		{
		  private readonly string _filename;
		  
		  public FileDataSource(string filename)
		  {
		    _filename = filename;
		  }
		  public void Write(string data)
		  {
		    Console.WriteLine("Encoding...");
		    
		    var plantTextBytes = System.Text.Encoding.UTF8.GetBytes(data);
		    var basedTostring = Convert.ToBase64ToString(plantTextBytes);
		    
		    var destPath = Path.Combine("saves", "data", "data.bat");
		    Directory.CreateDirectory(Path.GetDirectoryName(destPath));
		    
		    using var ms = new StreamWrites(destPath, false);
		    ms.Write(basedTostring);
		  }
		  
		}
	}
}