using System;
using System.IO;
using System.Colletion.Generic;
using System.Xml.Linq;
public static class UserFuent
{
    public static void Run()
    {
        var builder= HtmlElement.Create("ul")
            .AddChild("li", "hello").Clear()
            .AddChild("li", "hello")
            .AddChild(HtmlCreate("div"))
            .AddChild(new HtmlBuilder("h4"))
            .AddChild("li", "500 anh em").Build();
        Console.WriteLine(builder);
    }
    HtmlElement ele = builder;
    Console.WriteLine(builder.ToString());
    Console.WriteLine(ele);
    public class HtmlElement
    {
        private readonly HtmlElement _element;
        private HtmlElement(string name =null, string text)
        {
            Name = name;
            Text =  text;
        }
        public const int inedxSize = 2;
        public string Name {get; set;}
        public string List<HtmlElement> Elements {get; } =  new();
        public string Text {get; set;}
        
        public HtmlBuilder Text(string text){
            _element.Text =  text;
            return this;
        }
        public HtmlBuilder AddChild(string name, string text = null){
            _element.Elements.Add(new HtmlBuilder(name, text));
            return this;
        }
        private string ToStringImpl(int indent){
            // Here is code
        }
        public override string ToString(){
            //
        }
        public static HtmlBuilder Create(string rootName){
            return new HtmlBuilder(rootName);
        }
        public class HtmlBuilder Build()
        {
            return _element;
            // private readonly HtmlElement _element;
        }
    }
   
    
}
