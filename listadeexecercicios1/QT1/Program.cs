/*-------------------------------------------------------------------
Questão 1: Informações do Personagem
• Contextualização: Em um jogo de RPG, o jogador precisa inserir
as informações básicas do personagem antes de começar a aventura.
• Comando: Crie um programa que receba o nome, idade, nível inicial, classe, e raça do
personagem e exiba esses dados no console.

@Lista: 01 - Lógica de Programação
@Autor: Joanna Nobre
@Data: 19/08/2024
---------------------------------------------------------------------*/

using System;

class Program 
{
    static void Main(string[] args)
    {
        string? nome, classe, raca;
        int idade, nivel;

        Console.WriteLine("escreva o nome do seu personagem: ");
        nome = Console.ReadLine();
        Console.WriteLine("Escreva a idade do seu personagem: ");
        int.TryParse(Console.ReadLine(), out idade);
        Console.WriteLine("Escreva seu nivel: ");
        int.TryParse(Console.ReadLine(), out nivel);
        Console.WriteLine("Escreva sua classe: ");
        classe = Console.ReadLine();
        Console.WriteLine("Escreva sua raça");
        raca = Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Esses são os dados do seu personagem:  \n" +
        "NOME: " + nome + "\n" +
        "IDADE: " + idade + "\n" +
        "NÍVEL: " + nivel + "\n" +
        "CLASSE" + classe + "\n" +
        "RAÇA: " + raca + "\n");

        Console.WriteLine("aperte ENTER para fechar");

        Console.ReadLine();
    }
}