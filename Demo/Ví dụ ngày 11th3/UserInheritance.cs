using System;
using System.Collection.Generic;
using System.Text;
using System.Xml.Linq;

public class UserInhertitance
{
    public static void Run(){
        var bulider = new Builder();
        bulider.Name("ctk45").Genre("N").CompanyName("FPT").Position("Designer").Builder();
        Console.WriteLine(bulider);
    }
    // public class Person
    // record: in ra 1 kieu list, giong dang Python
    public record Person
    {
        // Info
        private string Name {get; set;}
        private string Genre  {get; set;}
        // Dia chi
        private string CompanyName  {get; set;}
        private string Position  {get; set;}
    }
}
public Builder: PersonJobBuilder<Builder>
{

}
public abstract class PersonBuilder
{
    protected person person = new();
    public PersonBuilder Builder(){ return person;}

}
public class PersonInfoBuilder<T>: PersonBuilder where T: PersonInfoBuilder<T>
{
    // Các _person sẽ lỗi nếu để thành private Person _person = new();
    // Chuyển thành protected thì hết error 
    // protected Person _person = new();
    // private readonly PersonBuilder _genericBUilder =  new PersonBuilder();

    protected Person person = new();

    public PersonBuilder PersonBuilder{
        get {return _genericBUilder;}
    }

    public T Name(string name)
    {
        // _person.Name =  name;
        // PersonBuilder.person.Name =  name;

        person.Name =  name;
        return (T)this;
    }
    public T Genre(string  genre)
    {
        // _person.Genre =  genre;
        // PersonBuilder.person.Genre =  genre;
        
        person.Genre =  genre;
        return (T)this;
    }

}
public class PersonAddressBuilder
{
    private PersonBuilder _person = new();
    public PersonAddressBuilder Position(string position)
    {
        person.Position =  position;
        return this;
    }
    public PersonAddressBuilder CompanyName(string companyName)
    {
        person.Position =  companyName;
        return this;
    }

}
public class PersonJobBuilder<T> PersonInfoBuilder where T: PersonJobBuilder<T>
{
    public T Position(string position){
        person.Position =  position;
        return (T)this;
    }

    public T CompanyName(string companyName){
        person.CompanyName =  companyName;
        return (T)this;
    }
}
