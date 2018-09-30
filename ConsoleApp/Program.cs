using System;
using System.Collections.Generic;

namespace ConsoleApp
{
   public class Program
    {
        static void Main(string[] args)
        {
            //"C:\\pessoal\\Modal\\in.txt";

            if (args.Length == 0)
                Console.WriteLine("arquivo não informado.");
            else
                Funcoes.processaArquivo(args[0]);


           Console.ReadLine();
            
        }


       
        


    }
}
