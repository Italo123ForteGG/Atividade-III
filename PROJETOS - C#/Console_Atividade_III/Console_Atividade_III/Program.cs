using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Atividade_III
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade < 18 )
            {
                Console.WriteLine("Desculpe-me, você não é idependente.");
            }
        }
    }
}
