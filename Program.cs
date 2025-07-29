using System;

class Program {
    static void Main(string[] args) {
        Console.Clear();
        Console.WriteLine("Bem-vindo ao jogo de RPG!");

        Console.Write("Jogador 1, digite o nome do seu personagem: ");
        string nome1 = Console.ReadLine();

        Console.Write("Jogador 2, digite o nome do seu personagem: ");
        string nome2 = Console.ReadLine();

        Personagem jogador1 = new Personagem(nome1, 100, 20, 10);
        Personagem jogador2 = new Personagem(nome2, 100, 15, 10);

        Console.Clear();

        while (jogador1.Vida > 0 && jogador2.Vida > 0) {
            Console.WriteLine("Jogador 1, sua vez de atacar!");
            jogador1.Atacar(jogador2);
            jogador2.ExibirStatus();

            if(jogador2.Vida <= 0) {
                Console.WriteLine($"{jogador2.Nome} foi derrotado! {jogador1.Nome} venceu!");
                break;
            }

            Console.WriteLine("Jogador 2, sua vez de atacar!");
            jogador2.Atacar(jogador1);
            jogador1.ExibirStatus();

            if(jogador1.Vida <= 0) {
                Console.WriteLine($"{jogador1.Nome} foi derrotado! {jogador2.Nome} venceu!");
                break;
            }
        }
        
    }
}