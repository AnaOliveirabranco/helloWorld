using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloW
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            string nome;
            Console.WriteLine("Ola, qual é o seu nome?");
            nome = Console.ReadLine();
            Console.WriteLine($"Bem vindo(a) ao mundo C# {nome}!");
            
        }
    }
}
