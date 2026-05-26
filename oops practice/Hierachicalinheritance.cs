using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Maharashtra
    {
       public void mh()
    {
        Console.WriteLine("Maharashtra is the best state in the world");
    }
    }

class pune : Maharashtra
{
    public void speciality()
    {
        Console.WriteLine("pune is the best city for live");
    }
}
    class mumbai : Maharashtra
    {   
        public void speciality()
        {
            Console.WriteLine("mumbai is the best city for work");
        }
    }
class Hierachicalinheritance
{
    public static void Main(string[] args)
    {
        pune p = new pune();
        p.speciality();
        p.mh();


        mumbai m = new mumbai();
        m.speciality();
        m.mh();


        Console.ReadLine();

    }
}

