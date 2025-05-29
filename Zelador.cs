public class Zelador : Funcionario, ICuidador
{
    public Zelador(string nome, int idade, string cargo)
    : base(nome, idade, "Zelador")
    {

    }
    public override void Trabalhar()
    {
        Console.WriteLine($"{Nome} está trabalhando");
    }
    public void CuidarHabitat(Animal animal)
    {
        Console.WriteLine($"{Nome} está limpando o habitat do animal {animal.Nome}.");
    }
}