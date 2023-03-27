// Crie uma classe chamada "Calculadora" que tenha dois métodos: "Somar" e "Subtrair". O método "Somar" deve receber dois números como parâmetros e retornar a soma desses números. O método "Subtrair" deve receber dois números como parâmetros e retornar a subtração desses números. Crie um objeto dessa classe e utilize os métodos para realizar operações matemáticas.
using Atividade;

    Calculadora CalcFelipe = new Calculadora();

    Show("Digite a operação matemática desejada (+ ou -)");
    var operador = Console.ReadLine();
        

    while (operador == "+" || operador == "-") {

        if(operador == "+" ) {
            // Calculadora Somar
            Show("Digite o 1º número: ");
            var num1 = Convert.ToDouble(Console.ReadLine());
            Show("Digite o 2º número: ");
            var num2 = Convert.ToDouble(Console.ReadLine());

            // Chamando o cálculo
            var ResultadoSoma = CalcFelipe.Somar(num1, num2);
            Show("A Soma de " + num1 + " + " + num2 + " = " + ResultadoSoma);

            Show("----------------------------");
            Show("Digite a operação matemática desejada para continuar (+ ou -)");
            operador = Console.ReadLine();
      
        }else {
            // Calculadora Subtrair
            Show("Digite o 1º número: ");
            var num1 = Convert.ToDouble(Console.ReadLine());
            Show("Digite o 2º número: ");
            var num2 = Convert.ToDouble(Console.ReadLine());
        
            var ResultadoSubtrair = CalcFelipe.Subtrair(num1, num2);
            Show("A Subtração de " + num1 + " - " + num2 + " = " + ResultadoSubtrair);

            Show("----------------------------");
            Show("Digite a operação matemática desejada para continuar (+ ou -)");
            operador = Console.ReadLine();
    }
}


    void Show(string msg) {
        Console.WriteLine(msg);
    }