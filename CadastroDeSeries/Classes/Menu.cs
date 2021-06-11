using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroDeSeries
{
    class Menu
    {
      public string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("-----------------DIO Series----------------");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("INFORME A OPÇÃO DESEJADA: ");

            Console.WriteLine("1 - LISTAR SÉRIES");
            Console.WriteLine("2 - INSERIR NOVA SÉRIE");
            Console.WriteLine("3 - ATUALIZAR SÉRIE");
            Console.WriteLine("4 - EXCLUIR SÉRIE");
            Console.WriteLine("5 - VISUALIZAR SÉRIE");
            Console.WriteLine("C - LIMPA TELA");
            Console.WriteLine("X - SAIR");

            Console.Write("DIGITE A SUA OPÇÃO: ");
            string opcaoUsuario = Console.ReadLine().ToUpper();
            return opcaoUsuario;
        }
    }
}
