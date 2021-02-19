using System;

namespace AlifLesson12HW16._02
{
    class Program
    {        
        static Random random = new Random();

        
        static char MySymbols
        {
            get
            {
                int t = random.Next(10);
                if (t <= 2)
                    
                    return (char)('0' + random.Next(10));
                else if (t <= 4)
                    
                    return (char)('a' + random.Next(27));
                else if (t <= 6)
                    
                    return (char)('A' + random.Next(27));
                else
                    
                    return (char)(random.Next(32, 255));
            }
        }
        static void Main(string[] args)

        {
            Console.WriteLine("Hello World!");
        }
    }
}
