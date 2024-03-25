using System;
using System.IO;
using System.Data.Generic;
using System.Entity;
// Thẻ Ul và li

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Try programiz.pro");
    }
    Console.WriteLine(nameof(WithoutBuilder()));
    var hello = "hello";
    var sb = new StringBuilder();
    sb.Append("<p>");
    sb.Append(hello);
    sb.Append("</p>");
    //
    Console.WriteLine (sb.ToString());
    sb.Append("<ul>")
    var word =  new[] ("hello", "World");
    foreach(var word in words){
        sb.AppendFormat($"<li>{word}</li>");
    }
    sb.Append("</ul>")
    Console.WriteLine (sb.ToString());
    
        
}
