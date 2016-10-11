using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RollerCoaster
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("hamlet.txt");
            int lineNumber = 0;

            string line = reader.ReadLine();

            while (line != null)
            {
                
                line = reader.ReadLine();

                StringBuilder result = new StringBuilder();
                for (int i = 0; i < line.Length -1; i++)
                {
                    char ch = line[i];
                    if ( i%2==0 )
                    {
                        ch = char.ToUpper(ch);
                        result.Append(ch);
                    }
                    else
                    {
                        ch = char.ToLower(ch);
                        result.Append(ch);
                    }
                    
                }
                lineNumber++;
                Console.Write(result);
            }
            Console.ReadKey();
        }
    }
}

//public static string ExtractCapitals(string str)
//{
//    StringBuilder result = new StringBuilder();
//    for (int i = 0; i < str.Length; i++)
//    {
//        char ch = str[i];
//        if (char.IsUpper(ch))
//        {
//            result.Append(ch);
//        }
//    }
//    return result.ToString();
//}


//To be, or not to be: that is the question.
//Whether 'tis nobler in the mind to suffer.
//The slings and arrows of outrageous fortune.
//Or to take arms against a sea of troubles.
//And by opposing end them, to die: to sleep.