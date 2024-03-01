using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_DEMO;

public interface IPerson
{
    void Cook();
    void Prepare();
     void Cleanup();
}

public abstract class Person : IPerson
{

    public string Firstname { get; set; }
    public int Age { get; set; }
    public string Lastname { get; set; }


  



    public void PrepareUrSelf()
    {
        Cleanup();
    }



    public void Speak()
    {

    }
    public void Run()
    {

    }
    public void Eat()
    {
        Cook();
        Prepare();
        Cleanup();
    }

    public void Cook()
    {
        Console.WriteLine("Cooking");
    }

    public void Prepare()
    {
        Console.WriteLine("Preparing");
    }

    public void Cleanup()
    {
        Console.WriteLine("Doing clean up");
    }
}
