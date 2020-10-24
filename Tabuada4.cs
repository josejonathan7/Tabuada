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
           int tabuada = 4;
           int i;
           Console.WriteLine("Essa é a tabuada do 4:");
           for(i=1; i<=10; i++){
           	  Console.WriteLine(tabuada + " X " + i + " = " + (tabuada*i));
           }
           Console.ReadKey();
        }
    }
}