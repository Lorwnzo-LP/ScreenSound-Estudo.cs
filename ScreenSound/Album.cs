class Album
{
    private List<Musica> musicas = new List<Musica>();

    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);
    public Genero genero { get; set; }

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }
    private void ExibirDetalhesDoAlbum()
    {
        Console.WriteLine($"Nome do album: {Nome}");
        Console.WriteLine($"Gênero do album: {genero}");
        Console.WriteLine($"Duração total do album (em segundos): {DuracaoTotal}\n");
    }
    private void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Listas de músicas do album {Nome}\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome} ////// duração: {musica.Duracao}");
        }
        Console.WriteLine("\n");
    }

    public void ExibirInformacoesCompletas()
    {
        ExibirDetalhesDoAlbum();
        Console.WriteLine("----------------------------------------------");
        ExibirMusicasDoAlbum();
        Console.Write("\nDigite qualquer tecla para terminar");
        Console.ReadKey();
    }
}
