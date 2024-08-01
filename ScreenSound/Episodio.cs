class Episodio
{
    //Lista de convidados.
    public List<string> listaDeConvidados = new List<string>();
    //Construtores.
    public Episodio(int duracao, string titulo, string resumo, int ordem)
    {
        Duracao = duracao;
        Titulo = titulo;
        Resumo = resumo;
        Ordem = ordem;
    }
    public int Duracao { get; }
    public int Ordem { get; set; }
    public string Titulo { get; }
    public string Resumo { get; }
    
    //Função para adicionar convidados no próprio console.
    public void AdicionarConvidadosLive()
    {
        Console.WriteLine($"Adicione um convidado ao episódio {this.Ordem}: \n");
        string convidado = Console.ReadLine()!;

        while (true)
        {
            if (listaDeConvidados.Contains(convidado))
            {
                Console.WriteLine("O convidado já está na Lista, tente novamente ou termine a operação.\n Tentar novamente: (1)\nTerminar a operação: (2)");
                int opcao = int.Parse(Console.ReadLine()!);
                if (opcao == 1)
                {
                    continue;
                }
                else if (opcao == 2)
                {
                    Console.WriteLine("Terminando a operação em 3 segundos:");
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;
                }
                else 
                {
                    Console.WriteLine("Opção invalida.");
                    break;
                }
            }
            else
            {
                listaDeConvidados.Add(convidado);
                Console.WriteLine($"O convidado {convidado} foi adicionado à lista.");
                Thread.Sleep(3000);
                Console.Clear();
                break;
            }
        }
    }
    //Função para adicionar os convidados no próprio código.
    public void AdicionarConvidadosOff(string convidado)
    {
        listaDeConvidados.Add(convidado);
    }
}