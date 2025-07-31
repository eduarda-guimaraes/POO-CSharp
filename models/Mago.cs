class Mago : Personagem
{
    // Construtor do Mago, herdando os atributos de Personagem e definindo valores específicos
    public Mago(string nome) : base(nome, 80, 10, 10) { }  // 80 de Vida, 10 de Ataque e 10 de Defesa

    // Método para realizar um ataque normal
    public override void Atacar(Personagem alvo)
    {
        base.Atacar(alvo);  // Chama o método de ataque da classe base (Personagem)
        Console.WriteLine($"{Nome} usou um feitiço mágico!");  // Mensagem adicional para o Mago
    }

    // Método para realizar o ataque especial
    public void AtaqueEspecial(Personagem alvo)
    {
        if (PodeUsarAtaqueEspecial())
        {  // Verifica se o Mago pode usar o ataque especial
            int danoEspecial = Ataque * 3 - alvo.Defesa;  // O ataque especial do Mago causa o triplo do dano normal
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
            Console.WriteLine($"\n{Nome} lançou um feitiço mágico poderoso causando {danoEspecial} de dano!");  // Mensagem do ataque especial
        }
        else
        {
            Console.WriteLine($"{Nome} não pode mais usar ataque especial.");  // Caso o ataque especial já tenha sido usado
        }
    }
}
