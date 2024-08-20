/*-------------------------------------------------------------------
Questão 2: Informações do Personagem
• Contextualização: No final de uma missão em um jogo, a pontuação do jogador é calculada com
base nos inimigos derrotados e pontos adicionais.
• Comando: Desenvolva um programa que receba o número de inimigos derrotados, a pontuação
por inimigo, bônus por missão, e dois multiplicadores (um para tipo de inimigo e outro para
dificuldade), e então calcule e exiba a pontuação final.

@Lista: 01 - Lógica de Programação
@Autor: Joanna Nobre
@Data: 20/08/2024
---------------------------------------------------------------------*/
using System;

class Program
{
    static void Main()
    {
        int inimigos, pontosInimigos, missao;
        double  pontosFinais, multDif, multBonus;

        Console.WriteLine("Escreva quantos inimigos foram derrotados: ");
        int.TryParse(Console.ReadLine(), out inimigos);
        Console.WriteLine("Quantos pontos por inimigos? ");
        int.TryParse(Console.ReadLine(), out pontosInimigos);
        Console.WriteLine("Quantou foi o bonus de missão? ");
        int.TryParse(Console.ReadLine(), out missao);

        Console.WriteLine("Qual foi o multiplicador de bonus?");
        double.TryParse(Console.ReadLine(), out multBonus);
        Console.WriteLine("Qual foi o multiplicador de dificuldade? ");
        double.TryParse(Console.ReadLine(), out multDif);

        pontosFinais = inimigos * pontosInimigos * multBonus * multDif + missao;
        Console.WriteLine("Sua pontuação final é: " + pontosFinais);

        Console.WriteLine("clique em QUALQUER tecla para fechar");
        Console.ReadLine();
    }
}