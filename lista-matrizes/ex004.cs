/*Escrever um programa  que gere uma matriz de N Linhas x N Colunas  e apresente sua diagonal principal. 
Dica, limite sua matriz a uma ordem 100. */
using System;
using MinhaBiblioteca;

class ex004
{
    static void DiagPrincipal(int[,] mat)
    {
        Console.WriteLine("Diagonal principal da matriz: ");
        
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                if (j == i)
                {
                    Console.Write($"[{mat[i, j]}] ");
                }
            }
        }
    }
    static void Main()
    {
        int linhas, colunas;

        Console.WriteLine("Digite a quantidade de linhas da matriz (Tamanho máximo: 100):");
        linhas = int.Parse(Console.ReadLine());

        while (linhas > 100)
        {
            Console.WriteLine("Tamanho máximo excedido, digite um número <= 100):");
            linhas = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Digite a quantidade de colunas da matriz (Tamanho máximo: 100):");
        colunas = int.Parse(Console.ReadLine());

        while (colunas > 100)
        {
            Console.WriteLine("Tamanho máximo excedido, digite um número <= 100):");
            colunas = int.Parse(Console.ReadLine());
        }

        int[,] matriz = new int[linhas, colunas];

        Func.GerarMatInt(matriz);
        Func.MostrarMatInt(matriz);

        DiagPrincipal(matriz);




    }
}