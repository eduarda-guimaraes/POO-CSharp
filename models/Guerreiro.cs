class Guerreiro : Personagem
{
    // Construtor do Guerreiro, herdando os atributos de Personagem e definindo valores específicos
    public Guerreiro(string nome) : base(nome, 120, 25, 15) { }  // 120 de Vida, 25 de Ataque e 15 de Defesa

    // Método para realizar um ataque normal
    public override void Atacar(Personagem alvo)
    {
        base.Atacar(alvo);  // Chama o método de ataque da classe base (Personagem)
        Console.WriteLine($"{Nome} usou um ataque forte!");  // Mensagem adicional para o Guerreiro
    }

    // Método para realizar o ataque especial
    public void AtaqueEspecial(Personagem alvo)
    {
        if (PodeUsarAtaqueEspecial())
        {  // Verifica se o Guerreiro pode usar o ataque especial
            int danoEspecial = Ataque * 2 - alvo.Defesa;  // O ataque especial causa o dobro do dano normal
            if (danoEspecial < 0)
            {
                danoEspecial = 0;  // Impede que o dano seja negativo
            }
            alvo.Vida -= danoEspecial;  // Subtrai o dano especial da vida do alvo
            if (alvo.Vida < 0)
            {
                alvo.Vida = 0;  // Garante que a vida do alvo não seja negativa
            }
            UsarAtaqueEspecial();  // Marca que o ataque especial foi usado
            Console.WriteLine($"\n{Nome} usou um ataque especial causando {danoEspecial} de dano!");  // Mensagem do ataque especial
        }
        else
        {
            Console.WriteLine($"{Nome} não pode mais usar ataque especial.");  // Caso o ataque especial já tenha sido usado
        }
    }
}
