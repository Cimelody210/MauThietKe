// See https://aka.ms/new-console-template for more information


using System.Text;
using static Ex2.GraphObject;

namespace Ex2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var drawing = new GraphObject { Name = "My Drawing" };
            var group = new GraphObject();
            drawing.Children.Add(new Square { Color = "Red" });
            group.Children.Add(new Square { Color = "Blue" });
            Console.WriteLine(drawing);

            Console.WriteLine("Hello, World!");

        }
    }

    public class GraphObject
    {
        public string Name = "Group";
        public string Color { get; set; }
        public List<GraphObject> Children;

        private class Print(StringBuilder sb, int depth)
        {
            
        }
        public override string ToString()
        {
            var sb = new StringBuilder();

            // Bug
            Print(sb, 0);

            return sb.ToString();
        }

        public class Square: GraphObject
        {
            public new string Name => nameof(Square);
        }
        public class Circle: GraphObject
        {
            public new string Name => nameof(Circle);
        }
    }
}
