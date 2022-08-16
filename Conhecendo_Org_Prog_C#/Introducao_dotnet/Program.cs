using ExemploFuncoamentos.Common.Models;


List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("PA");

for (int contador = 0; contador < listaString.Count; contador++)
{
    System.Console.WriteLine($"Posição Nº {contador} - {listaString[contador]}");
}


Pessoa pessoa = new Pessoa();
pessoa.Nome = "Anderson";
pessoa.Idade = 31;
pessoa.Apresentar();

Calculadora calc = new Calculadora();

calc.Somar(10, 20);
calc.Subtracao(20, 10);



//int[] arrayInteiros = new int[3];
//arrayInteiros[0] = 72;
//arrayInteiros[1] = 64;
//arrayInteiros[2] = 50;

// copiando array 
//int[] arrayInteiroDobrado = new int[arrayInteiros.Length * 2];
//Array.Copy(arrayInteiros, arrayInteiroDobrado, arrayInteiros.Length);

// aumentando o tamanho do array
//Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// Percorrendo o array com o FOR
//System.Console.WriteLine("Percorrendo o array com o FOR");
//for (int contador = 0; contador < arrayInteiros.Length ; contador++)
//{
//    System.Console.WriteLine($"Posição Nº {contador} - {arrayInteiros[contador]}");   
//} 

//// Percorrendo o array com o FOREACH
//System.Console.WriteLine("Percorrendo o array com o FOREACH");

//int contadorForeach = 0;
//foreach(int valor in arrayInteiros)
//{
//    System.Console.WriteLine($"Posição Nº {contadorForeach} - {valor}");
//    contadorForeach++;
//}





//string opcao;
//bool exibirMenu = true;
//
//while (exibirMenu)
//{
//    System.Console.WriteLine("Digite a sua opção");
//    System.Console.WriteLine("1 - Cadastrar cliente");
//    System.Console.WriteLine("2 - Buscar cliente");
//    System.Console.WriteLine("3 - Apagar cliente");
//    System.Console.WriteLine("4 - Encerrar");
//
//    opcao = Console.ReadLine();
//
//    switch(opcao)
//    {
//        case "1":
//        System.Console.WriteLine("Cadastro do cliente");
//        break;
//
//        case "2":
//        System.Console.WriteLine("Busca do cliente");
//        break;
//
//        case "3":
//        System.Console.WriteLine("Apagar cliente");
//        break;
//
//        case "4":
//        //Environment.Exit(0);
//        exibirMenu = false;
//        break;
//
//        default:
//            System.Console.WriteLine("Opção Inválida");
//            break;
//    }   
//}
//
//System.Console.WriteLine("Programa encerrado");
//




//do
//{
//    System.Console.WriteLine("Digite um número (digite 0 para sair)");
//    numero = Convert.ToInt32(Console.ReadLine());
//
//    soma += numero;
//
//    
//            
//} while (numero != 0);
//
//System.Console.WriteLine($"Total da soma dos numeros digitados é: {soma}");



//double numero = 5;
//double contador = 0;
//
//while (contador <= 10)
//{
//    System.Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//    contador++;
//
//    // Interrompendo o fluxo de repetição
//    if (contador == 5)
//    {
//        break;    
//    }
//    
//}




//Calculadora calc = new Calculadora();

//calc.Somar(10,30);
//calc.Subtracao(10,30);
//calc.Multiplicar(10,30);
//calc.Dividir(10,30);
//calc.Potencia(2,2);

//calc.Seno(30);
//calc.Coseno(30);
//calc.Tangente(30);

//calc.RaizQuadrada(144);


