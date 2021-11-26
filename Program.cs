using System;
using System.Collections.Generic;

namespace EstruturasRepeticao
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 10; i += 2)
            Console.WriteLine($"O valor de i é: {i}");

            // while (true)
            // Console.WriteLine("Mensagem de loop infinito");

            int contador = 0;
            while (contador < 5)
            {
                Console.WriteLine($"O contador do WHILE é: {contador}");
                contador++;
            }

            do {
                Console.WriteLine($"O contador do DO WHILE é: {contador}");
                contador++;
            } while (contador < 10);

            List<string> listaNomes = new();
            listaNomes.Add("Paulo Ponciano");
            listaNomes.Add("Jefferson");
            listaNomes.Add("Rubens");
            listaNomes.Add("Marcos");
            listaNomes.Add("Luciane");
            listaNomes.Add("mais um monte de nomes aleatórios");
            foreach(string nome in listaNomes)
            Console.WriteLine($"O elemendo da lista é: {nome}");

            try
            {
                Console.WriteLine("Digite um número:");
                int numero = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}
