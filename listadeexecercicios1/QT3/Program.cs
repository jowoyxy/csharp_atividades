/*-------------------------------------------------------------------
Questão 3: Informações do Personagem
• Contextualização:Durante um combate, o jogador recebe dano e a vida do personagem
diminui.
• Comando: Crie um programa que receba o valor da vida inicial, o dano recebido, o bônus de
regeneração, do atacado, e dois modificadores, do atacante, (um para equipamentos e outro
para habilidades), e calcule a vida restante.

@Lista: 01 - Lógica de Programação
@Autor: Joanna Nobre
@Data: 20/08/2024
---------------------------------------------------------------------*/
using System;

class Program
{
    static void Main(string[] args)
    {
        double vidaInicial, danoRecebido, reg, eq, hab;

        Console.WriteLine("Digite a vida inicial do personagem: ");
        double.TryParse(Console.ReadLine(), out vidaInicial);

        Console.WriteLine("digite o dano recebido: ");
        double.TryParse(Console.ReadLine(), out danoRecebido);

        Console.WriteLine("Digite o bonus de regeneração: ");
        double.TryParse(Console.ReadLine(), out reg);

        Console.WriteLine("Digite o bonus de equipamento: ");
        double.TryParse(Console.ReadLine(), out eq);

        Console.WriteLine("Digite o bonus de habilidade: ");
        double.TryParse(Console.ReadLine(), out hab);

        double danoModificado
         = danoRecebido * eq * hab;
        double vidaRes = vidaInicial - danoModificado + reg;

        Console.WriteLine($"\n A vidarestante é: {vidaRes}");
        Console.WriteLine(" Aperte qualquer tecla para continuar");
        Console.ReadLine();
    }
}