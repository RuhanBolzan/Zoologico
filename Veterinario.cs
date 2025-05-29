public class Veterinario : Funcionario, ITratamentoAnimal
{
    public Veterinario(string nome, int idade, string cargo)
    : base(nome, idade, cargo)
    {

    }
    public override void Trabalhar()
    {
        Console.WriteLine($"{Nome} está em serviço");
    }
    public void RealizarTratamento(Animal animal)
    {
        Console.WriteLine($"{Nome} está examinando o animal {animal.Nome} de espécie {animal.Especie}");
    }
}