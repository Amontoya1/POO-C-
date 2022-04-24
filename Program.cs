using System;
using System.Collections.Generic;
using JogoC.src.Entities;
using JogoC.src.Entities.Helper;

namespace JogoC
{
    class Program
    {
        static void Main(string[] args)
        {
            // Knigth arus = new Knigth("Arus", 12, "Warrior");
            // Wizard wizard = new Wizard("Jennica", 24, "Mage");
            // Console.WriteLine(arus.Attack());
            // Console.WriteLine(wizard.Attack(7));

            Stack<string> stack = new Stack<string>();
            stack.Push("First");
            stack.Push("Second");
            stack.Push("Third");
            stack.Push("Fourth");
            stack.Push("Fifth");

            System.Console.WriteLine($"Stack size: {stack.Count}");

            while (stack.Count > 0)
            {
                Console.WriteLine($"Proximo lugar em a pilha para ensinar: {stack.Peek()}");
                Console.WriteLine($"Proximo elemento: {stack.Pop()}");
            }
              System.Console.WriteLine($"Stack size ao final: {stack.Count}");
          
        //     Queue<string> queue = new Queue<string>();
        //     queue.Enqueue("Arus");
        //     queue.Enqueue("Jennica");
        //     queue.Enqueue("Andrés");

        //     Console.WriteLine($"Pessoas na fila: {queue.Count}");

        //    while (queue.Count > 0)
        //    {
        //        Console.WriteLine($"Vez de : {queue.Peek()}");
        //        Console.WriteLine($"{queue.Dequeue()} saiu da fila");
        //    }


            // OperacoesLista opLista = new OperacoesLista();
            // List<string> estados = new List<string> { "Acre", "Alagoas", "Amapá", "Amazonas", "Bahia", "Ceará", "Distrito Federal", "Goiás", "Maranhão", "Mato Grosso", "Mato Grosso do Sul", "Pará", "Paraíba", "Paraná", "Pernambuco", "Piauí", "Rio Grande do Norte", "Rio Grande do Sul", "Rondônia", "Roraima", "Santa Catarina", "Sergipe", "Tocantins" };
            // string[] estadosArray = new string[4] { "Rio de Janeiro", "São Paulo", "Minas Gerais", "Espirito Santo" };
            // // estados.Add("Acre");
            // // estados.Add("Alagoas");
            // // estados.Add("Amapá");
            // // estados.Add("Amazonas");
            // // estados.Add("Bahia");
            // System.Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}");

            // // estados.AddRange(estadosArray);
            // estados.Insert(0, "Rio de Janeiro");

            // opLista.ImprimirListaString(estados);

            // System.Console.WriteLine("Removendo o elemento da posição 2");

            // estados.RemoveAt(2);

            // System.Console.WriteLine($"Quantidade de elementos na lista remove: {estados.Count}");
          

            // int[] arrayInteiros = new int[3];
            // arrayInteiros[0] = 10;
            // arrayInteiros[1] = 20;
            // arrayInteiros[2] = 30;

            // System.Console.WriteLine("Percorrendo array pelo for");
            // for (int i = 0; i < arrayInteiros.Length; i++)
            // {
            //     System.Console.WriteLine(arrayInteiros[i]);
            // }

            // System.Console.WriteLine("Percorrendo array pelo foreach");
            // foreach (var item in arrayInteiros)
            // {
            //     System.Console.WriteLine(item);
            // }

        //     int[,] arrayInteiros = new int[3, 3]
        //     {
        //         {1, 2, 3},
        //         {4, 5, 6},
        //         {7, 8, 9}
        //     };
         
        //  for (int i = 0; i < arrayInteiros.GetLength(0); i++)
        //  {
        //      for (int j = 0; j < arrayInteiros.GetLength(1); j++)
        //      {
        //          System.Console.WriteLine(arrayInteiros[i, j]);
        //      }
        //  }

        OperacoesArray op = new OperacoesArray();
        // int[] array = new int[5] { 3, 7, 2, 9, 5 };
        // int[] arrayCopia = new int[10];
        // string[] arrayString = op.CoverterParaArrayString(array);

        // int valorProcurado = 7;

        // System.Console.WriteLine("Capacidade Atual do Array: " + array.Length);

        // op.RedimensionarArray(ref array, array.Length * 2);

        // System.Console.WriteLine($"Capacidade Atual do Array Após de Redimensionar: " + array.Length);

        // int indice = op.ObterIndice(array, valorProcurado);

        // if (indice > -1)
        // {
        //     System.Console.WriteLine("Valor encontrado na posição: " + indice);
        //     System.Console.WriteLine("O índice do elemento {0} é {1}", valorProcurado, indice);
        // }
        // else
        // {
        //     System.Console.WriteLine("Valor não encontrado");
        // }

        // int posicaoEncontrada = op.ObterValor(array, valorProcurado);
        // if (posicaoEncontrada > 0)
        // {
        //     System.Console.WriteLine("Valor encontrado na posição: " + posicaoEncontrada);
        // }
        // else
        // {
        //     System.Console.WriteLine("Valor não encontrado");
        // }

        // bool todosMaiorQue = op.TodosMaiorQue(array, valorProcurado);
         
        //  if (todosMaiorQue)
        //  {
        //      System.Console.WriteLine("Todos os elementos são maiores que " + valorProcurado);
        //  }
        //  else
        //  {
        //      System.Console.WriteLine("Não todos os elementos são maiores que " + valorProcurado);
        //  }

        // bool existe = op.Existe(array, valorProcurado);

        // if (existe)
        // {
        //     System.Console.WriteLine("Existe: {0}", valorProcurado);
        // }
        // else
        // {
        //     System.Console.WriteLine("Não existe: {0}", valorProcurado);
        // }

        // System.Console.WriteLine("Array antes da ordenação");
        // op.ImprimirArray(array);
        // op.OrdenarBubbleSort(ref array);
       //  op.Ordenar(ref array);

        // System.Console.WriteLine("Array depois da ordenação");
        // op.ImprimirArray(array);

        // System.Console.WriteLine("Array antes de la copia");
        // op.ImprimirArray(array);

        // op.Copiar(ref array, ref arrayCopia);

        // System.Console.WriteLine("Array após a copia");
        // op.ImprimirArray(arrayCopia);

        }
    }
}
