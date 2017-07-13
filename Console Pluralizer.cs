using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plurals
{
    class Program
    {
        static void Main(string[] args) {
            string transformWord = "";
           var word = Console.ReadLine();
            
            if (word.EndsWith("y")) {

               
                transformWord = word.Remove(word.Length - 1) + "ies";

            } else if (word.EndsWith("ch") || word.EndsWith("sh") || word.EndsWith("o") || word.EndsWith("s") || word.EndsWith("x") || word.EndsWith("z"))
                transformWord = word + "es";
            

            else {
                transformWord = word + "s";
            }
            Console.WriteLine(transformWord);
        }
    }
}
