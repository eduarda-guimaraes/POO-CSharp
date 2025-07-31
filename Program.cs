using System;

class Program {
    static void Main(string[] args) {
        Console.Clear();
        Console.WriteLine("-- Bem-vindo ao jogo de RPG! --");  // Exibe uma mensagem inicial
        Console.WriteLine("Você irá controlar personagens com habilidades especiais!\n");

        // Solicita os nomes dos jogadores, garantindo que não sejam nulos ou vazios
        string nome1 = ObterNomeJogador("Jogador 1");
        string nome2 = ObterNomeJogador("Jogador 2");

        // Criando os personagens com base nas classes Guerreiro e Mago
        // Usando herança: Guerreiro e Mago herdam de Personagem
        Personagem jogador1 = new Guerreiro(nome1);  // Criando o Guerreiro para o Jogador 1
        Personagem jogador2 = new Mago(nome2);       // Criando o Mago para o Jogador 2

        // Descrição dos personagens
        Console.Clear();
        DescreverPersonagens(jogador1, jogador2);  // Exibe as descrições das classes Guerreiro e Mago

        // Informa aos jogadores sobre a limitação do Ataque Especial
        Console.WriteLine("\n| Aviso: Cada jogador pode usar o Ataque Especial apenas uma vez durante a batalha.\n");
        
        Console.WriteLine("\nA batalha começou!\n");

        // Loop principal da batalha onde os jogadores se alternam em turnos
        while (jogador1.Vida > 0 && jogador2.Vida > 0) {
            // Turno do Jogador 1
            Console.WriteLine($"- {jogador1.Nome}, é a sua vez de atacar!\n");
            string escolha1 = ObterEscolhaDeAtaque();  // Solicita a escolha do Jogador 1 (normal ou especial)

            try {
                if (escolha1 == "1") {
                    jogador1.Atacar(jogador2);  // Se o jogador escolher 1, realiza um ataque normal
                } else if (escolha1 == "2") {  // Se escolher 2, realiza o ataque especial
                    if (jogador1 is Guerreiro guerreiro1) {
                        if (guerreiro1.PodeUsarAtaqueEspecial()) {
                            guerreiro1.AtaqueEspecial(jogador2);  // Realiza o ataque especial se possível
                        } else {
                            Console.WriteLine("O ataque especial já foi usado o máximo de vezes!");  // Mensagem de limite
                        }
                    } else if (jogador1 is Mago mago1) {
                        if (mago1.PodeUsarAtaqueEspecial()) {
                            mago1.AtaqueEspecial(jogador2);  // Realiza o ataque especial se possível
                        } else {
                            Console.WriteLine("O ataque especial já foi usado o máximo de vezes!");  // Mensagem de limite
                        }
                    }
                }
                jogador2.ExibirStatus();  // Exibe o status do Jogador 2 após o ataque
            } catch (Exception ex) {
                Console.WriteLine($"Erro ao atacar: {ex.Message}");  // Captura qualquer erro no ataque
            }

            // Verifica se o Jogador 2 foi derrotado
            if (jogador2.Vida <= 0) {
                Console.WriteLine($"- {jogador2.Nome} foi derrotado(a)!");
                Console.WriteLine($"| {jogador1.Nome} venceu 🏆 |");
                break;  // Finaliza o loop se o Jogador 2 for derrotado
            }

            // Turno do Jogador 2
            Console.WriteLine($"- {jogador2.Nome}, é a sua vez de atacar!\n");
            string escolha2 = ObterEscolhaDeAtaque();  // Solicita a escolha do Jogador 2 (normal ou especial)

            try {
                if (escolha2 == "1") {
                    jogador2.Atacar(jogador1);  // Ataque normal
                } else if (escolha2 == "2") {  // Ataque especial
                    if (jogador2 is Guerreiro guerreiro2) {
                        if (guerreiro2.PodeUsarAtaqueEspecial()) {
                            guerreiro2.AtaqueEspecial(jogador1);  // Realiza o ataque especial se possível
                        } else {
                            Console.WriteLine("O ataque especial já foi usado o máximo de vezes!");  // Mensagem de limite
                        }
                    } else if (jogador2 is Mago mago2) {
                        if (mago2.PodeUsarAtaqueEspecial()) {
                            mago2.AtaqueEspecial(jogador1);  // Realiza o ataque especial se possível
                        } else {
                            Console.WriteLine("O ataque especial já foi usado o máximo de vezes!");  // Mensagem de limite
                        }
                    }
                }
                jogador1.ExibirStatus();  // Exibe o status do Jogador 1 após o ataque
            } catch (Exception ex) {
                Console.WriteLine($"Erro ao atacar: {ex.Message}");  // Captura qualquer erro no ataque
            }

            // Verifica se o Jogador 1 foi derrotado
            if (jogador1.Vida <= 0) {
                Console.WriteLine($"- {jogador1.Nome} foi derrotado!");
                Console.WriteLine($"| {jogador2.Nome} venceu 🏆 |");
                break;  // Finaliza o loop se o Jogador 1 for derrotado
            }
        }
    }

    // Função para obter o nome do jogador com validação de entrada
    static string ObterNomeJogador(string nomeJogador) {
        string? nome;
        do {
            Console.Write($"{nomeJogador}, digite o nome do seu personagem: ");
            nome = Console.ReadLine();
        } while (string.IsNullOrWhiteSpace(nome));  // Garante que o nome não seja vazio ou nulo
        return nome;
    }

    // Função para validar a escolha de ataque do jogador (1 - Normal, 2 - Especial)
    static string ObterEscolhaDeAtaque() {
        string? escolha;
        do {
            Console.WriteLine("Escolha seu ataque:");
            Console.WriteLine("1 - Ataque Normal");
            Console.WriteLine("2 - Ataque Especial\n");
            escolha = Console.ReadLine();

            // Verifica se a escolha é válida (1 ou 2)
            if (escolha != "1" && escolha != "2") {
                Console.WriteLine("\nEscolha inválida! Digite 1 para Ataque Normal ou 2 para Ataque Especial.\n");
            }
        } while (escolha != "1" && escolha != "2");  // Só sai quando a escolha for válida
        return escolha;
    }

    // Função para descrever as habilidades dos personagens
    static void DescreverPersonagens(Personagem jogador1, Personagem jogador2) {
        Console.WriteLine($"{jogador1.Nome} é um(a) Guerreiro(a) forte, com alta defesa e ataque físico!");
        Console.WriteLine($"Habilidades especiais: Ataque Forte (potencializa o dano causado).");
        Console.WriteLine($"Vida: {jogador1.Vida}, Ataque: {jogador1.Ataque}, Defesa: {jogador1.Defesa}\n");

        Console.WriteLine($"{jogador2.Nome} é um(a) Mago(a) com grande poder mágico, mas com defesa mais baixa.");
        Console.WriteLine($"Habilidades especiais: Feitiço Mágico (causa grande dano com poder mágico).");
        Console.WriteLine($"Vida: {jogador2.Vida}, Ataque: {jogador2.Ataque}, Defesa: {jogador2.Defesa}\n");
    }
}
