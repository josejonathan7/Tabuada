using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public static class Program 
    {
        public static void Main() 
        {
           int tabuada, i;
           Console.Write("Digite o número do qual deseja saber a tabuada:");
           tabuada = int.Parse(Console.ReadLine());
           
           Console.WriteLine("\nA tabuada do " + tabuada + " é:");
           for(i=1; i<=10; i++){
           	  Console.WriteLine(tabuada + " X " + i + " = " + (tabuada*i));
           }
           Console.ReadKey();
        }
    }
}