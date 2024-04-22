using System;
using System.IO;
using System.Data.Common;
using System.Text.RegularExpressions;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Runtime.InteropServices.Marshalling;

namespace Ex1
{

    // Chain of Responsibility là một mẫu thiết kế thuộc nhóm hành vi (Behavioral Pattern).
    // Mục đích: cho phép một đối tượng gửi một yêu cầu nhưng không biết đối tượng nào sẽ nhận và xử lý nó.
    // Điều này được thực hiện bằng cách kết nối các đối tượng nhận yêu cầu thành một chuỗi (chain) và gửi yêu cầu theo chuỗi đó cho đến khi có một đối tượng xử lý nó.

    // Implement the Chain of Responsibility pattern using the following example
    public class Program
    {
        public static void Main(string[] args)
        {
            var squirrel = new SquirrelHandler();
            var monkey = new MonkeyHandler();
            var dog = new DogHandler();

            monkey.SetNext(squirrel).SetNext(dog);

           
            Console.WriteLine("Chain: Monkey > Squirrel > Dog\n");
            //ClientCode(monkey);

            Console.WriteLine("Subchain: Squirrel > Dog\n");
            //ClientCode(dog);

        }
    }
    

    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        object Handle(object request);
    }
    public abstract class AbstractHandle : IHandler
    {
        //public virtual class Handle(object request) { }
        //public class SetNext(IHandler handler) { }
        //public abstract object Handle(object request);
        //public abstract IHandler SetNext(IHandler handler);
        private IHandler? _nextHandler;
        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;
            return handler;
        }
        public virtual object Handle(object request)
        {
            if (_nextHandler != null)
            {
                return _nextHandler.Handle(request);
            }

            return null;
        }
    }
    public class SquirrelHandler : AbstractHandle
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "Nut")
            {
                return $"Squirrel: I'll eat the {request}.\n";
            }

            return base.Handle(request);
        }
    }
    public class DogHandler : AbstractHandle
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "MeatBall")
            {
                return $"Dog: I'll eat the {request}.\n";
            }

            return base.Handle(request);
        }
    }
    public class MonkeyHandler : AbstractHandle
    {
        public override object Handle(object request)
        {
            if (request as string == "Banana")
            {
                return $"Monkey: I'll eat the {request}.\n";
            }

            return base.Handle(request);
        }
    }
}
