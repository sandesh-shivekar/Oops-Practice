//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//class company
//{
//    public  virtual void companybonus()
//    {
//        Console.WriteLine("Company provide a bonus of all staff");
//    }
//}
//class ceo: company
//{
//    public override void companybonus()
//    {
//        Console.WriteLine("CEO  provide a bonus of 5000 to all staff");
//    }
//}
//class hr: company
//{
//    public override void companybonus()
//    {
//        Console.WriteLine("Hr provide a bonus of 10000 to all staff");
//    }
//}
//class manager: company
//{
//    public override  void companybonus()
//    {
//        base.companybonus();
//        Console.WriteLine("Manager provide a bonus of 10000 to all staff");
//    }
//}
//     class methodoverridingtask1
//     {
//       public static void Main(string[] args)
//        {




//            manager m = new manager();
//            m.companybonus();

//            hr h = new hr();
//            h.companybonus();

//            ceo c = new ceo();
//            c.companybonus();

//    }
//}

