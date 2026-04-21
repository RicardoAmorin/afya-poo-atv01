public class Lampada
{
    private string marca;
    private readonly string tecnologia;
    private bool ligada;
    private int brilho;

    public Lampada(string marca, string tecnologia)
    {
        this.marca = marca;
        this.tecnologia = tecnologia;
        ligada = false;
        brilho = 100;
    }

    public void Alternar()
    {
        ligada = !ligada;
    }

    public void AjustarBrilho(int novoBrilho)
    {
        if (!ligada) return;

        if (novoBrilho >= 0 && novoBrilho <= 100)
            brilho = novoBrilho;
    }

    public override string ToString()
    {
        return $"Marca: {marca} | Tecnologia: {tecnologia} | Ligada: {ligada} | Brilho: {brilho}";
    }
}