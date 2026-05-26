//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//class ObjectClass
//{
//    string buscolour;
//    int seats;
//    int lights;
//    int busnumber;

//    void bus()
//    {

//        Console.WriteLine("What is number of this Bus?");
//        int busnumber = int.Parse(Console.ReadLine());
//        Console.WriteLine("Bus number is :" +busnumber);

//        Console.WriteLine("Which Location You are going ?");
//        string location = Console.ReadLine();
//        Console.WriteLine("You are going to " + location);
//    }
//    public static void Main(string[] args)
//    {
//        ObjectClass obj = new ObjectClass();
        
//        Console.WriteLine("Enter the colour of  bus :");
//        obj.buscolour = Console.ReadLine();
        

//        Console.WriteLine("Enter the seats of  bus :");
//        obj.seats= int.Parse(Console.ReadLine());
        

//        Console.WriteLine("Enter the lights of  bus :");
//        obj.lights = int.Parse(Console.ReadLine());

//        obj.bus();

//        Console.WriteLine("-------------------------------------");


//        Console.WriteLine("Bus colour is :"+obj.buscolour);
//        Console.WriteLine("Bus seats is :" + obj.seats);
//        Console.WriteLine("Bus lights is :" + obj.lights);
       
//    }

//}