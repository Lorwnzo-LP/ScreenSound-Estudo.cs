class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome    { get; }
    public Banda Artista { get; set; }
    public int Duracao    { get; set; }
    public bool Disponivel { get; set; }
    public Genero Genero { get; set; }


    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome/Artista: {Nome} - {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        }
        else {
            Console.WriteLine("Adquira com o plano tal");
        }
    }
    
}



