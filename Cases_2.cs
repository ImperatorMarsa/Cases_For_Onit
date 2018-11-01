using System;

namespace Pony
{
    class Program
    {
        static void Main(string[] args)
        {
            string a="";                    /* minus odna peremennaya */
            for (; a.Length<100; a+="a");
            
            Console.WriteLine(a.Length.ToString()+" "+a);
        }
    }
}
