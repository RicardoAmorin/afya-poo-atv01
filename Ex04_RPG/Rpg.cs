public class Personagem
{
    private string nome;
    private string classe;
    private int nivel;
    private double vidaAtual;
    private double vidaMaxima;

    public Personagem(string nome, string classe)
    {
        this.nome = nome;
        this.classe = classe;
        nivel = 1;

        if (classe == "Guerreiro")
            vidaMaxima = 150;
        else
            vidaMaxima = 80;

        vidaAtual = vidaMaxima;
    }

    public void ReceberDano(double dano)
    {
        vidaAtual -= dano;
        if (vidaAtual < 0)
            vidaAtual = 0;
    }

    public void Curar(double valor)
    {
        if (vidaAtual == 0) return;

        vidaAtual += valor;
        if (vidaAtual > vidaMaxima)
            vidaAtual = vidaMaxima;
    }

    public void SubirNivel()
    {
        if (vidaAtual == 0) return;

        nivel++;
        vidaMaxima *= 1.1;
        vidaAtual = vidaMaxima;
    }

    public void Ressuscitar()
    {
        if (vidaAtual == 0)
            vidaAtual = vidaMaxima;
    }

    public override string ToString()
    {
        return $"{nome} ({classe}) - Lvl {nivel} - HP: {vidaAtual}/{vidaMaxima}";
    }
}