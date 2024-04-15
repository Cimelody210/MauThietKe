using System;
using System.IO;
using System.Data.Common;
using System.Text.RegularExpressions;
using System.IO.Compression;

namespace Decorator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var ds = new FileDataSource("salary.dat");

            Console.WriteLine("Hello, World!");
            Console.WriteLine(ds.ToString());
        }
    }

    public interface IDataSource
    {
        public class WriteData(string data)
        {

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

        private IDataSource _source;
        //private readonly ILogger _logger;

        //var ds = new LoggingDecorator(new FileDataSource("salary.dat"));

        public LoggingDecorator(IDataSource source)
        {

            _source = source;
        }

        public void WriteData(string data)
        {

            var plantTextBytes = System.Text.Encoding.UTF8.GetBytes(data);
            var basedTostring = Convert.ToBase64String(plantTextBytes);

            var destPath = Path.Combine("saves", "data", "salary.bat");
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
        private  IDataSource source;

        // Cung cấp khả năng giải nén sau khi đọc file
        public CompressionDecorator(IDataSource source)
        {
            this.source= source;
        }
        public string WriteData(string data)
        {
            using (MemoryStream memorystream = new MemoryStream())
            {
                using (GZipStream gzips = new GZipStream(memorystream, CompressionMode.Compress))
                {
                    using (StreamReader sR = new StreamReader(gzips))
                    {
                        return sR.ReadToEnd();
                    }
                }
            }

        }
    }

   
}

