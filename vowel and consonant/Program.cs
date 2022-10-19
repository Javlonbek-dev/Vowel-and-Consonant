using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vowel_and_consonant
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Enter text");
            string arr = Console.ReadLine();
            var a=arr.Split(' ');
            var vowle = 0;
            var consonant = 0;
            var token = 0;
            Console.WriteLine(a);
            for (int i = 0; i <arr.Length; i++)
            {
                if (arr[i] == 'a' || arr[i] == 'i' || arr[i] == 'u' || arr[i] == 'o' || arr[i] == 'e')
                {
                    vowle++;
                }
                else if(arr[i] == '?' || arr[i] == '.' || arr[i] == '!' || arr[i] == ',' || arr[i] == ' ')
                {
                    token++;
                }
                else
                {
                    consonant++;
                }

            }
            Console.WriteLine("Vowle letter "+vowle);
            Console.WriteLine("Consonant letter " + consonant);
            Console.WriteLine("Tokens "+token);

        }
    }
}
