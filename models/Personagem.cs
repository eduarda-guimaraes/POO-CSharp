class Personagem {
    public string Nome;  // Nome do personagem
    public int Vida;  // Vida do personagem
    public int Ataque;  // Ataque base do personagem
    public int Defesa;  // Defesa base do personagem

    // Limita o número de vezes que o Ataque Especial pode ser usado (1 vez no caso)
    private int limiteAtaqueEspecial = 1;  
    private int contadorAtaqueEspecial = 0;  // Contador de vezes que o ataque especial foi usado

    // Construtor para inicializar os atributos do personagem
    public Personagem(string nome, int vida, int ataque, int defesa) {
        if (vida < 0 || ataque < 0 || defesa < 0) {
            throw new ArgumentException("Valores de vida, ataque e defesa não podem ser negativos.");
        }

        Nome = nome;
        Vida = vida;
        Ataque = ataque;
        Defesa = defesa;
    }

    // Método de ataque normal
    public virtual void Atacar(Personagem alvo) {
        if (alvo == null) {
            throw new ArgumentNullException(nameof(alvo), "O alvo não pode ser nulo.");
        }

        int dano = Ataque - alvo.Defesa;  // Dano é calculado subtraindo a defesa do alvo do ataque do personagem
        if(dano < 0) {
            dano = 0;  // Impede que o dano seja negativo
        }
        alvo.Vida -= dano;  // Subtrai o dano da vida do alvo

        if(alvo.Vida < 0) {
            alvo.Vida = 0;  // Garante que a vida do alvo não seja negativa
        }
        Console.WriteLine($"\n{Nome} atacou {alvo.Nome} causando {dano} de dano.\n");
    }

    // Exibe o status do personagem (vida, ataque e defesa)
    public void ExibirStatus() {
        Console.WriteLine($"Nome: {Nome}\nVida: {Vida}\nAtaque: {Ataque}\nDefesa: {Defesa}\n");
    }

    // Verifica se o personagem pode usar o ataque especial
    public bool PodeUsarAtaqueEspecial() {
        return contadorAtaqueEspecial < limiteAtaqueEspecial;  // Verifica se o contador não atingiu o limite
    }

    // Aumenta o contador de uso do ataque especial
    public void UsarAtaqueEspecial() {
        contadorAtaqueEspecial++;  // Aumenta o contador cada vez que o ataque especial é usado
    }
}
