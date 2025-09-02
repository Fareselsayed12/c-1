using FirstCCharp.Core;
using System.Diagnostics;
using SharedClass = FirstCCharp.Services.SharedClass;




namespace FirstCCharp.Core
{

    class Program
    {
        static void Main(string[] args)
        {
            // 1) Fully qualified namespace
            FirstCCharp.Utilities.SharedClass utilShared = new FirstCCharp.Utilities.SharedClass();

            // 2) Using directive
            SharedClass coreShared = new SharedClass();

            // 3) Using type alias
            SharedClass serviceShared = new SharedClass();
            PrintHello1();
            PrintHello2();
            PrintHello3();
        }

        static void PrintHello1()
        {
            Console.WriteLine("hello 1");
        }

        static void PrintHello2()
        {
            Console.WriteLine("hello 2");
        }

        static void PrintHello3()
        {
            Console.WriteLine("hello 3");
        }



    }
    public class SharedClass
    {
    }
    public class UserManager
    {
    }

    public class DataSeeder
    {
    }

}
namespace FirstCCharp.Services
{
    public class SharedClass
    {
    }
    public class EmailService
    {
    }

    public class ReportService
    {
    }

}

namespace FirstCCharp.Utilities {
    public class SharedClass
    {
    }
    public class FileHelper
    {
    }
    public class MathHelper
    {
    }
}

namespace FirstCCharp.Features {
    public class SharedClass
    {
    }
    public class OrdersModule
    {
    }
    public class PaymentsModule
    {
    }
}


//Q3 compiler give me error

//Q4 no error 
//Q10
//1-No in the same project
//2- Yes, but only if they are in different namespaces
//3- No in the same scope
//4-yes



//Q11
//1) Linear(Imperative) Programming
//program work line by line 


//2) Functional Programming
//    depend on reusablate

//3) Object - Oriented Programming(OOP)
//eveything is object and each one has its att and method



//Q12
//مسئول عن إدارة وتشغيل الكود اللي بيتكتب بلغات .NET 