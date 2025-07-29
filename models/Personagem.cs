class Personagem {
    public string Nome;
    public int Vida;
    public int Ataque;
    public int Defesa;

    public Personagem(string nome, int vida, int ataque, int defesa) {
        Nome = nome;
        Vida = vida;
        Ataque = ataque;
        Defesa = defesa;
    }

    public void Atacar(Personagem alvo) {
        int dano = Ataque - alvo.Defesa;
        if(dano < 0) {
            dano = 0;
        }
        alvo.Vida -= dano;

        if(alvo.Vida < 0) {
            alvo.Vida = 0;
        }
        Console.WriteLine($"{Nome} atacou {alvo.Nome} causando {dano} de dano.\n");
    }

    public void ExibirStatus() {
        Console.WriteLine($"Nome: {Nome}\nVida: {Vida}\nAtaque: {Ataque}\nDefesa:{Defesa}\n");
    }
}