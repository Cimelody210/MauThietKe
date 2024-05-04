using System;
using System.IO;
using System.Collections.Generic;

namespace Ex3
{

    // As we develop an accounting application, the requirement is to enable users to import data in various formats,
    // including Excel spreadsheets (Windows), Numbers spreadsheets (Mac), and QuickBook workbooks (special accounting software).
    // Future support for additional data formats is anticipated.
    public class Program
    {
        public static void Main(string[] args)
        {
            var excelReader = new ExcelReader();
            var numbersReader = new NumbersReader();
            var quickBooksReader = new QuickBooksReader();

            excelReader.SetNextReader(numbersReader);
            numbersReader.SetNextReader(quickBooksReader);

            excelReader.ReadData("example.xlsx");
            excelReader.ReadData("example.numbers");
            excelReader.ReadData("example.qbw");
            excelReader.ReadData("unsupported.txt");
        }
        public interface IDataReader
        {
            void ReadData(string filePath);
            void SetNextReader(IDataReader reader);
        }
        public class ExcelReader : IDataReader
        {
            private IDataReader? _nextReader;

            public void ReadData(string filePath)
            {
                if (filePath.EndsWith(".xlsx"))
                {
                    Console.WriteLine("Reading data from Excel spreadsheet");
                }
                else if (_nextReader != null)
                {
                    _nextReader.ReadData(filePath);
                }
                else
                {
                    Console.WriteLine("Unsupported data format");
                }
            }

            public void SetNextReader(IDataReader reader)
            {
                _nextReader = reader;
            }
        }
        public class NumbersReader : IDataReader
        {
            private IDataReader? _nextReader;

            public void ReadData(string filePath)
            {
                if (filePath.EndsWith(".numbers"))
                {
                    Console.WriteLine("Reading data from Numbers spreadsheet");
                }
                else if (_nextReader != null)
                {
                    _nextReader.ReadData(filePath);
                }
                else
                {
                    Console.WriteLine("Unsupported data format");
                }
            }

            public void SetNextReader(IDataReader reader)
            {
                _nextReader = reader;
            }
        }
        public class QuickBooksReader : IDataReader
        {
            private IDataReader _nextReader;

            public void ReadData(string filePath)
            {
                if (filePath.EndsWith(".qbw"))
                {
                    Console.WriteLine("Reading data from QuickBooks workbook");
                }
                else if (_nextReader != null)
                {
                    _nextReader.ReadData(filePath);
                }
                else
                {
                    Console.WriteLine("Unsupported data format");
                }
            }

            public void SetNextReader(IDataReader reader)
            {
                _nextReader = reader;
            }
        }

        //public class DataReader
        //{
        //    public void Read(string fileName)
        //    {
        //        if (fileName.EndsWith(".xls"))
        //        {
        //            Console.WriteLine("Reading data from an Excel spreadsheet.");
        //        }
        //        else if (fileName.EndsWith(".numbers"))
        //        {
        //            Console.WriteLine("Reading data from a Numbers spreadsheet.");
        //        }
        //        else if (fileName.EndsWith(".qbw"))
        //        {
        //            Console.WriteLine("Reading data from a QuickBooks file.");
        //        }
        //        else
        //        {
        //            throw new NotSupportedException("File format not supported.");
        //        }
        //    }
        //}

    }
}
