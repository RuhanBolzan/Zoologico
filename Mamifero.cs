public class Mamifero : Animal
{
    public Mamifero(string nome, int idade, double peso, string especie)
      : base(nome, idade, peso, especie)
    {

    }
    public override void EmitirSom()
    {
        Console.WriteLine($"O Mamífero {Nome} está fazendo barulho");
    }
    public override void Movimentar()
    {
        Console.WriteLine($"{Nome} está se movimentando");
    }
    public void Amamentar()
    {
        Console.WriteLine($"{Nome} está amamentando");
    }
}