//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


// class methodoverloading
// {
//    void bill_payment() //1) passing no parameter
//    {
//        Console.WriteLine("Bill Payment of Electricity Bill");
//    }
//    void bill_payment(int amount)// 2) passing parameter
//    { 
//        Console.WriteLine("Bill payment is water bill = "+amount) ;

//    }
//    void bill_payment(int a , string amount)// 3) passing more than one parameter
//    {
//        Console.WriteLine("Bill payment of telephone bill ="+a +amount);
//    }
//    void bill_payment(string name) // 4) by changing the datatype of paramenter
//    {
//        Console.WriteLine("Bill payment of credit card bill="+name);
//    }
//    void bill_payment(string amount , int a) // 5) by changing the sequence of parameter
//    {
//        Console.WriteLine("Bill payment of gas bill is ="+amount +a);
//    }
//    public static void Main(string[] args)
//    {
//        methodoverloading m = new methodoverloading();
//        m.bill_payment();
//        m.bill_payment(500);
//        m.bill_payment(1000, "water bill");
//        m.bill_payment("credit card bill");
//        m.bill_payment("gas bill", 2000);
//    }
//}

