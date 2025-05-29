using System;
using System.Collections.Generic;

class Program
{
    static List<Animal> animais = new List<Animal>();
    static List<Funcionario> funcionarios = new List<Funcionario>();

    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\nMenu Principal:");
            Console.WriteLine("1 - Cadastrar Animal");
            Console.WriteLine("2 - Cadastrar Funcionário");
            Console.WriteLine("3 - Interagir");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            if (opcao == "1")
            {
                CadastrarAnimal();
            }
            else if (opcao == "2")
            {
                CadastrarFuncionario();
            }
            else if (opcao == "3")
            {
                Interagir();
            }
            else if (opcao == "4")
            {
                continuar = false;
            }
            else
            {
                Console.WriteLine("Opção inválida!");
            }
        }
    }

    static void CadastrarAnimal()
    {
        Console.Write("Tipo de animal (mamifero, ave, reptil): ");
        string tipo = Console.ReadLine();

        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.Write("Peso: ");
        double peso = double.Parse(Console.ReadLine());

        Console.Write("Espécie: ");
        string especie = Console.ReadLine();

        Animal novoAnimal = null;

        if (tipo == "mamifero")
        {
            novoAnimal = new Mamifero(nome, idade, peso, especie);
        }
        else if (tipo == "ave")
        {
            novoAnimal = new Ave(nome, idade, peso, especie);
        }
        else if (tipo == "reptil")
        {
            novoAnimal = new Reptil(nome, idade, peso, especie);
        }
        else
        {
            Console.WriteLine("Tipo inválido.");
            return;
        }

        animais.Add(novoAnimal);
        Console.WriteLine("Animal cadastrado com sucesso!");
    }

    static void CadastrarFuncionario()
    {
        Console.Write("Tipo do funcionário: ");
        string tipo = Console.ReadLine();

        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Idade: ");
        int idade = int.Parse(Console.ReadLine());

        Funcionario novoFuncionario = null;

        if (tipo == "veterinario")
        {
            novoFuncionario = new Veterinario(nome, idade, "Veterinário");
        }
        else if (tipo == "zelador")
        {
            novoFuncionario = new Zelador(nome, idade, "Zelador");
        }
        else
        {
            Console.WriteLine("Tipo inválido.");
            return;
        }

        funcionarios.Add(novoFuncionario);
        Console.WriteLine("Funcionário cadastrado com sucesso!");
    }

    static void Interagir()
    {
        if (animais.Count == 0 || funcionarios.Count == 0)
        {
            Console.WriteLine("Cadastre pelo menos um animal e um funcionário.");
            return;
        }

        Console.WriteLine("Animais cadastrados:");
        foreach (Animal a in animais)
        {
            Console.WriteLine($"  { a.Nome} ");
        }

        Console.Write("Digite o nome do animal: ");
        string nomeAnimal = Console.ReadLine();

        Animal animalEscolhido = null;
        foreach (Animal a in animais)
        {
            if (a.Nome == nomeAnimal)
            {
                animalEscolhido = a;
                break;
            }
        }

        if (animalEscolhido == null)
        {
            Console.WriteLine("Animal não encontrado.");
            return;
        }

        Console.WriteLine("Funcionários cadastrados:");
        foreach (Funcionario f in funcionarios)
        {
            Console.WriteLine($" {f.Nome}");
        }

        Console.Write("Digite o nome do funcionário: ");
        string nomeFunc = Console.ReadLine();

        Funcionario funcionarioEscolhido = null;
        foreach (Funcionario f in funcionarios)
        {
            if (f.Nome == nomeFunc)
            {
                funcionarioEscolhido = f;
                break;
            }
        }

        if (funcionarioEscolhido == null)
        {
            Console.WriteLine("Funcionário não encontrado.");
            return;
        }

        if (funcionarioEscolhido is Veterinario)
        {
            Console.WriteLine("Veterinário cuidando do animal...");
            ((Veterinario)funcionarioEscolhido).RealizarTratamento(animalEscolhido);
        }
        else if (funcionarioEscolhido is Zelador)
        {
            Console.WriteLine("Zelador cuidando do habitat...");
            ((Zelador)funcionarioEscolhido).CuidarHabitat(animalEscolhido);
        }
        else
        {
            Console.WriteLine("Tipo de funcionário inválido para interação.");
        }
    }
}
