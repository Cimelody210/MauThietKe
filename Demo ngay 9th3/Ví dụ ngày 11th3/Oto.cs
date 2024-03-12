using System;
using System.Collection.Generic;
using System.Text;
using System.Xml.Linq;

public class Oto
{
    public static void Run(){
        // The lack of function: ofType, WithWheel
        var car =  CarBuilder.Create().ofType(CarType.Mercedes_G200)
            .WithWheels(16)
            .Build();
        Console.WriteLine(car);
    }
    public enum CarType
    {
        Sedan, Innova, Camry, Land_Cruiser, G63, Mercedes_G200
    }
    public record Car
    {
        private CarType Type {get; set;}
        private int WheelSize  {get; set;}
    }
}
public interface IBuilderCar { Car.Build();}
public interface ISpecificCarType{

}
public interface ISpecificWheelType{
    IBuilderCar (int size);
}
public static class CarBuilder
{
    public static Impl Create(){ return new Impl();}
}
public class ToImpl: ISpecificCarType, ISpecificWheelType, IBuilderCar
{
    private Car _car =  new Car();
    
    public ISpecificCarType ofType(CarType type){
        _car.Type = type;
        return this;
    }
    public IBuilderCar WithWheels(int size)
    {
        switch(_car.Type){
            case CarType.Sedan when size !=16:
            case CarType.Mercedes_G200 when size > 18 or size <30:
                throw new ArgumentException('Invalid size: ');
        }
        _car.WheelSize = size;
        return this;
    }
    public Car Build(){ return _car;}
    
}
