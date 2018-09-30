using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp
{
    public static class Funcoes
    {
        static char[] wordsArr;
        static string word = string.Empty;
        static Dictionary<string, int> lista = new Dictionary<string, int>();
        static int idx = 1;
        static int TamanhoPalavra = 5;

        public static void processaArquivo(string caminho)
        {
           
            string[] linhas = System.IO.File.ReadAllLines(caminho);
            foreach (string linha in linhas)
            {
                Console.WriteLine(valorValido(linha.Trim()));
            }
        }

        public static void PreencheListaValores()
        {

            if (lista.Count() == 0)
            {
                wordsArr = new string("abcdefghijklmnopqrstuvwxyz").ToCharArray();
                int TamanhoArray = wordsArr.Length;
                //Chama recursivamente a função aumentando a tamanho da palavra até 5 posições
                for (int i = 1; i <= TamanhoPalavra; i++)
                {
                    int[] arr = new int[i];
                    geraValores(arr, 0, 0, TamanhoArray);
                }
            }
        }

        static void geraValores(int[] arr, int index, int start, int end)
        {
            if (index >= arr.Length)
            {
                word = string.Empty;
                for (int i = 0; i < arr.Length; i++)
                    word += wordsArr[arr[i]];
                
                lista.Add(word, idx++);
            }
            else
                for (int i = start; i < end; i++)
                {
                    arr[index] = i;
                    geraValores(arr, index + 1, i + 1, end);
                }
        }

        public static int valorValido(string valorEntrada)
        {
            int retorno = 0;
            char[] letras = valorEntrada.ToCharArray();

            //valida valor muito grande
            if (letras.Length > 5)
                return 0;

            PreencheListaValores();

            if (lista.ContainsKey(valorEntrada))
                retorno = lista[valorEntrada];



            return retorno;
        }
    }
}
