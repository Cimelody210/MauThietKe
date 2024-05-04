using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Runtime.InteropServices;

namespace Bt1_2
{

    // Visitor
    // Cho phép định nghĩa các operation trên một tập hợp các đối tượng không đồng nhất về kiểu mà không làm thay đổi định nghĩa về lớp của các đối tượng đó.
    // Cho phép tách các thuật toán khỏi các đối tượng mà chúng hoạt động.
    // Giúp phục hồi lại kiểu dữ liệu bị mất (thay vì dùng instanceof).

    // Visistor sẽ hỗ trợ giải quyết vấn đề này bằng cách đặt hành vi mới vào một lớp riêng biệt được gọi là visitor, thay vì cố gắng tích hợp nó vào các lớp hiện có.
    // Đối tượng muốn thực hiện hành vi sẽ được truyền vào một trong các phương thức của visitor dưới dạng đối số,
        // cung cấp cho phương thức này quyền truy cập vào tất cả dữ liệu cần thiết có trong đối tượng
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Visitor pattern");
            var dot = new Dot(1, 10, 10);

            Console.WriteLine(dot.Export());
            Console.WriteLine();

            var visitor = new XmlExportVisitor();
            Console.WriteLine("Refactor the code using the strategy pattern. ");
            Console.WriteLine();
            Console.WriteLine(dot.Accept(visitor));
            Console.WriteLine();

            // tạo 1 list chứa các hình tròn vuông
            //List<Dot> dot_list = new List<Dot>
            //{
                
            //};
        }
    }
    public interface IShape
    {
        void Move(int x, int y);
        void Draw();
        string Export();
        //Refactor
        string Accept(IVisitor visitor);
    }
    
    public class Dot : IShape
    {
        public int Id { get; }
        public int X { get; }
        public int Y { get; }
        public Dot(int id, int x, int y)
        {
            Id = id;
            X = x;
            Y = y;
        }

        public string Accept(IVisitor visitor)
        {
            //Refactor
            return visitor.VisitDot(this);

            throw new NotImplementedException();
        }

        public void Draw()
        {
            //throw new NotImplementedException();
        }

        public string Export()
        {
            var ele = new XElement("dot", new XElement("id", Id), new XElement("x", X), new XElement("y", Y));
            
            return ele.ToString();
            //throw new NotImplementedException();
        }

        public void Move(int x, int y)
        {
            //throw new NotImplementedException();
        }
    }
    public interface IVisitor
    {
        string Accept(Dot dot);

        //Refactor
        string VisitDot(Dot dot);
    }
    public class XmlExportVisitor : XmlExportVisitorBase, IVisitor
    {
        public string Accept(Dot dot)
        {
            throw new NotImplementedException();
        }

        public string VisitDot(Dot dot)
        {
            var ele = new XElement("dot", new XElement("id", dot.Id), new XElement("x", dot.X), new XElement("y", dot.Y));
            return ele.ToString();
        }
    }

    public class XmlExportVisitorBase { }

    // Add other additional such as Circle, Rect«angle, and CompoundShape.
    public class Circle : Dot
    {
        public Circle(int id, int x, int y) : base(id, x, y)
        {
        }
    }
    public class Rectangle : Dot
    {
        public Rectangle(int id, int x, int y) : base(id, x, y)
        {
        }
    }
    public class CompoundShape : Dot
    {
        public CompoundShape(int id, int x, int y) : base(id, x, y)
        {
        }
    }
}
