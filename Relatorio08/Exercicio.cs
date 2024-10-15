using System;

class Cachorro
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Cachorro(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public void showNome()
    {
        Console.WriteLine("O nome do cachorro é: " + Nome);
    }

    public virtual void showIdade()
    {
        Console.WriteLine("A idade do cachorro é: " + Idade + " anos");
    }
}

class CachorroGrande : Cachorro
{
    private string tamanho;

    public CachorroGrande(string nome, int idade, string tamanho) : base(nome, idade)
    {
        this.tamanho = tamanho;
    }

    public override void showIdade()
    {
        Console.WriteLine("Este é um cachorro grande. Idade: " + Idade + " anos");
    }
}

class CachorroPequeno : Cachorro
{
    public CachorroPequeno(string nome, int idade) : base(nome, idade) { }

    public override void showIdade()
    {
        Console.WriteLine("Este é um cachorro pequeno. Idade: " + Idade + " anos");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Cachorro cachorro = new Cachorro("Pretinha", 3);
        CachorroGrande cachorroGrande = new CachorroGrande("Balu", 5, "Grande");
        CachorroPequeno cachorroPequeno = new CachorroPequeno("Lino", 2);

        cachorro.showNome();
        cachorro.showIdade();

        cachorroGrande.showNome();
        cachorroGrande.showIdade();

        cachorroPequeno.showNome();
        cachorroPequeno.showIdade();
    }
}
