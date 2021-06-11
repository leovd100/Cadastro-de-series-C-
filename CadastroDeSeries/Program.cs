using System;

namespace CadastroDeSeries
{
    class Program
    {



        static SerieRepositorio repositorio = new SerieRepositorio();

        static void Main(string[] args)
        {

            Menu menu = new Menu();
            string opcao = menu.ObterOpcaoUsuario();

            while (opcao.ToUpper() != "X")
            {
                switch (opcao)
                {
                    case "1":
                        Componentes.listarSeries();
                        break;

                    case "2":
                        Componentes.InserirSerie();
                        break;

                    case "3":
                        Componentes.AtualizarSerie();
                        break;

                    case "4":
                        Componentes.ExcluirSerie();
                        break;

                    case "5":
                        Componentes.VisualizarSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();

                }


                opcao = menu.ObterOpcaoUsuario();
            }
            
        }
       
    }
}
