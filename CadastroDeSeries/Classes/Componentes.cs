using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroDeSeries
{
    class Componentes 
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        public static void ExcluirSerie()
        {
            Console.WriteLine("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());
            repositorio.Exclui(indiceSerie);
        }


        public static void VisualizarSerie()
        {
            Console.WriteLine("Digite o Id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = repositorio.RetornaPorId(indiceSerie);
            Console.WriteLine(serie);
        }

        public static void AtualizarSerie()
        {
            Console.WriteLine("Digite o id da série:  ");
            int indiceSerie = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine($"{i}-{Enum.GetName(typeof(Genero), i)}");

            }

            Console.WriteLine("Digite o gênero entre as opções acima");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Título da Série");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o Ano de Início da Série");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Descrição da Série");
            string entradaDescricao = Console.ReadLine();


            Series atualizaSerie = new Series(indiceSerie,
                                           (Genero)entradaGenero,
                                            entradaTitulo, entradaDescricao, entradaAno);
            repositorio.Atualiza(indiceSerie, atualizaSerie);

        }


        public static void InserirSerie()
        {
            Console.WriteLine("Inserir nova Série");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine($"{i}-{Enum.GetName(typeof(Genero), i)}");

            }

            Console.WriteLine("Digite o gênero entre as opções acima");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Título da Série");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o Ano de Início da Série");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Descrição da Série");
            string entradaDescricao = Console.ReadLine();


            Series novaSerie = new Series(repositorio.ProximoId(),
                                           (Genero)entradaGenero,
                                            entradaTitulo, entradaDescricao, entradaAno);
            repositorio.Insere(novaSerie);
        }



        public static void listarSeries()
        {
            Console.WriteLine("Listar Séries: ");

            var lista = repositorio.Lista();


            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série encontrada.");
                return;
            }

            foreach (var serie in lista)
            {
                var excluido = serie.retornaExcluido();

                Console.WriteLine($"#ID {serie.retornaId()}: - {serie.retornaTitulo()}" + "-{0}", excluido ? "-Excluido" : "");
            }

        }





    }
}
