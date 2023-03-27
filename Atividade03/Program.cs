// Crie uma classe chamada "ContaBancaria" que tenha dois atributos: "Saldo" e "Numero". Crie dois métodos: "Depositar" e "Sacar". O método "Depositar" deve receber um valor como parâmetro e acrescentar esse valor ao saldo da conta. O método "Sacar" deve receber um valor como parâmetro e subtrair esse valor do saldo da conta, desde que haja saldo suficiente. Crie um objeto dessa classe e utilize os métodos para realizar transações bancárias.		
using Atividade_03_Aula02;	

        ContaBancaria minhaConta = new ContaBancaria(12345);


        Show("Digite sua senha: ");
        var senha = Convert.ToInt64(Console.ReadLine());


        if(minhaConta.Numero == 12345 && senha == 0409) {
                Show("Acessando sua conta...");
                Show("----------------------");
                
                // Depositando na conta
                minhaConta.Depositar(1000);

                // Realizando Saques
                minhaConta.Sacar(500);
                minhaConta.Sacar(300);
                minhaConta.Sacar(2000);
        }
        else {
                Show("Dados inválidos!");
        }



    void Show(string msg) {
        Console.WriteLine(msg);
    }