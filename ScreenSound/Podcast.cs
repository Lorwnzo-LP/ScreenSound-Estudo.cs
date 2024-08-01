class Podcast
{
    //Lista de episodios do Podcast.
    List<Episodio> listaDeEpisodios = new List<Episodio>();
    //Construtores.
    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }
    public string Host { get; }
    public string Nome { get; }
    public int TotalEpisodios { get => listaDeEpisodios.Count(); }

    //Função para adicionar um episódio ao repertório.
    public void AdicionarEpisodio(Episodio Episodio)
    {
        listaDeEpisodios.Add(Episodio);
    }

    //Função para exibir os detalhes dos episódios.
    public void ExibirDetalhes()
    {
        //Títulos.
        Console.WriteLine($"Bem vindo às informações do Podcast {this.Nome}.\nMe chamo {this.Host} e tenho o prazer de lhe apresentar este repertório.");
        Console.WriteLine($"A seguir, uma lista contendo todos os nossos {this.TotalEpisodios} episódios:\n");
        //Apresentação das informações do Episodio.
        foreach (Episodio episodio in listaDeEpisodios)
        {
            Console.WriteLine($"({episodio.Ordem}) Titulo: {episodio.Titulo} \nResumo: {episodio.Resumo}\nDuração: {episodio.Duracao} segundos");
            Console.WriteLine($"\nCom os convidados:");
            //Apresentação dos convidados.
            foreach (string convidado in episodio.listaDeConvidados)
            {
                Console.WriteLine($"-"+convidado);
            }
            Console.WriteLine("\n");
        }
    }
}