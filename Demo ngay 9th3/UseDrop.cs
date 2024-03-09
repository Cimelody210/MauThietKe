using System;
using System.IO;
using System.Text;
namespace Builder;
public static class UseDrop
{
    public static void Run()
    {
        var root =  HtmlElement("ul");
        var word =  new[] ("hello", "World");
         foreach(var word in words)
         {
            var li =  HtmlElement("li");
            // ko rõ chỗ này viết ntn
            li.Element.Add(new HtmlElement(""));
            sb.AppendFormat($"<li>{word}</li>");
            
         }
           

    }

}