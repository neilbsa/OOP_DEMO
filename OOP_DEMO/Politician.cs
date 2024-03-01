using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_DEMO;
public class Politician : Person
{
    public void Awake()
    {
        PrepareUrSelf();
    }


    public void GotoKitchen()
    {
        Eat();
    }

}
