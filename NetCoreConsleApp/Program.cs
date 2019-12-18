using System;

namespace NetCoreConsleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1.0 hello world
            //Console.WriteLine("Hello World!");
            //Console.Write("Press any key to continue...");
            //Console.ReadKey(true);
            #endregion

            #region 2.0 what's your name
            Console.WriteLine("\nWhat is your name? ");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($"\nHello,{name},on{date:d} at {date:t}");        //内插字符串（C# 6.0开始）：https://docs.microsoft.com/zh-cn/dotnet/csharp/language-reference/tokens/interpolated
            Console.Write("\nPress any key to exit...");
            Console.ReadKey(true); 
            #endregion


        }
    }
}
