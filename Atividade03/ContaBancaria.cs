namespace Atividade_03_Aula02
{
    // Crie uma classe chamada "ContaBancaria" que tenha dois atributos: "Saldo" e "Numero". Crie dois métodos: "Depositar" e "Sacar". O método "Depositar" deve receber um valor como parâmetro e acrescentar esse valor ao saldo da conta. O método "Sacar" deve receber um valor como parâmetro e subtrair esse valor do saldo da conta, desde que haja saldo suficiente. Crie um objeto dessa classe e utilize os métodos para realizar transações bancárias.	

    public class ContaBancaria
    {

    public double Saldo { get; private set; }
    public int Numero { get; set;}

    public ContaBancaria(int numero)
    {
        Numero = numero;
    }

    public void Depositar(double valor)
    {
        Saldo += valor;
        Console.WriteLine($"Depósito de R${valor} efetuado / Saldo atual: {Saldo}");
    }

    public bool Sacar(double valor)
    {
        if (Saldo >= valor)
        {
            Saldo -= valor;
            Console.WriteLine($"Saque de R${valor} efetuado / Saldo atual: {Saldo}");
            return true;
        }
        else
        {
            Console.WriteLine($"Saldo insuficiente.");
            return false;
        }
    }

        


  
    }
}