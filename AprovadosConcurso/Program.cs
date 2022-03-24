using System.IO;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Linq;

namespace AprovadosConcurso
{
    class Program
    {
        // Altere para o caminho do arquivo de aprovados no concurso
        const string CAMINHO_ARQUIVO_ENTRADA = @"D:\Projetos_Dev\AprovadosConcurso\AprovadosConcurso\Aprovados.txt";

        static void Main(string[] args)
        {
            Console.WriteLine("Aprovados no concurso:\n");

            string candidatos = File.ReadAllText(CAMINHO_ARQUIVO_ENTRADA);

            var aprovadosDados = candidatos.Split("/");

            var listaCandidatos = new List<Candidato>();

            foreach (var aprovadoDados in aprovadosDados)
            {
                string[] dadosSegmentados = Regex.Split(aprovadoDados, @"(\d+[.]\d+)");

                var candidato = new Candidato
                {
                    Nome = ObterNomeCandidato(dadosSegmentados),
                    Pontuacao = ObterPontuacaoCandidato(dadosSegmentados)
                };

                listaCandidatos.Add(candidato);
            }

            var listaClassificacao = ObterClassificacaoCandidatos(listaCandidatos);

            foreach (var candidato in listaClassificacao)
            {
                Console.WriteLine($"#{listaClassificacao.IndexOf(candidato) + 1}: {candidato.Nome} | {candidato.Pontuacao}");
            }

            Console.ReadKey();
        }

        public static string ObterNomeCandidato(string[] dadosCandidato)
        {
            string[] nomeAprovado = dadosCandidato[0].Split(',');
            return nomeAprovado[1].Trim();
        }

        public static double ObterPontuacaoCandidato(string[] dadosCandidato)
        {
            return Convert.ToDouble(dadosCandidato[dadosCandidato.Length - 2], CultureInfo.InvariantCulture);
        }

        public static List<Candidato> ObterClassificacaoCandidatos(List<Candidato> candidatosAprovados)
        {
            return candidatosAprovados.OrderByDescending(o => o.Pontuacao).ToList();
        }
    }
}
