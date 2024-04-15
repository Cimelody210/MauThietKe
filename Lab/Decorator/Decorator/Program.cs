using System;
using System.IO;
using System.Data.Common;
using System.Text.RegularExpressions;

namespace Decorator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var ds = new FileDataSource("salary.dat");
            
            Console.WriteLine("Hello, World!");
        }
    }
    public interface IDataSource
    {
        
        public class WriteData(string data) {

        }
        void ReadData() { }

    }
    public class FileDataSource : IDataSource
    {
        private string fileName;
        public FileDataSource(string fileName)
        {
            this.fileName = fileName;
        }

        public class WriteData(string data)
        {

        }
    }

    public class LoggingDecorator : IDataSource
    {

        private IDataSource source;

        private readonly IDataSource _dataSource;
        //private readonly ILogger _logger;

        public LoggingDecorator(IDataSource source)
        {

            this.source = source;
        }

        public void WriteData(string data)
        {
            var plantTextBytes = System.Text.Encoding.UTF8.GetBytes(data);
            var basedTostring = Convert.ToBase64String(plantTextBytes);

            var destPath = Path.Combine("saves", "data", "data.bat");
        }

        public class ReadData(string data)
        {

        }
    }

    public class EncryptionDecorator : IDataSource
    {
        private IDataSource source;
        public EncryptionDecorator(IDataSource source)
        {
            this.source = source;

        }
        public class WriteData(string data)
        {

        }

        public class ReadData(string data)
        {

        }

    }
    public class CompressionDecorator
    {
        private IDataSource source;
        public CompressionDecorator(IDataSource source)
        {

        }
        public class WriteData(string data)
        {

        }

        public class ReadData(string data)
        {

        }
    }
}