using System;
using System.IO;
using System.Data.Generic;
using System.Entity;
public static class UserFuent
{
    public static void Run()
    {
        var builder= HtmlElement.Create("ul")
        .AddChild("li", "hello").Clear()
        .AddChild("li", "hello")
        .AddChild("li", "500 anh em");
    }
    HtmlElement ele = builder;
    Console.WriteLine(builder.ToString());
    Console.WriteLine(ele);
    public class HtmlElement
    {
        private HtmlElement(string name =null, string text)
        {
            Name = name;
            Text =  text;
        }
    }
    
}
