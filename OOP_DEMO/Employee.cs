using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_DEMO;
public class Employee : Person
{

    public void WriteToBulitin(string message)
    {
        Console.WriteLine(message);
    }

    public void WriteToBulitin(string message, DateTime postedDate)
    {
        Console.WriteLine($"{message} dated: {postedDate}");
    }

}









//encapsulation
//Abstraction
//Inheritance
//Polymorphism
//GENERICS

public class Officer : Employee
{
  public void DoWork()
    {
        WriteToBulitin("Please proceed to conference");
    }
}


public class Personel: Employee
{
    public void DoWork()
    {
        WriteToBulitin("Ive been here in conference but no one is around", DateTime.Now);
    }
}